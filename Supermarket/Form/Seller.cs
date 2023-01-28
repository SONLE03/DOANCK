using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Seller : Form
    {
        public Reload reload;
        string imageLocation = "";
        SQLConnection SQLConnection = new SQLConnection();
        public Seller()
        {
            InitializeComponent();
        }
        public Seller(Reload _reload)
        {
            InitializeComponent();
            this.reload = _reload;
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            SQLConnection.OpenConnection();
            auto_id();
        }
        private void auto_id()
        {
            SqlCommand sqlCommand = new SqlCommand("AUTOEMID", SQLConnection.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
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
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                string check_em = "select * from employee where em_id = '" + id.Text + "'";
                string sql_UserName = "SELECT EM_USERNAME FROM EMPLOYEE WHERE EM_USERNAME= '" + username.Text + "'";
                if (pictureBox1.Image == null || position.Text == "" || id.Text == "" || name.Text == "" || username.Text == "" || pass.Text == "" || phone.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(sql_UserName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!this.email.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không đúng đỉnh dạng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey(check_em))
                {
                    String str = "Update EMPLOYEE Set EM_NAME = N'" + name.Text + "',EM_USERNAME = N'" + username.Text + "',EM_PASSWORD = '" + pass.Text + "',EM_PHONE = '" + phone.Text + "',EM_EMAIL = '" + email.Text + "',EM_POSITION = N'" + position.Text + "', EM_IMAGE = '" + imageLocation + "' Where EM_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thay đổi thông tin nhân viên thành công");
                    clear();
                    auto_id();
                }
                else
                {
                    string e_position;
                    if (position.Text == "Nhân Viên")
                    {
                        e_position = "NV";
                    }
                    else
                    {
                        e_position = "QTV";
                    }
                    // string query = "INSERT INTO EMPLOYEE(EM_ID, EM_NAME, EM_USERNAME, EM_PASSWORD, EM_PHONE, EM_EMAIL) VALUES(@EM_ID, @EM_NAME, @EM_USERNAME, @EM_PASSWORD, @EM_PHONE, @EM_EMAIL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertEM", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EM_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_Name", name.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_USERNAME", username.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PASSWORD", pass.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PHONE", phone.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_EMAIL", email.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_POSITION", e_position);
                    sqlCommand.Parameters.AddWithValue("@EM_IMAGE", imageLocation);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã đăng ký tài khoản thành công");
                    auto_id();
                    clear();          
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnection.CloseConnection();
            }
        }
        private void clear()
        {
            name.Clear();
            username.Clear();
            phone.Clear();
            pass.Clear();
            email.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.reload();
            Close();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();

                String str = "Select * From EMPLOYEE Where EM_ID = '" + id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    username.Text = dr.GetValue(2).ToString();
                    pass.Text = dr.GetValue(3).ToString();
                    phone.Text = dr.GetValue(4).ToString();
                    email.Text = dr.GetValue(5).ToString();
                    position.Text = dr.GetValue(6).ToString();
                    imageLocation = dr.GetValue(7).ToString();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pictureBox1.ImageLocation = imageLocation;
                SQLConnection.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void add_I_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
