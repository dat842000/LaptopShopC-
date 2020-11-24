namespace ProjectCsharp
{
    partial class frmShop
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
            this.lsvShow = new System.Windows.Forms.ListView();
            this.btn_Icon = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvShow
            // 
            this.lsvShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsvShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lsvShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.lsvShow.HideSelection = false;
            this.lsvShow.Location = new System.Drawing.Point(-33, 12);
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(476, 435);
            this.lsvShow.TabIndex = 0;
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Icon
            // 
            this.btn_Icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Icon.Location = new System.Drawing.Point(533, 68);
            this.btn_Icon.Name = "btn_Icon";
            this.btn_Icon.Size = new System.Drawing.Size(75, 23);
            this.btn_Icon.TabIndex = 1;
            this.btn_Icon.Text = "Large Icon";
            this.btn_Icon.UseVisualStyleBackColor = true;
            this.btn_Icon.Click += new System.EventHandler(this.btn_Icon_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Detail.Location = new System.Drawing.Point(533, 132);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 23);
            this.btn_Detail.TabIndex = 2;
            this.btn_Detail.Text = "Detail";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(675, 459);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Icon);
            this.Controls.Add(this.lsvShow);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvShow;
        private System.Windows.Forms.Button btn_Icon;
        private System.Windows.Forms.Button btn_Detail;
    }
}