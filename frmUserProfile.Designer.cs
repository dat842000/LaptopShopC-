namespace ProjectCsharp
{
    partial class frmUserProfile
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
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.lb_fullname = new FontAwesome.Sharp.IconButton();
            this.lb_email = new FontAwesome.Sharp.IconButton();
            this.lb_gender = new FontAwesome.Sharp.IconButton();
            this.lb_phone = new FontAwesome.Sharp.IconButton();
            this.lb_address = new FontAwesome.Sharp.IconButton();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureProfile.BackColor = System.Drawing.Color.White;
            this.pictureProfile.Location = new System.Drawing.Point(319, 88);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(140, 162);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfile.TabIndex = 0;
            this.pictureProfile.TabStop = false;
            // 
            // lb_fullname
            // 
            this.lb_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.FlatAppearance.BorderSize = 0;
            this.lb_fullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_fullname.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.lb_fullname.IconColor = System.Drawing.Color.Black;
            this.lb_fullname.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lb_fullname.IconSize = 20;
            this.lb_fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_fullname.Location = new System.Drawing.Point(511, 94);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(180, 26);
            this.lb_fullname.TabIndex = 6;
            this.lb_fullname.Text = "Fullname";
            this.lb_fullname.UseVisualStyleBackColor = true;
            // 
            // lb_email
            // 
            this.lb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_email.AutoSize = true;
            this.lb_email.FlatAppearance.BorderSize = 0;
            this.lb_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_email.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.lb_email.IconColor = System.Drawing.Color.Black;
            this.lb_email.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lb_email.IconSize = 20;
            this.lb_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_email.Location = new System.Drawing.Point(511, 131);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(180, 26);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email";
            this.lb_email.UseVisualStyleBackColor = true;
            // 
            // lb_gender
            // 
            this.lb_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_gender.AutoSize = true;
            this.lb_gender.FlatAppearance.BorderSize = 0;
            this.lb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_gender.IconChar = FontAwesome.Sharp.IconChar.VenusMars;
            this.lb_gender.IconColor = System.Drawing.Color.Black;
            this.lb_gender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lb_gender.IconSize = 22;
            this.lb_gender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_gender.Location = new System.Drawing.Point(511, 165);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(180, 28);
            this.lb_gender.TabIndex = 6;
            this.lb_gender.Text = "Gender";
            this.lb_gender.UseVisualStyleBackColor = true;
            // 
            // lb_phone
            // 
            this.lb_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_phone.AutoSize = true;
            this.lb_phone.FlatAppearance.BorderSize = 0;
            this.lb_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_phone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.lb_phone.IconColor = System.Drawing.Color.Black;
            this.lb_phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lb_phone.IconSize = 20;
            this.lb_phone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_phone.Location = new System.Drawing.Point(511, 194);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(180, 26);
            this.lb_phone.TabIndex = 6;
            this.lb_phone.Text = "Phone";
            this.lb_phone.UseVisualStyleBackColor = true;
            // 
            // lb_address
            // 
            this.lb_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_address.AutoSize = true;
            this.lb_address.FlatAppearance.BorderSize = 0;
            this.lb_address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_address.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.lb_address.IconColor = System.Drawing.Color.Black;
            this.lb_address.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lb_address.IconSize = 22;
            this.lb_address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_address.Location = new System.Drawing.Point(511, 223);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(180, 28);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "Address";
            this.lb_address.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Logout.Animated = true;
            this.btn_Logout.AutoRoundedCorners = true;
            this.btn_Logout.BorderRadius = 21;
            this.btn_Logout.CheckedState.Parent = this.btn_Logout;
            this.btn_Logout.CustomImages.Parent = this.btn_Logout;
            this.btn_Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.HoverState.Parent = this.btn_Logout;
            this.btn_Logout.Location = new System.Drawing.Point(373, 277);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.ShadowDecoration.Parent = this.btn_Logout;
            this.btn_Logout.Size = new System.Drawing.Size(199, 45);
            this.btn_Logout.TabIndex = 19;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.pictureProfile);
            this.Name = "frmUserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureProfile;
        private FontAwesome.Sharp.IconButton lb_fullname;
        private FontAwesome.Sharp.IconButton lb_email;
        private FontAwesome.Sharp.IconButton lb_gender;
        private FontAwesome.Sharp.IconButton lb_phone;
        private FontAwesome.Sharp.IconButton lb_address;
        internal Guna.UI2.WinForms.Guna2GradientButton btn_Logout;
    }
}