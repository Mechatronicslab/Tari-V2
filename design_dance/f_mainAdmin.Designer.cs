﻿namespace design_dance
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.b_registrasi = new FlatButton.JFlatButton();
            this.b_exit = new System.Windows.Forms.Button();
            this.t_descMenu = new System.Windows.Forms.Label();
            this.t_menu = new System.Windows.Forms.Label();
            this.b_rekam = new FlatButton.JFlatButton();
            this.b_model = new FlatButton.JFlatButton();
            this.b_signout = new System.Windows.Forms.Button();
            this.t_copyright = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.b_signout);
            this.panelHeader.Controls.Add(this.b_exit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(673, 43);
            this.panelHeader.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 471);
            this.panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.t_copyright);
            this.panelRight.Controls.Add(this.b_model);
            this.panelRight.Controls.Add(this.b_rekam);
            this.panelRight.Controls.Add(this.t_descMenu);
            this.panelRight.Controls.Add(this.t_menu);
            this.panelRight.Controls.Add(this.b_registrasi);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(215, 43);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(458, 471);
            this.panelRight.TabIndex = 2;
            // 
            // b_registrasi
            // 
            this.b_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_registrasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_registrasi.ButtonText = "  Registrasi";
            this.b_registrasi.CausesValidation = false;
            this.b_registrasi.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("b_registrasi.ErrorImageLeft")));
            this.b_registrasi.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("b_registrasi.ErrorImageRight")));
            this.b_registrasi.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_registrasi.FocusFontColor = System.Drawing.Color.Empty;
            this.b_registrasi.ForeColors = System.Drawing.Color.White;
            this.b_registrasi.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_registrasi.HoverFontColor = System.Drawing.Color.Empty;
            this.b_registrasi.ImageLeft = ((System.Drawing.Image)(resources.GetObject("b_registrasi.ImageLeft")));
            this.b_registrasi.ImageRight = null;
            this.b_registrasi.LeftPictureColor = System.Drawing.Color.Transparent;
            this.b_registrasi.Location = new System.Drawing.Point(11, 113);
            this.b_registrasi.Name = "b_registrasi";
            this.b_registrasi.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.b_registrasi.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.b_registrasi.RightPictureColor = System.Drawing.Color.Transparent;
            this.b_registrasi.Size = new System.Drawing.Size(190, 43);
            this.b_registrasi.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.b_registrasi.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.b_registrasi.TabIndex = 0;
            this.b_registrasi.Click += new System.EventHandler(this.b_registrasi_Click);
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
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Location = new System.Drawing.Point(619, 9);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(52, 23);
            this.b_exit.TabIndex = 6;
            this.b_exit.Text = "X";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // t_descMenu
            // 
            this.t_descMenu.AutoSize = true;
            this.t_descMenu.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_descMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_descMenu.Location = new System.Drawing.Point(8, 32);
            this.t_descMenu.Name = "t_descMenu";
            this.t_descMenu.Size = new System.Drawing.Size(261, 15);
            this.t_descMenu.TabIndex = 3;
            this.t_descMenu.Text = "Silahkan pilih layanan yang ingin anda gunakan!";
            // 
            // t_menu
            // 
            this.t_menu.AutoSize = true;
            this.t_menu.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_menu.Location = new System.Drawing.Point(6, 3);
            this.t_menu.Name = "t_menu";
            this.t_menu.Size = new System.Drawing.Size(124, 25);
            this.t_menu.TabIndex = 2;
            this.t_menu.Text = "Main Menu";
            // 
            // b_rekam
            // 
            this.b_rekam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_rekam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_rekam.ButtonText = "Rekam";
            this.b_rekam.CausesValidation = false;
            this.b_rekam.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("b_rekam.ErrorImageLeft")));
            this.b_rekam.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("b_rekam.ErrorImageRight")));
            this.b_rekam.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_rekam.FocusFontColor = System.Drawing.Color.Empty;
            this.b_rekam.ForeColors = System.Drawing.Color.White;
            this.b_rekam.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_rekam.HoverFontColor = System.Drawing.Color.Empty;
            this.b_rekam.ImageLeft = ((System.Drawing.Image)(resources.GetObject("b_rekam.ImageLeft")));
            this.b_rekam.ImageRight = null;
            this.b_rekam.LeftPictureColor = System.Drawing.Color.Transparent;
            this.b_rekam.Location = new System.Drawing.Point(218, 113);
            this.b_rekam.Name = "b_rekam";
            this.b_rekam.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.b_rekam.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.b_rekam.RightPictureColor = System.Drawing.Color.Transparent;
            this.b_rekam.Size = new System.Drawing.Size(190, 43);
            this.b_rekam.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.b_rekam.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.b_rekam.TabIndex = 4;
            // 
            // b_model
            // 
            this.b_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_model.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.b_model.ButtonText = "Model Tari";
            this.b_model.CausesValidation = false;
            this.b_model.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("b_model.ErrorImageLeft")));
            this.b_model.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("b_model.ErrorImageRight")));
            this.b_model.FocusBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_model.FocusFontColor = System.Drawing.Color.Empty;
            this.b_model.ForeColors = System.Drawing.Color.White;
            this.b_model.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.b_model.HoverFontColor = System.Drawing.Color.Empty;
            this.b_model.ImageLeft = ((System.Drawing.Image)(resources.GetObject("b_model.ImageLeft")));
            this.b_model.ImageRight = null;
            this.b_model.LeftPictureColor = System.Drawing.Color.Transparent;
            this.b_model.Location = new System.Drawing.Point(11, 180);
            this.b_model.Name = "b_model";
            this.b_model.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.b_model.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.b_model.RightPictureColor = System.Drawing.Color.Transparent;
            this.b_model.Size = new System.Drawing.Size(190, 43);
            this.b_model.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.b_model.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.b_model.TabIndex = 5;
            // 
            // b_signout
            // 
            this.b_signout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_signout.BackColor = System.Drawing.Color.Transparent;
            this.b_signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_signout.FlatAppearance.BorderSize = 0;
            this.b_signout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_signout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_signout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_signout.Location = new System.Drawing.Point(561, 9);
            this.b_signout.Name = "b_signout";
            this.b_signout.Size = new System.Drawing.Size(52, 23);
            this.b_signout.TabIndex = 7;
            this.b_signout.Text = "Signout";
            this.b_signout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_signout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_signout.UseVisualStyleBackColor = false;
            // 
            // t_copyright
            // 
            this.t_copyright.AutoSize = true;
            this.t_copyright.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(155)))));
            this.t_copyright.Location = new System.Drawing.Point(354, 447);
            this.t_copyright.Name = "t_copyright";
            this.t_copyright.Size = new System.Drawing.Size(92, 15);
            this.t_copyright.TabIndex = 16;
            this.t_copyright.Text = "Copyright 2019";
            // 
            // f_mainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 514);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_mainAdmin";
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private FlatButton.JFlatButton b_registrasi;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label t_descMenu;
        private System.Windows.Forms.Label t_menu;
        private FlatButton.JFlatButton b_rekam;
        private FlatButton.JFlatButton b_model;
        private System.Windows.Forms.Button b_signout;
        private System.Windows.Forms.Label t_copyright;
    }
}