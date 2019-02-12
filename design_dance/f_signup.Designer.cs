﻿namespace design_dance
{
    partial class f_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_signup));
            this.panel2 = new System.Windows.Forms.Panel();
            this.t_copyright = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.t_descSignin = new System.Windows.Forms.Label();
            this.t_signup = new System.Windows.Forms.Label();
            this.b_signup = new FlatButton.JFlatButton();
            this.mUsername = new JMaterialTextbox.JMaterialTextbox();
            this.mPassword = new JMaterialTextbox.JMaterialTextbox();
            this.t_password = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_sigehPengunten = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.t_copyright);
            this.panel2.Controls.Add(this.b_exit);
            this.panel2.Controls.Add(this.t_descSignin);
            this.panel2.Controls.Add(this.t_signup);
            this.panel2.Controls.Add(this.b_signup);
            this.panel2.Controls.Add(this.mUsername);
            this.panel2.Controls.Add(this.mPassword);
            this.panel2.Controls.Add(this.t_password);
            this.panel2.Controls.Add(this.t_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(355, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 514);
            this.panel2.TabIndex = 0;
            // 
            // t_copyright
            // 
            this.t_copyright.AutoSize = true;
            this.t_copyright.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_copyright.Location = new System.Drawing.Point(214, 490);
            this.t_copyright.Name = "t_copyright";
            this.t_copyright.Size = new System.Drawing.Size(92, 15);
            this.t_copyright.TabIndex = 15;
            this.t_copyright.Text = "Copyright 2019";
            // 
            // b_exit
            // 
            this.b_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_exit.BackColor = System.Drawing.Color.Transparent;
            this.b_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_exit.FlatAppearance.BorderSize = 0;
            this.b_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_exit.Location = new System.Drawing.Point(261, 7);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(52, 23);
            this.b_exit.TabIndex = 14;
            this.b_exit.Text = "X";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // t_descSignin
            // 
            this.t_descSignin.AutoSize = true;
            this.t_descSignin.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_descSignin.Location = new System.Drawing.Point(9, 52);
            this.t_descSignin.Name = "t_descSignin";
            this.t_descSignin.Size = new System.Drawing.Size(182, 15);
            this.t_descSignin.TabIndex = 13;
            this.t_descSignin.Text = "Silahkan masukan data diri anda!";
            // 
            // t_signup
            // 
            this.t_signup.AutoSize = true;
            this.t_signup.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_signup.Location = new System.Drawing.Point(6, 23);
            this.t_signup.Name = "t_signup";
            this.t_signup.Size = new System.Drawing.Size(90, 25);
            this.t_signup.TabIndex = 12;
            this.t_signup.Text = "Sign Up";
            // 
            // b_signup
            // 
            this.b_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_signup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_signup.ButtonText = "     Sign Up";
            this.b_signup.CausesValidation = false;
            this.b_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_signup.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("b_signup.ErrorImageLeft")));
            this.b_signup.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("b_signup.ErrorImageRight")));
            this.b_signup.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_signup.FocusFontColor = System.Drawing.Color.White;
            this.b_signup.ForeColors = System.Drawing.Color.White;
            this.b_signup.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_signup.HoverFontColor = System.Drawing.Color.White;
            this.b_signup.ImageLeft = ((System.Drawing.Image)(resources.GetObject("b_signup.ImageLeft")));
            this.b_signup.ImageRight = null;
            this.b_signup.LeftPictureColor = System.Drawing.Color.Transparent;
            this.b_signup.Location = new System.Drawing.Point(11, 324);
            this.b_signup.Margin = new System.Windows.Forms.Padding(4);
            this.b_signup.Name = "b_signup";
            this.b_signup.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.b_signup.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.b_signup.RightPictureColor = System.Drawing.Color.Transparent;
            this.b_signup.Size = new System.Drawing.Size(291, 30);
            this.b_signup.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.b_signup.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.b_signup.TabIndex = 11;
            // 
            // mUsername
            // 
            this.mUsername.BackColor = System.Drawing.Color.Transparent;
            this.mUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUsername.Font_Size = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUsername.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mUsername.HintText = "Username";
            this.mUsername.IsPassword = false;
            this.mUsername.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mUsername.LineThickness = 1;
            this.mUsername.Location = new System.Drawing.Point(11, 171);
            this.mUsername.Margin = new System.Windows.Forms.Padding(0);
            this.mUsername.MaxLength = 32767;
            this.mUsername.Name = "mUsername";
            this.mUsername.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mUsername.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mUsername.ReadOnly = false;
            this.mUsername.Size = new System.Drawing.Size(291, 28);
            this.mUsername.TabIndex = 10;
            this.mUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mUsername.TextName = "";
            // 
            // mPassword
            // 
            this.mPassword.BackColor = System.Drawing.Color.Transparent;
            this.mPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPassword.Font_Size = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPassword.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mPassword.HintText = "Password";
            this.mPassword.IsPassword = true;
            this.mPassword.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mPassword.LineThickness = 1;
            this.mPassword.Location = new System.Drawing.Point(11, 254);
            this.mPassword.Margin = new System.Windows.Forms.Padding(0);
            this.mPassword.MaxLength = 32767;
            this.mPassword.Name = "mPassword";
            this.mPassword.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mPassword.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.mPassword.ReadOnly = false;
            this.mPassword.Size = new System.Drawing.Size(291, 28);
            this.mPassword.TabIndex = 9;
            this.mPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mPassword.TextName = "";
            // 
            // t_password
            // 
            this.t_password.AutoSize = true;
            this.t_password.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_password.Location = new System.Drawing.Point(9, 224);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(67, 16);
            this.t_password.TabIndex = 8;
            this.t_password.Text = "Password";
            // 
            // t_username
            // 
            this.t_username.AutoSize = true;
            this.t_username.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_username.Location = new System.Drawing.Point(11, 146);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(70, 16);
            this.t_username.TabIndex = 3;
            this.t_username.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.t_sigehPengunten);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 514);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // t_sigehPengunten
            // 
            this.t_sigehPengunten.AutoSize = true;
            this.t_sigehPengunten.BackColor = System.Drawing.Color.Transparent;
            this.t_sigehPengunten.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_sigehPengunten.ForeColor = System.Drawing.Color.White;
            this.t_sigehPengunten.Location = new System.Drawing.Point(50, 298);
            this.t_sigehPengunten.Name = "t_sigehPengunten";
            this.t_sigehPengunten.Size = new System.Drawing.Size(275, 41);
            this.t_sigehPengunten.TabIndex = 2;
            this.t_sigehPengunten.Text = "Sigeh Pengunten";
            // 
            // f_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_signup";
            this.Text = "f_signup";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label t_username;
        private System.Windows.Forms.Label t_password;
        private JMaterialTextbox.JMaterialTextbox mPassword;
        private JMaterialTextbox.JMaterialTextbox mUsername;
        private FlatButton.JFlatButton b_signup;
        private System.Windows.Forms.Label t_sigehPengunten;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label t_descSignin;
        private System.Windows.Forms.Label t_signup;
        private System.Windows.Forms.Label t_copyright;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}