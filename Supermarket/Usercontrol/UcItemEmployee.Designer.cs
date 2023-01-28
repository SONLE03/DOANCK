namespace Supermarket
{
    partial class UcItemEmployee
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
            this.Id = new System.Windows.Forms.Label();
            this.E_phone = new System.Windows.Forms.Label();
            this.E_name = new System.Windows.Forms.Label();
            this.E_position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).BeginInit();
            this.SuspendLayout();
            // 
            // P_image
            // 
            this.P_image.Location = new System.Drawing.Point(50, 25);
            this.P_image.Name = "P_image";
            this.P_image.Size = new System.Drawing.Size(120, 108);
            this.P_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_image.TabIndex = 1;
            this.P_image.TabStop = false;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(491, 25);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(44, 16);
            this.Id.TabIndex = 6;
            this.Id.Text = "label1";
            this.Id.Visible = false;
            // 
            // E_phone
            // 
            this.E_phone.AutoSize = true;
            this.E_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_phone.Location = new System.Drawing.Point(351, 65);
            this.E_phone.Name = "E_phone";
            this.E_phone.Size = new System.Drawing.Size(128, 28);
            this.E_phone.TabIndex = 5;
            this.E_phone.Text = "Số điện thoại";
            this.E_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // E_name
            // 
            this.E_name.AutoSize = true;
            this.E_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_name.Location = new System.Drawing.Point(207, 25);
            this.E_name.Name = "E_name";
            this.E_name.Size = new System.Drawing.Size(140, 28);
            this.E_name.TabIndex = 4;
            this.E_name.Text = "Tên nhân viên";
            this.E_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // E_position
            // 
            this.E_position.AutoSize = true;
            this.E_position.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_position.Location = new System.Drawing.Point(303, 105);
            this.E_position.Name = "E_position";
            this.E_position.Size = new System.Drawing.Size(82, 28);
            this.E_position.TabIndex = 7;
            this.E_position.Text = "Chức vụ";
            this.E_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số điện thoại:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chức vụ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcItemEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.E_position);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.E_phone);
            this.Controls.Add(this.E_name);
            this.Controls.Add(this.P_image);
            this.Name = "UcItemEmployee";
            this.Size = new System.Drawing.Size(550, 162);
            this.Click += new System.EventHandler(this.UcItemEmployee_Click);
            this.MouseEnter += new System.EventHandler(this.UcItemEmployee_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcItemEmployee_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_image;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label E_phone;
        private System.Windows.Forms.Label E_name;
        private System.Windows.Forms.Label E_position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
