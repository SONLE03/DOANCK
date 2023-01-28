using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supermarket.FrmProductDetail;
using static System.Net.Mime.MediaTypeNames;

namespace Supermarket
{
    public partial class FrmEmployeeDetail : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public string e_id = "";
        public delegate void E_ID(string id);
        public E_ID e_ID;
        public FrmEmployeeDetail()
        {
            InitializeComponent();
            e_ID = new E_ID(GetID);
        }
        private void GetID(string id)
        {
            e_id = id;
        }
        private void showdata()
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "Select * FROM EMPLOYEE WHERE EM_ID = '" + e_id + "'";
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
                    image.ImageLocation = dr.GetValue(7).ToString();
                }
                else
                {

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

        private void FrmEmployeeDetail_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String em = "Delete From EMPLOYEE Where EM_ID = '" + id.Text + "'";
                SqlCommand cmdEm = new SqlCommand(em, SQLConnection.con);
                cmdEm.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thông tin thành công");
                SQLConnection.CloseConnection();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
