namespace ProjectCsharp
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.lsvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.btn_Buy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvShow
            // 
            this.lsvShow.AutoArrange = false;
            this.lsvShow.CheckBoxes = true;
            this.lsvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvShow.FullRowSelect = true;
            this.lsvShow.GridLines = true;
            this.lsvShow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvShow.HideSelection = false;
            this.lsvShow.Location = new System.Drawing.Point(77, 82);
            this.lsvShow.MultiSelect = false;
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(354, 327);
            this.lsvShow.TabIndex = 0;
            this.lsvShow.TileSize = new System.Drawing.Size(100, 50);
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            this.lsvShow.View = System.Windows.Forms.View.Details;
            this.lsvShow.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvShow_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Specs";
            this.columnHeader3.Width = 100;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Total.Location = new System.Drawing.Point(76, 412);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(52, 20);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total :";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(77, 21);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 6;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(354, 61);
            this.gunaGradient2Panel1.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(17, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(48, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Cart";
            // 
            // btn_Delete
            // 
            this.btn_Delete.AnimationHoverSpeed = 0.07F;
            this.btn_Delete.AnimationSpeed = 0.03F;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_Delete.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.CheckedImage")));
            this.btn_Delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = null;
            this.btn_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Delete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete.Location = new System.Drawing.Point(238, 415);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Delete.OnHoverImage = null;
            this.btn_Delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete.Radius = 6;
            this.btn_Delete.Size = new System.Drawing.Size(90, 27);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fullname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Fullname.Location = new System.Drawing.Point(515, 211);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(68, 18);
            this.lbl_Fullname.TabIndex = 7;
            this.lbl_Fullname.Text = "Fullname";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Location = new System.Drawing.Point(515, 354);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 18);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Phone.Location = new System.Drawing.Point(515, 317);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(51, 18);
            this.lbl_Phone.TabIndex = 9;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Gender.Location = new System.Drawing.Point(515, 282);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(57, 18);
            this.lbl_Gender.TabIndex = 10;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Email.Location = new System.Drawing.Point(515, 246);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 18);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureProfile.BackColor = System.Drawing.Color.White;
            this.pictureProfile.Location = new System.Drawing.Point(564, 21);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(140, 162);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfile.TabIndex = 6;
            this.pictureProfile.TabStop = false;
            // 
            // btn_Buy
            // 
            this.btn_Buy.AnimationHoverSpeed = 0.07F;
            this.btn_Buy.AnimationSpeed = 0.03F;
            this.btn_Buy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_Buy.BorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Buy.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Buy.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Buy.CheckedImage")));
            this.btn_Buy.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Buy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Buy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Buy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Buy.ForeColor = System.Drawing.Color.White;
            this.btn_Buy.Image = null;
            this.btn_Buy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Buy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Buy.Location = new System.Drawing.Point(341, 415);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_Buy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Buy.OnHoverImage = null;
            this.btn_Buy.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Buy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Buy.Radius = 6;
            this.btn_Buy.Size = new System.Drawing.Size(90, 27);
            this.btn_Buy.TabIndex = 3;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lbl_Fullname);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.pictureProfile);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.lsvShow);
            this.Name = "frmCart";
            this.Text = "Cart";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvShow;
        private System.Windows.Forms.Label Total;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete;
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.PictureBox pictureProfile;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Buy;
    }
}