using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Customers : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Customers()
        {
            InitializeComponent();
        }
        private void _reload()
        {
            showdata();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM CUSTOMER";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer(_reload);
            frmCustomer.ShowDialog();
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("CUS_NAME like '%" + id_name.Text + "%' OR CUS_ID like '%" + id_name.Text + "%'");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_name.Text = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value);
        }
        private bool CheckKey(string sql)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SQLConnection.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                String check_cus = "Select * customer where cus_id= '" + id_name.Text + "'";
                String check_bill = "Select * from bill, customer where bill.cus_id = customer.cus_id and customer.cus_id = '" + id_name.Text + "'";
                if (id_name.Text == "" || !CheckKey(check_cus))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(check_bill))
                {
                    MessageBox.Show("Khách hàng đã tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String cus = "Delete From CUSTOMER Where CUS_ID = '" + id_name.Text + "'";
                    SqlCommand cmdcus = new SqlCommand(cus, SQLConnection.con);
                    cmdcus.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thông tin thành công");
                    showdata();
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
