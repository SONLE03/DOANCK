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
using System.Windows.Forms.DataVisualization.Charting;
using static Supermarket.FrmBillInfo;

namespace Supermarket
{
    public partial class FrmProductDetail : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public string p_id = "";
        public delegate void P_ID(string id);
        public P_ID p_ID;
        public FrmProductDetail()
        {
            InitializeComponent();
            p_ID = new P_ID(GetID);
        } 
        private void GetID(string id)
        {
            p_id = id;
        }
        private void showdata()
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "Select * FROM PRODUCT JOIN CATEGORY ON PRODUCT.CAT_ID = CATEGORY.CAT_ID WHERE PRO_ID = '" + p_id + "'";
                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name.Text = dr.GetValue(1).ToString();
                    id.Text = dr.GetValue(0).ToString();
                    quantity.Text = dr.GetValue(2).ToString();
                    price.Text = dr.GetValue(3).ToString();
                    des.Text = dr.GetValue(4).ToString();
                    cate.Text = dr.GetValue(8).ToString();
                    image.ImageLocation = dr.GetValue(6).ToString();
                }
                else
                {

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

        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String pro = "Delete From PRODUCT Where PRO_ID = '" + id.Text + "'";
                SqlCommand cmdPro = new SqlCommand(pro, SQLConnection.con);
                cmdPro.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thông tin thành công");
                SQLConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
