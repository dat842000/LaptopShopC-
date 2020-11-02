namespace ProjectCsharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.btnCart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecs = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.LinkLabel();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laptop AVBC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(1069, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(1118, 13);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(61, 17);
            this.lblRegister.TabIndex = 2;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "Register";
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(1104, 86);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 23);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerToolStripMenuItem,
            this.asusToolStripMenuItem,
            this.dellToolStripMenuItem,
            this.hPToolStripMenuItem,
            this.lenovoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(382, 81);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acerToolStripMenuItem
            // 
            this.acerToolStripMenuItem.Name = "acerToolStripMenuItem";
            this.acerToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.acerToolStripMenuItem.Text = "Acer";
            // 
            // asusToolStripMenuItem
            // 
            this.asusToolStripMenuItem.Name = "asusToolStripMenuItem";
            this.asusToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.asusToolStripMenuItem.Text = "Asus";
            // 
            // dellToolStripMenuItem
            // 
            this.dellToolStripMenuItem.Name = "dellToolStripMenuItem";
            this.dellToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.dellToolStripMenuItem.Text = "Dell";
            // 
            // hPToolStripMenuItem
            // 
            this.hPToolStripMenuItem.Name = "hPToolStripMenuItem";
            this.hPToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.hPToolStripMenuItem.Text = "HP";
            // 
            // lenovoToolStripMenuItem
            // 
            this.lenovoToolStripMenuItem.Name = "lenovoToolStripMenuItem";
            this.lenovoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.lenovoToolStripMenuItem.Text = "Lenovo";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(13, 111);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(356, 444);
            this.dgvProducts.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(715, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 73);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(751, 207);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 17);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "lblID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(721, 224);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 29);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "lblName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Specs:";
            // 
            // txtSpecs
            // 
            this.txtSpecs.Location = new System.Drawing.Point(688, 311);
            this.txtSpecs.Multiline = true;
            this.txtSpecs.Name = "txtSpecs";
            this.txtSpecs.Size = new System.Drawing.Size(173, 124);
            this.txtSpecs.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(725, 449);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 31);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "lblPrice";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(726, 511);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 23);
            this.btnAddToCart.TabIndex = 15;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(1069, 43);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(48, 17);
            this.lblProfile.TabIndex = 16;
            this.lblProfile.TabStop = true;
            this.lblProfile.Text = "Profile";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(1123, 43);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(52, 17);
            this.lblLogout.TabIndex = 16;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 567);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtSpecs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acerToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem asusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenovoToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.LinkLabel lblProfile;
        private System.Windows.Forms.LinkLabel lblLogout;
    }
}

