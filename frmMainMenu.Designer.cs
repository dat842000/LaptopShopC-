namespace ProjectCsharp
{
    partial class frmMainMenu
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Profile = new FontAwesome.Sharp.IconButton();
            this.btn_History = new FontAwesome.Sharp.IconButton();
            this.btn_Order = new FontAwesome.Sharp.IconButton();
            this.btn_Cart = new FontAwesome.Sharp.IconButton();
            this.btn_Shop = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.panelShadow);
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Controls.Add(this.panelMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1078, 550);
            this.panelDesktop.TabIndex = 4;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(858, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(858, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 17;
            this.btnMinimize.Location = new System.Drawing.Point(743, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 23);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 17;
            this.btnMaximize.Location = new System.Drawing.Point(782, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 17;
            this.btnExit.Location = new System.Drawing.Point(819, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(57, 28);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(47, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_Profile);
            this.panelMenu.Controls.Add(this.btn_History);
            this.panelMenu.Controls.Add(this.btn_Order);
            this.panelMenu.Controls.Add(this.btn_Cart);
            this.panelMenu.Controls.Add(this.btn_Shop);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_Profile
            // 
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Profile.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btn_Profile.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(0, 380);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Profile.Size = new System.Drawing.Size(220, 60);
            this.btn_Profile.TabIndex = 6;
            this.btn_Profile.Text = "User Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_History
            // 
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_History.FlatAppearance.BorderSize = 0;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_History.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btn_History.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_History.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(0, 320);
            this.btn_History.Name = "btn_History";
            this.btn_History.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_History.Size = new System.Drawing.Size(220, 60);
            this.btn_History.TabIndex = 5;
            this.btn_History.Text = "History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Order.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_Order.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Order.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Order.Location = new System.Drawing.Point(0, 260);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Order.Size = new System.Drawing.Size(220, 60);
            this.btn_Order.TabIndex = 4;
            this.btn_Order.Text = "Order";
            this.btn_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Cart
            // 
            this.btn_Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cart.FlatAppearance.BorderSize = 0;
            this.btn_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Cart.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Cart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cart.Location = new System.Drawing.Point(0, 200);
            this.btn_Cart.Name = "btn_Cart";
            this.btn_Cart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Cart.Size = new System.Drawing.Size(220, 60);
            this.btn_Cart.TabIndex = 3;
            this.btn_Cart.Text = "Cart";
            this.btn_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cart.UseVisualStyleBackColor = true;
            this.btn_Cart.Click += new System.EventHandler(this.btn_Cart_Click);
            // 
            // btn_Shop
            // 
            this.btn_Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Shop.FlatAppearance.BorderSize = 0;
            this.btn_Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Shop.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btn_Shop.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Shop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Shop.Location = new System.Drawing.Point(0, 140);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Shop.Size = new System.Drawing.Size(220, 60);
            this.btn_Shop.TabIndex = 2;
            this.btn_Shop.Text = "Shop";
            this.btn_Shop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Shop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Shop.UseVisualStyleBackColor = true;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY ONLINE STORE";
            // 
            // btn_Home
            // 
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Image = global::ProjectCsharp.Properties.Resources.MainLogo;
            this.btn_Home.Location = new System.Drawing.Point(38, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(145, 108);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 1;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 550);
            this.Controls.Add(this.panelDesktop);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Profile;
        private FontAwesome.Sharp.IconButton btn_History;
        private FontAwesome.Sharp.IconButton btn_Order;
        private FontAwesome.Sharp.IconButton btn_Cart;
        private FontAwesome.Sharp.IconButton btn_Shop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Home;
    }
}