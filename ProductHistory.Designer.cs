namespace ProjectCsharp
{
    partial class ProductHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductHistory));
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_shippeddate = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(477, 29);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(82, 17);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Order Status";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(383, 29);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(59, 17);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_shippeddate
            // 
            this.lbl_shippeddate.AutoSize = true;
            this.lbl_shippeddate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shippeddate.Location = new System.Drawing.Point(204, 29);
            this.lbl_shippeddate.Name = "lbl_shippeddate";
            this.lbl_shippeddate.Size = new System.Drawing.Size(90, 17);
            this.lbl_shippeddate.TabIndex = 4;
            this.lbl_shippeddate.Text = "Shipped Date";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderdate.Location = new System.Drawing.Point(109, 29);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(75, 17);
            this.lbl_orderdate.TabIndex = 5;
            this.lbl_orderdate.Text = "Order Date";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(25, 29);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 17);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(627, 23);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(2, -2);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(655, 10);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(28, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 305);
            this.panel1.TabIndex = 10;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(572, 29);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(37, 17);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "Total";
            // 
            // ProductHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_shippeddate);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.lbl_ID);
            this.Name = "ProductHistory";
            this.Size = new System.Drawing.Size(674, 72);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label lbl_status;
        public System.Windows.Forms.Label lbl_quantity;
        public System.Windows.Forms.Label lbl_shippeddate;
        public System.Windows.Forms.Label lbl_orderdate;
        public System.Windows.Forms.Label lbl_ID;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_Total;
    }
}
