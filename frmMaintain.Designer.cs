namespace ProjectCsharp
{
    partial class frmMaintain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scManagement = new System.Windows.Forms.SplitContainer();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProductManage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scManagement)).BeginInit();
            this.scManagement.Panel1.SuspendLayout();
            this.scManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "laptop ABC";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1250, 70);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management Site";
            // 
            // scManagement
            // 
            this.scManagement.Location = new System.Drawing.Point(12, 99);
            this.scManagement.Name = "scManagement";
            // 
            // scManagement.Panel1
            // 
            this.scManagement.Panel1.Controls.Add(this.btnOrders);
            this.scManagement.Panel1.Controls.Add(this.btnProductManage);
            this.scManagement.Size = new System.Drawing.Size(1330, 603);
            this.scManagement.SplitterDistance = 150;
            this.scManagement.TabIndex = 6;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(3, 62);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(144, 53);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Location = new System.Drawing.Point(3, 3);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(144, 53);
            this.btnProductManage.TabIndex = 0;
            this.btnProductManage.Text = "Products";
            this.btnProductManage.UseVisualStyleBackColor = true;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // frmMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 714);
            this.Controls.Add(this.scManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMaintain";
            this.Text = "frmMaintain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.scManagement.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scManagement)).EndInit();
            this.scManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer scManagement;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProductManage;
    }
}