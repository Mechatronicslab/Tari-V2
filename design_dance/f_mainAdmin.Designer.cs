namespace design_dance
{
    partial class f_mainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_mainAdmin));
            this.h_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_registrasi = new FlatButton.JFlatButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // h_panel
            // 
            this.h_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.h_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.h_panel.Location = new System.Drawing.Point(0, 0);
            this.h_panel.Name = "h_panel";
            this.h_panel.Size = new System.Drawing.Size(673, 43);
            this.h_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 471);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_registrasi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 471);
            this.panel2.TabIndex = 2;
            // 
            // b_registrasi
            // 
            this.b_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.b_registrasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.b_registrasi.ButtonText = "Registrasi";
            this.b_registrasi.CausesValidation = false;
            this.b_registrasi.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("b_registrasi.ErrorImageLeft")));
            this.b_registrasi.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("b_registrasi.ErrorImageRight")));
            this.b_registrasi.FocusBackground = System.Drawing.Color.Empty;
            this.b_registrasi.FocusFontColor = System.Drawing.Color.Empty;
            this.b_registrasi.ForeColors = System.Drawing.Color.White;
            this.b_registrasi.HoverBackground = System.Drawing.Color.Empty;
            this.b_registrasi.HoverFontColor = System.Drawing.Color.Empty;
            this.b_registrasi.ImageLeft = null;
            this.b_registrasi.ImageRight = null;
            this.b_registrasi.LeftPictureColor = System.Drawing.Color.Transparent;
            this.b_registrasi.Location = new System.Drawing.Point(6, 128);
            this.b_registrasi.Name = "b_registrasi";
            this.b_registrasi.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.b_registrasi.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.b_registrasi.RightPictureColor = System.Drawing.Color.Transparent;
            this.b_registrasi.Size = new System.Drawing.Size(171, 43);
            this.b_registrasi.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.b_registrasi.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.b_registrasi.TabIndex = 0;
            // 
            // f_mainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.h_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_mainAdmin";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel h_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FlatButton.JFlatButton b_registrasi;
    }
}