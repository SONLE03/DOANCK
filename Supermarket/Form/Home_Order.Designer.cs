namespace Supermarket
{
    partial class Home_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.order = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.customer = new System.Windows.Forms.Button();
            this.control_panel = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.product_type = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.order1 = new Supermarket.Order();
            this.products1 = new Supermarket.Products();
            this.categories1 = new Supermarket.Categories();
            this.customers1 = new Supermarket.Customers();
            this.bill1 = new Supermarket.Usercontrol.Bill();
            this.setting_Employee1 = new Supermarket.Setting_Employee();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.control_panel);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.bill);
            this.panel1.Controls.Add(this.product_type);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 800);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Supermarket.Properties.Resources.cupcake;
            this.pictureBox5.Location = new System.Drawing.Point(47, 148);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(93, 148);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(219, 40);
            this.order.TabIndex = 22;
            this.order.Text = "Đơn hàng";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox2.Location = new System.Drawing.Point(47, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // setting
            // 
            this.setting.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.Location = new System.Drawing.Point(93, 498);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(219, 40);
            this.setting.TabIndex = 20;
            this.setting.Text = "Cài đặt";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox7.Location = new System.Drawing.Point(47, 428);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(93, 428);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(219, 40);
            this.customer.TabIndex = 18;
            this.customer.Text = "Khách hàng";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.Gray;
            this.control_panel.Location = new System.Drawing.Point(0, 148);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(10, 40);
            this.control_panel.TabIndex = 17;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Supermarket.Properties.Resources.logout;
            this.pictureBox8.Location = new System.Drawing.Point(47, 715);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Supermarket.Properties.Resources.bill;
            this.pictureBox6.Location = new System.Drawing.Point(47, 358);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.box;
            this.pictureBox4.Location = new System.Drawing.Point(47, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.cupcake;
            this.pictureBox3.Location = new System.Drawing.Point(47, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(93, 715);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 40);
            this.logout.TabIndex = 7;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(93, 358);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(219, 40);
            this.bill.TabIndex = 5;
            this.bill.Text = "Hóa đơn";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // product_type
            // 
            this.product_type.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_type.Location = new System.Drawing.Point(93, 288);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(219, 40);
            this.product_type.TabIndex = 3;
            this.product_type.Text = "Loại sản phẩm";
            this.product_type.UseVisualStyleBackColor = true;
            this.product_type.Click += new System.EventHandler(this.product_type_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(93, 218);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(219, 40);
            this.product.TabIndex = 2;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(65, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // order1
            // 
            this.order1.Location = new System.Drawing.Point(347, 0);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(1200, 800);
            this.order1.TabIndex = 2;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.White;
            this.products1.Location = new System.Drawing.Point(347, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1209, 800);
            this.products1.TabIndex = 3;
            // 
            // categories1
            // 
            this.categories1.BackColor = System.Drawing.Color.White;
            this.categories1.Location = new System.Drawing.Point(347, 0);
            this.categories1.Name = "categories1";
            this.categories1.Size = new System.Drawing.Size(1208, 797);
            this.categories1.TabIndex = 4;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(347, 0);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1208, 800);
            this.customers1.TabIndex = 5;
            // 
            // bill1
            // 
            this.bill1.Location = new System.Drawing.Point(347, 0);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(1208, 800);
            this.bill1.TabIndex = 6;
            // 
            // setting_Employee1
            // 
            this.setting_Employee1.Location = new System.Drawing.Point(347, 0);
            this.setting_Employee1.Name = "setting_Employee1";
            this.setting_Employee1.Size = new System.Drawing.Size(1208, 800);
            this.setting_Employee1.TabIndex = 7;
            // 
            // Home_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 800);
            this.Controls.Add(this.setting_Employee1);
            this.Controls.Add(this.bill1);
            this.Controls.Add(this.customers1);
            this.Controls.Add(this.categories1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.order1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Order";
            this.Load += new System.EventHandler(this.Home_Order_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button product_type;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button setting;
        private Order order1;
        private Products products1;
        private Categories categories1;
        private Customers customers1;
        private Usercontrol.Bill bill1;
        private Setting_Employee setting_Employee1;
    }
}