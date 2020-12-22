namespace ProjectCsharp
{
    partial class ProductHistoryDetailUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductHistoryDetailUC));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.processing = new System.Windows.Forms.PictureBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.pending = new System.Windows.Forms.PictureBox();
            this.lbl_specs = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_unitprice = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_shippeddate = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Gainsboro;
            this.bunifuCards1.Controls.Add(this.processing);
            this.bunifuCards1.Controls.Add(this.img);
            this.bunifuCards1.Controls.Add(this.pending);
            this.bunifuCards1.Controls.Add(this.lbl_specs);
            this.bunifuCards1.Controls.Add(this.lbl_status);
            this.bunifuCards1.Controls.Add(this.lbl_unitprice);
            this.bunifuCards1.Controls.Add(this.Quantity);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.lbl_quantity);
            this.bunifuCards1.Controls.Add(this.lbl_shippeddate);
            this.bunifuCards1.Controls.Add(this.lbl_orderdate);
            this.bunifuCards1.Controls.Add(this.lbl_productname);
            this.bunifuCards1.Controls.Add(this.lbl_name);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(8, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(585, 67);
            this.bunifuCards1.TabIndex = 0;
            // 
            // processing
            // 
            this.processing.Image = ((System.Drawing.Image)(resources.GetObject("processing.Image")));
            this.processing.Location = new System.Drawing.Point(309, 32);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(18, 18);
            this.processing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processing.TabIndex = 12;
            this.processing.TabStop = false;
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(12, 22);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(48, 38);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 12;
            this.img.TabStop = false;
            // 
            // pending
            // 
            this.pending.Image = ((System.Drawing.Image)(resources.GetObject("pending.Image")));
            this.pending.Location = new System.Drawing.Point(214, 32);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(18, 18);
            this.pending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pending.TabIndex = 12;
            this.pending.TabStop = false;
            // 
            // lbl_specs
            // 
            this.lbl_specs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_specs.Location = new System.Drawing.Point(375, 32);
            this.lbl_specs.Name = "lbl_specs";
            this.lbl_specs.Size = new System.Drawing.Size(49, 17);
            this.lbl_specs.TabIndex = 7;
            this.lbl_specs.Text = "Specs";
            this.lbl_specs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(375, 12);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 17);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Specs";
            // 
            // lbl_unitprice
            // 
            this.lbl_unitprice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unitprice.Location = new System.Drawing.Point(430, 33);
            this.lbl_unitprice.Name = "lbl_unitprice";
            this.lbl_unitprice.Size = new System.Drawing.Size(65, 17);
            this.lbl_unitprice.TabIndex = 8;
            this.lbl_unitprice.Text = "Unit Price";
            this.lbl_unitprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(431, 12);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(64, 17);
            this.lbl_quantity.TabIndex = 8;
            this.lbl_quantity.Text = "Unit Price";
            // 
            // lbl_shippeddate
            // 
            this.lbl_shippeddate.AutoSize = true;
            this.lbl_shippeddate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shippeddate.Location = new System.Drawing.Point(282, 12);
            this.lbl_shippeddate.Name = "lbl_shippeddate";
            this.lbl_shippeddate.Size = new System.Drawing.Size(71, 17);
            this.lbl_shippeddate.TabIndex = 9;
            this.lbl_shippeddate.Text = "Processing";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderdate.Location = new System.Drawing.Point(199, 12);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(56, 17);
            this.lbl_orderdate.TabIndex = 10;
            this.lbl_orderdate.Text = "Pending";
            // 
            // lbl_productname
            // 
            this.lbl_productname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productname.Location = new System.Drawing.Point(71, 33);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(137, 17);
            this.lbl_productname.TabIndex = 11;
            this.lbl_productname.Text = "Product Name";
            this.lbl_productname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(71, 12);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(94, 17);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Quantity.Location = new System.Drawing.Point(510, 32);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(59, 17);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // ProductHistoryDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ProductHistoryDetailUC";
            this.Size = new System.Drawing.Size(600, 75);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_shippeddate;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_specs;
        public System.Windows.Forms.Label lbl_unitprice;
        public System.Windows.Forms.Label lbl_productname;
        public System.Windows.Forms.PictureBox processing;
        public System.Windows.Forms.PictureBox pending;
        public System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Quantity;
    }
}
