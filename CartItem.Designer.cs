namespace ProjectCsharp
{
    partial class CartItem
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaNumeric = new Guna.UI.WinForms.GunaNumeric();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.gunaNumeric);
            this.guna2ShadowPanel1.Controls.Add(this.btn_Delete);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.gunaPictureBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(581, 148);
            this.guna2ShadowPanel1.TabIndex = 1;
            this.guna2ShadowPanel1.MouseEnter += new System.EventHandler(this.gunaPictureBox1_MouseEnter);
            this.guna2ShadowPanel1.MouseLeave += new System.EventHandler(this.gunaPictureBox1_MouseLeave);
            // 
            // gunaNumeric
            // 
            this.gunaNumeric.BackColor = System.Drawing.Color.Transparent;
            this.gunaNumeric.BaseColor = System.Drawing.Color.White;
            this.gunaNumeric.BorderColor = System.Drawing.Color.Silver;
            this.gunaNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNumeric.ButtonForeColor = System.Drawing.Color.White;
            this.gunaNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaNumeric.ForeColor = System.Drawing.Color.Black;
            this.gunaNumeric.Location = new System.Drawing.Point(373, 59);
            this.gunaNumeric.Maximum = ((long)(9999999));
            this.gunaNumeric.Minimum = ((long)(0));
            this.gunaNumeric.Name = "gunaNumeric";
            this.gunaNumeric.Radius = 6;
            this.gunaNumeric.Size = new System.Drawing.Size(75, 30);
            this.gunaNumeric.TabIndex = 9;
            this.gunaNumeric.Text = "gunaNumeric1";
            this.gunaNumeric.Value = ((long)(0));
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoSize = true;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.Gray;
            this.btn_Delete.Location = new System.Drawing.Point(162, 86);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(52, 19);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.Delete_Click);
            this.btn_Delete.MouseEnter += new System.EventHandler(this.btn_Delete_MouseEnter);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_Delete_MouseLeave);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(476, 59);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(59, 25);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "price";
            this.gunaLabel2.MouseEnter += new System.EventHandler(this.gunaPictureBox1_MouseEnter);
            this.gunaLabel2.MouseLeave += new System.EventHandler(this.gunaPictureBox1_MouseLeave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(161, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(134, 25);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "LaptopName";
            this.gunaLabel1.MouseEnter += new System.EventHandler(this.gunaPictureBox1_MouseEnter);
            this.gunaLabel1.MouseLeave += new System.EventHandler(this.gunaPictureBox1_MouseLeave);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(30, 22);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(115, 105);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.MouseEnter += new System.EventHandler(this.gunaPictureBox1_MouseEnter);
            this.gunaPictureBox1.MouseLeave += new System.EventHandler(this.gunaPictureBox1_MouseLeave);
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(583, 150);
            this.MouseEnter += new System.EventHandler(this.gunaPictureBox1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.gunaPictureBox1_MouseLeave);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label btn_Delete;
        private Guna.UI.WinForms.GunaNumeric gunaNumeric;
    }
}
