namespace ProjectCsharp
{
    partial class frmLogin
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pn_regis = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.genderRegis = new Guna.UI.WinForms.GunaCheckBox();
            this.picRegis = new System.Windows.Forms.PictureBox();
            this.nameRegis = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressRegis = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailRegis = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneRegis = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.userRisgis = new Guna.UI2.WinForms.Guna2TextBox();
            this.passRegis = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.btn_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pn_login = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Create = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lb_PasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_UsernameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pn_regis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegis)).BeginInit();
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_regis
            // 
            this.pn_regis.BackColor = System.Drawing.Color.Transparent;
            this.pn_regis.Controls.Add(this.genderRegis);
            this.pn_regis.Controls.Add(this.picRegis);
            this.pn_regis.Controls.Add(this.nameRegis);
            this.pn_regis.Controls.Add(this.addressRegis);
            this.pn_regis.Controls.Add(this.emailRegis);
            this.pn_regis.Controls.Add(this.phoneRegis);
            this.pn_regis.Controls.Add(this.Label4);
            this.pn_regis.Controls.Add(this.userRisgis);
            this.pn_regis.Controls.Add(this.passRegis);
            this.pn_regis.Controls.Add(this.btnSubmit);
            this.pn_regis.Controls.Add(this.Clear);
            this.pn_regis.Controls.Add(this.Login);
            this.pn_regis.Controls.Add(this.btn_Register);
            this.guna2Transition1.SetDecoration(this.pn_regis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_regis.FillColor = System.Drawing.Color.White;
            this.pn_regis.Location = new System.Drawing.Point(282, -1);
            this.pn_regis.Name = "pn_regis";
            this.pn_regis.ShadowColor = System.Drawing.Color.White;
            this.pn_regis.ShadowDepth = 80;
            this.pn_regis.ShadowShift = 10;
            this.pn_regis.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_regis.Size = new System.Drawing.Size(547, 488);
            this.pn_regis.TabIndex = 13;
            // 
            // genderRegis
            // 
            this.genderRegis.BaseColor = System.Drawing.Color.White;
            this.genderRegis.CheckedOffColor = System.Drawing.Color.Gray;
            this.genderRegis.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Transition1.SetDecoration(this.genderRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.genderRegis.FillColor = System.Drawing.Color.White;
            this.genderRegis.Location = new System.Drawing.Point(275, 365);
            this.genderRegis.Name = "genderRegis";
            this.genderRegis.Size = new System.Drawing.Size(20, 20);
            this.genderRegis.TabIndex = 13;
            this.genderRegis.CheckedChanged += new System.EventHandler(this.genderRegis_CheckedChanged);
            // 
            // picRegis
            // 
            this.picRegis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Transition1.SetDecoration(this.picRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picRegis.Location = new System.Drawing.Point(84, 89);
            this.picRegis.Name = "picRegis";
            this.picRegis.Size = new System.Drawing.Size(100, 109);
            this.picRegis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegis.TabIndex = 11;
            this.picRegis.TabStop = false;
            // 
            // nameRegis
            // 
            this.nameRegis.Animated = true;
            this.nameRegis.BorderRadius = 8;
            this.nameRegis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.nameRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nameRegis.DefaultText = "";
            this.nameRegis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameRegis.DisabledState.Parent = this.nameRegis;
            this.nameRegis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nameRegis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameRegis.FocusedState.Parent = this.nameRegis;
            this.nameRegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameRegis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameRegis.HoverState.Parent = this.nameRegis;
            this.nameRegis.Location = new System.Drawing.Point(269, 181);
            this.nameRegis.Name = "nameRegis";
            this.nameRegis.PasswordChar = '\0';
            this.nameRegis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameRegis.PlaceholderText = "Fullname";
            this.nameRegis.SelectedText = "";
            this.nameRegis.ShadowDecoration.Parent = this.nameRegis;
            this.nameRegis.Size = new System.Drawing.Size(243, 36);
            this.nameRegis.TabIndex = 9;
            // 
            // addressRegis
            // 
            this.addressRegis.Animated = true;
            this.addressRegis.BorderRadius = 8;
            this.addressRegis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.addressRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addressRegis.DefaultText = "";
            this.addressRegis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressRegis.DisabledState.Parent = this.addressRegis;
            this.addressRegis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.addressRegis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressRegis.FocusedState.Parent = this.addressRegis;
            this.addressRegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressRegis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressRegis.HoverState.Parent = this.addressRegis;
            this.addressRegis.Location = new System.Drawing.Point(269, 315);
            this.addressRegis.Name = "addressRegis";
            this.addressRegis.PasswordChar = '\0';
            this.addressRegis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.addressRegis.PlaceholderText = "Address";
            this.addressRegis.SelectedText = "";
            this.addressRegis.ShadowDecoration.Parent = this.addressRegis;
            this.addressRegis.Size = new System.Drawing.Size(243, 36);
            this.addressRegis.TabIndex = 10;
            // 
            // emailRegis
            // 
            this.emailRegis.Animated = true;
            this.emailRegis.BorderRadius = 8;
            this.emailRegis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.emailRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.emailRegis.DefaultText = "";
            this.emailRegis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailRegis.DisabledState.Parent = this.emailRegis;
            this.emailRegis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.emailRegis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailRegis.FocusedState.Parent = this.emailRegis;
            this.emailRegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailRegis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailRegis.HoverState.Parent = this.emailRegis;
            this.emailRegis.Location = new System.Drawing.Point(269, 270);
            this.emailRegis.Name = "emailRegis";
            this.emailRegis.PasswordChar = '\0';
            this.emailRegis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.emailRegis.PlaceholderText = "Email";
            this.emailRegis.SelectedText = "";
            this.emailRegis.ShadowDecoration.Parent = this.emailRegis;
            this.emailRegis.Size = new System.Drawing.Size(243, 36);
            this.emailRegis.TabIndex = 10;
            // 
            // phoneRegis
            // 
            this.phoneRegis.Animated = true;
            this.phoneRegis.BorderRadius = 8;
            this.phoneRegis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.phoneRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.phoneRegis.DefaultText = "";
            this.phoneRegis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneRegis.DisabledState.Parent = this.phoneRegis;
            this.phoneRegis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.phoneRegis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneRegis.FocusedState.Parent = this.phoneRegis;
            this.phoneRegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneRegis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneRegis.HoverState.Parent = this.phoneRegis;
            this.phoneRegis.Location = new System.Drawing.Point(269, 226);
            this.phoneRegis.Name = "phoneRegis";
            this.phoneRegis.PasswordChar = '\0';
            this.phoneRegis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneRegis.PlaceholderText = "Phone";
            this.phoneRegis.SelectedText = "";
            this.phoneRegis.ShadowDecoration.Parent = this.phoneRegis;
            this.phoneRegis.Size = new System.Drawing.Size(243, 36);
            this.phoneRegis.TabIndex = 10;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(212, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 31);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Register";
            // 
            // userRisgis
            // 
            this.userRisgis.Animated = true;
            this.userRisgis.BorderRadius = 8;
            this.userRisgis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.userRisgis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userRisgis.DefaultText = "";
            this.userRisgis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userRisgis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userRisgis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRisgis.DisabledState.Parent = this.userRisgis;
            this.userRisgis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRisgis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.userRisgis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userRisgis.FocusedState.Parent = this.userRisgis;
            this.userRisgis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userRisgis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userRisgis.HoverState.Parent = this.userRisgis;
            this.userRisgis.Location = new System.Drawing.Point(269, 89);
            this.userRisgis.Name = "userRisgis";
            this.userRisgis.PasswordChar = '\0';
            this.userRisgis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.userRisgis.PlaceholderText = "Username";
            this.userRisgis.SelectedText = "";
            this.userRisgis.ShadowDecoration.Parent = this.userRisgis;
            this.userRisgis.Size = new System.Drawing.Size(243, 36);
            this.userRisgis.TabIndex = 1;
            // 
            // passRegis
            // 
            this.passRegis.Animated = true;
            this.passRegis.BorderRadius = 8;
            this.passRegis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.passRegis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passRegis.DefaultText = "";
            this.passRegis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passRegis.DisabledState.Parent = this.passRegis;
            this.passRegis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.passRegis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passRegis.FocusedState.Parent = this.passRegis;
            this.passRegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passRegis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passRegis.HoverState.Parent = this.passRegis;
            this.passRegis.Location = new System.Drawing.Point(269, 135);
            this.passRegis.Name = "passRegis";
            this.passRegis.PasswordChar = '\0';
            this.passRegis.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passRegis.PlaceholderText = "Password";
            this.passRegis.SelectedText = "";
            this.passRegis.ShadowDecoration.Parent = this.passRegis;
            this.passRegis.Size = new System.Drawing.Size(243, 36);
            this.passRegis.TabIndex = 2;
            this.passRegis.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubmit.Location = new System.Drawing.Point(106, 212);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 20);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Clear, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clear.Location = new System.Drawing.Point(276, 455);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(33, 13);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Login.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Login.Location = new System.Drawing.Point(475, 455);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(37, 13);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // btn_Register
            // 
            this.btn_Register.Animated = true;
            this.btn_Register.AutoRoundedCorners = true;
            this.btn_Register.BorderRadius = 21;
            this.btn_Register.CheckedState.Parent = this.btn_Register;
            this.btn_Register.CustomImages.Parent = this.btn_Register;
            this.guna2Transition1.SetDecoration(this.btn_Register, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.HoverState.Parent = this.btn_Register;
            this.btn_Register.Location = new System.Drawing.Point(269, 397);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.ShadowDecoration.Parent = this.btn_Register;
            this.btn_Register.Size = new System.Drawing.Size(243, 45);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Create Account";
            this.btn_Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.Transparent;
            this.pn_login.Controls.Add(this.Label3);
            this.pn_login.Controls.Add(this.Create);
            this.pn_login.Controls.Add(this.btn_Login);
            this.pn_login.Controls.Add(this.lb_PasswordLogin);
            this.pn_login.Controls.Add(this.lb_UsernameLogin);
            this.guna2Transition1.SetDecoration(this.pn_login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_login.FillColor = System.Drawing.Color.White;
            this.pn_login.Location = new System.Drawing.Point(281, 1);
            this.pn_login.Name = "pn_login";
            this.pn_login.ShadowColor = System.Drawing.Color.White;
            this.pn_login.ShadowDepth = 80;
            this.pn_login.ShadowShift = 10;
            this.pn_login.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_login.Size = new System.Drawing.Size(549, 490);
            this.pn_login.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(215, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(129, 31);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "User Login";
            // 
            // Create
            // 
            this.Create.Animated = true;
            this.Create.AutoRoundedCorners = true;
            this.Create.BorderRadius = 21;
            this.Create.CheckedState.Parent = this.Create;
            this.Create.CustomImages.Parent = this.Create;
            this.guna2Transition1.SetDecoration(this.Create, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Create.FillColor = System.Drawing.Color.Transparent;
            this.Create.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.DimGray;
            this.Create.HoverState.Parent = this.Create;
            this.Create.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Create.Location = new System.Drawing.Point(162, 404);
            this.Create.Name = "Create";
            this.Create.ShadowDecoration.Parent = this.Create;
            this.Create.Size = new System.Drawing.Size(243, 45);
            this.Create.TabIndex = 19;
            this.Create.Text = "Create Account";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BorderRadius = 21;
            this.btn_Login.CheckedState.Parent = this.btn_Login;
            this.btn_Login.CustomImages.Parent = this.btn_Login;
            this.guna2Transition1.SetDecoration(this.btn_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.Parent = this.btn_Login;
            this.btn_Login.Location = new System.Drawing.Point(162, 336);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ShadowDecoration.Parent = this.btn_Login;
            this.btn_Login.Size = new System.Drawing.Size(243, 45);
            this.btn_Login.TabIndex = 18;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // lb_PasswordLogin
            // 
            this.lb_PasswordLogin.Animated = true;
            this.lb_PasswordLogin.AutoRoundedCorners = true;
            this.lb_PasswordLogin.BorderRadius = 17;
            this.lb_PasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.lb_PasswordLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lb_PasswordLogin.DefaultText = "";
            this.lb_PasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lb_PasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lb_PasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lb_PasswordLogin.DisabledState.Parent = this.lb_PasswordLogin;
            this.lb_PasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lb_PasswordLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lb_PasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_PasswordLogin.FocusedState.Parent = this.lb_PasswordLogin;
            this.lb_PasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lb_PasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_PasswordLogin.HoverState.Parent = this.lb_PasswordLogin;
            this.lb_PasswordLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("lb_PasswordLogin.IconLeft")));
            this.lb_PasswordLogin.Location = new System.Drawing.Point(162, 193);
            this.lb_PasswordLogin.Name = "lb_PasswordLogin";
            this.lb_PasswordLogin.PasswordChar = '\0';
            this.lb_PasswordLogin.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.lb_PasswordLogin.PlaceholderText = "Password";
            this.lb_PasswordLogin.SelectedText = "";
            this.lb_PasswordLogin.ShadowDecoration.Parent = this.lb_PasswordLogin;
            this.lb_PasswordLogin.Size = new System.Drawing.Size(243, 36);
            this.lb_PasswordLogin.TabIndex = 16;
            this.lb_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // lb_UsernameLogin
            // 
            this.lb_UsernameLogin.Animated = true;
            this.lb_UsernameLogin.AutoRoundedCorners = true;
            this.lb_UsernameLogin.BorderRadius = 17;
            this.lb_UsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.lb_UsernameLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lb_UsernameLogin.DefaultText = "";
            this.lb_UsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lb_UsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lb_UsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lb_UsernameLogin.DisabledState.Parent = this.lb_UsernameLogin;
            this.lb_UsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lb_UsernameLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lb_UsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_UsernameLogin.FocusedState.Parent = this.lb_UsernameLogin;
            this.lb_UsernameLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lb_UsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lb_UsernameLogin.HoverState.Parent = this.lb_UsernameLogin;
            this.lb_UsernameLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("lb_UsernameLogin.IconLeft")));
            this.lb_UsernameLogin.Location = new System.Drawing.Point(162, 141);
            this.lb_UsernameLogin.Name = "lb_UsernameLogin";
            this.lb_UsernameLogin.PasswordChar = '\0';
            this.lb_UsernameLogin.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.lb_UsernameLogin.PlaceholderText = "Username";
            this.lb_UsernameLogin.SelectedText = "";
            this.lb_UsernameLogin.ShadowDecoration.Parent = this.lb_UsernameLogin;
            this.lb_UsernameLogin.Size = new System.Drawing.Size(243, 36);
            this.lb_UsernameLogin.TabIndex = 17;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 487);
            this.ControlBox = false;
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.pn_regis);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.pn_regis.ResumeLayout(false);
            this.pn_regis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRegis)).EndInit();
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Guna.UI2.WinForms.Guna2ShadowPanel pn_regis;
        internal Guna.UI2.WinForms.Guna2TextBox nameRegis;
        internal Guna.UI2.WinForms.Guna2TextBox phoneRegis;
        internal System.Windows.Forms.Label Label4;
        internal Guna.UI2.WinForms.Guna2TextBox userRisgis;
        internal Guna.UI2.WinForms.Guna2TextBox passRegis;
        internal System.Windows.Forms.Label Login;
        internal Guna.UI2.WinForms.Guna2GradientButton btn_Register;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pn_login;
        internal System.Windows.Forms.Label Label3;
        internal Guna.UI2.WinForms.Guna2Button Create;
        internal Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox lb_PasswordLogin;
        private Guna.UI2.WinForms.Guna2TextBox lb_UsernameLogin;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        internal Guna.UI2.WinForms.Guna2TextBox addressRegis;
        internal Guna.UI2.WinForms.Guna2TextBox emailRegis;
        private System.Windows.Forms.PictureBox picRegis;
        private Guna.UI.WinForms.GunaCheckBox genderRegis;
        internal System.Windows.Forms.Label Clear;
        internal System.Windows.Forms.Label btnSubmit;
    }
}