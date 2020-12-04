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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.lsvShow = new System.Windows.Forms.ListView();
            this.btn_AddToCart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // lsvShow
            // 
            this.lsvShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsvShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lsvShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.lsvShow.HideSelection = false;
            this.lsvShow.Location = new System.Drawing.Point(81, 12);
            this.lsvShow.MultiSelect = false;
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(566, 384);
            this.lsvShow.TabIndex = 0;
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            this.lsvShow.SelectedIndexChanged += new System.EventHandler(this.lsvShow_SelectedIndexChanged);
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddToCart.AnimationHoverSpeed = 0.07F;
            this.btn_AddToCart.AnimationSpeed = 0.03F;
            this.btn_AddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddToCart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btn_AddToCart.BorderColor = System.Drawing.Color.Black;
            this.btn_AddToCart.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_AddToCart.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_AddToCart.CheckedForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_AddToCart.CheckedImage")));
            this.btn_AddToCart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_AddToCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddToCart.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddToCart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btn_AddToCart.ForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddToCart.Image")));
            this.btn_AddToCart.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddToCart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_AddToCart.Location = new System.Drawing.Point(532, 405);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_AddToCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AddToCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.OnHoverImage = null;
            this.btn_AddToCart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_AddToCart.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AddToCart.Radius = 6;
            this.btn_AddToCart.Size = new System.Drawing.Size(115, 42);
            this.btn_AddToCart.TabIndex = 5;
            this.btn_AddToCart.Text = "Add To Cart";
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(727, 459);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.lsvShow);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvShow;
        private Guna.UI.WinForms.GunaAdvenceButton btn_AddToCart;
    }
}