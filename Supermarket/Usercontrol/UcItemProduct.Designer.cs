namespace Supermarket
{
    partial class UcItemProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_image = new System.Windows.Forms.PictureBox();
            this.P_name = new System.Windows.Forms.Label();
            this.P_price = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).BeginInit();
            this.SuspendLayout();
            // 
            // P_image
            // 
            this.P_image.Location = new System.Drawing.Point(20, 13);
            this.P_image.Name = "P_image";
            this.P_image.Size = new System.Drawing.Size(230, 200);
            this.P_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_image.TabIndex = 0;
            this.P_image.TabStop = false;
            // 
            // P_name
            // 
            this.P_name.AutoSize = true;
            this.P_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_name.Location = new System.Drawing.Point(15, 216);
            this.P_name.Name = "P_name";
            this.P_name.Size = new System.Drawing.Size(139, 28);
            this.P_name.TabIndex = 1;
            this.P_name.Text = "Tên sản phẩm";
            this.P_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_price
            // 
            this.P_price.AutoSize = true;
            this.P_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_price.Location = new System.Drawing.Point(15, 244);
            this.P_price.Name = "P_price";
            this.P_price.Size = new System.Drawing.Size(41, 28);
            this.P_price.TabIndex = 2;
            this.P_price.Text = "Giá";
            this.P_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(206, 226);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(44, 16);
            this.Id.TabIndex = 3;
            this.Id.Text = "label1";
            this.Id.Visible = false;
            // 
            // UcItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Id);
            this.Controls.Add(this.P_price);
            this.Controls.Add(this.P_name);
            this.Controls.Add(this.P_image);
            this.Name = "UcItemProduct";
            this.Size = new System.Drawing.Size(275, 280);
            this.Click += new System.EventHandler(this.UcItemProduct_Click);
            this.MouseEnter += new System.EventHandler(this.UcItemProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcItemProduct_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_image;
        private System.Windows.Forms.Label P_name;
        private System.Windows.Forms.Label P_price;
        private System.Windows.Forms.Label Id;
    }
}
