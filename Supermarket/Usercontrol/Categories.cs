using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket
{
    public partial class Categories : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Categories()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            id_name.Text = "";
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM CATEGORY";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }
        
        private void Categories_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory(_reload);
            frmCategory.ShowDialog();
        }
        private void _reload()
        {
            showdata();
        }
        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("CAT_ID like '%" + id_name.Text + "%' OR CAT_NAME like '%" + id_name.Text + "%'");
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
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String checkcat = "Select * from category where cat_id = '" + id_name.Text + "'";
                String checkpro = "Select * from category, product where category.cat_id = product.cat_id and category.cat_id = '" + id_name.Text + "'";
                if (id_name.Text == "" || !CheckKey(checkcat))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(checkpro))
                {
                    MessageBox.Show("Loại sản phẩm có tồn tại sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String cat = "Delete From CATEGORY Where CAT_ID = '" + id_name.Text + "'";
                    SqlCommand cmd = new SqlCommand(cat, SQLConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thông tin thành công");
                    showdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnection.CloseConnection();
            }
        }
    }
}
