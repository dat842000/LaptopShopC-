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
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.btn_Buy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Total = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.displayCartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(201)))));
            this.lbl_Fullname.Location = new System.Drawing.Point(78, 41);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(59, 15);
            this.lbl_Fullname.TabIndex = 7;
            this.lbl_Fullname.Text = "Fullname";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(78, 117);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(186, 66);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_Phone.Location = new System.Drawing.Point(78, 100);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(48, 15);
            this.lbl_Phone.TabIndex = 9;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_Gender.Location = new System.Drawing.Point(78, 82);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(54, 15);
            this.lbl_Gender.TabIndex = 10;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(78, 65);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(44, 15);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureProfile.BackColor = System.Drawing.Color.White;
            this.pictureProfile.Location = new System.Drawing.Point(28, 38);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(41, 45);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfile.TabIndex = 6;
            this.pictureProfile.TabStop = false;
            // 
            // btn_Buy
            // 
            this.btn_Buy.AnimationHoverSpeed = 0.07F;
            this.btn_Buy.AnimationSpeed = 0.03F;
            this.btn_Buy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buy.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Buy.BorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Buy.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Buy.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Buy.CheckedImage")));
            this.btn_Buy.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Buy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Buy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_Buy.Image = null;
            this.btn_Buy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Buy.LineBottom = 3;
            this.btn_Buy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.btn_Buy.LineLeft = 3;
            this.btn_Buy.LineRight = 3;
            this.btn_Buy.LineTop = 3;
            this.btn_Buy.Location = new System.Drawing.Point(174, 129);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btn_Buy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Buy.OnHoverImage = null;
            this.btn_Buy.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btn_Buy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Buy.Size = new System.Drawing.Size(90, 27);
            this.btn_Buy.TabIndex = 3;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Total.Location = new System.Drawing.Point(25, 92);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(49, 20);
            this.Total.TabIndex = 13;
            this.Total.Text = "Total";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pictureProfile);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_Email);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_Gender);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_Fullname);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_Phone);
            this.guna2ShadowPanel1.Controls.Add(this.lblAddress);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(702, 54);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 8;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(297, 245);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // displayCartPanel
            // 
            this.displayCartPanel.AutoScroll = true;
            this.displayCartPanel.Location = new System.Drawing.Point(83, 54);
            this.displayCartPanel.Name = "displayCartPanel";
            this.displayCartPanel.Size = new System.Drawing.Size(609, 439);
            this.displayCartPanel.TabIndex = 12;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.btn_Buy);
            this.guna2ShadowPanel2.Controls.Add(this.Total);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(702, 305);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowShift = 8;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(297, 188);
            this.guna2ShadowPanel2.TabIndex = 15;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 615);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.displayCartPanel);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "frmCart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.PictureBox pictureProfile;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Buy;
        private System.Windows.Forms.Label Total;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.FlowLayoutPanel displayCartPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
    }
}