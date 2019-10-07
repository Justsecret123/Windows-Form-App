namespace Mini_projet
{
    partial class Admin_connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_connexion));
            this.login_txt = new MetroFramework.Controls.MetroTextBox();
            this.passwd_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Exit = new MetroFramework.Controls.MetroTile();
            this.Client = new MetroFramework.Controls.MetroTile();
            this.Home = new MetroFramework.Controls.MetroTile();
            this.Connect_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // login_txt
            // 
            // 
            // 
            // 
            this.login_txt.CustomButton.Image = null;
            this.login_txt.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.login_txt.CustomButton.Name = "";
            this.login_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_txt.CustomButton.TabIndex = 1;
            this.login_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_txt.CustomButton.UseSelectable = true;
            this.login_txt.CustomButton.Visible = false;
            this.login_txt.Lines = new string[0];
            this.login_txt.Location = new System.Drawing.Point(199, 165);
            this.login_txt.MaxLength = 32767;
            this.login_txt.Name = "login_txt";
            this.login_txt.PasswordChar = '\0';
            this.login_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_txt.SelectedText = "";
            this.login_txt.SelectionLength = 0;
            this.login_txt.SelectionStart = 0;
            this.login_txt.ShortcutsEnabled = true;
            this.login_txt.Size = new System.Drawing.Size(227, 23);
            this.login_txt.TabIndex = 0;
            this.login_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_txt.UseSelectable = true;
            this.login_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_txt_KeyDown);
            // 
            // passwd_txt
            // 
            // 
            // 
            // 
            this.passwd_txt.CustomButton.Image = null;
            this.passwd_txt.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.passwd_txt.CustomButton.Name = "";
            this.passwd_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwd_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwd_txt.CustomButton.TabIndex = 1;
            this.passwd_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwd_txt.CustomButton.UseSelectable = true;
            this.passwd_txt.CustomButton.Visible = false;
            this.passwd_txt.Lines = new string[0];
            this.passwd_txt.Location = new System.Drawing.Point(199, 235);
            this.passwd_txt.MaxLength = 32767;
            this.passwd_txt.Name = "passwd_txt";
            this.passwd_txt.PasswordChar = '●';
            this.passwd_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwd_txt.SelectedText = "";
            this.passwd_txt.SelectionLength = 0;
            this.passwd_txt.SelectionStart = 0;
            this.passwd_txt.ShortcutsEnabled = true;
            this.passwd_txt.Size = new System.Drawing.Size(227, 23);
            this.passwd_txt.TabIndex = 1;
            this.passwd_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwd_txt.UseSelectable = true;
            this.passwd_txt.UseSystemPasswordChar = true;
            this.passwd_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwd_txt.WaterMarkFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_txt_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(236, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Identifiant ou login";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(250, 207);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Mot de passe";
            // 
            // Exit
            // 
            this.Exit.ActiveControl = null;
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(521, 31);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 91);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Quitter";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Exit.TileImage = ((System.Drawing.Image)(resources.GetObject("Exit.TileImage")));
            this.Exit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseCustomForeColor = true;
            this.Exit.UseSelectable = true;
            this.Exit.UseStyleColors = true;
            this.Exit.UseTileImage = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Client
            // 
            this.Client.ActiveControl = null;
            this.Client.BackColor = System.Drawing.Color.Gray;
            this.Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Client.Location = new System.Drawing.Point(308, 428);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(296, 67);
            this.Client.TabIndex = 6;
            this.Client.Text = "Client";
            this.Client.TileImage = ((System.Drawing.Image)(resources.GetObject("Client.TileImage")));
            this.Client.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Client.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Client.UseCustomBackColor = true;
            this.Client.UseCustomForeColor = true;
            this.Client.UseSelectable = true;
            this.Client.UseStyleColors = true;
            this.Client.UseTileImage = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Home
            // 
            this.Home.ActiveControl = null;
            this.Home.BackColor = System.Drawing.Color.DimGray;
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Location = new System.Drawing.Point(1, 428);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(311, 67);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Home.TileImage = ((System.Drawing.Image)(resources.GetObject("Home.TileImage")));
            this.Home.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Home.UseCustomBackColor = true;
            this.Home.UseCustomForeColor = true;
            this.Home.UseSelectable = true;
            this.Home.UseStyleColors = true;
            this.Home.UseTileImage = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Connect_btn
            // 
            this.Connect_btn.BackColor = System.Drawing.Color.Gray;
            this.Connect_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Connect_btn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Connect_btn.Location = new System.Drawing.Point(199, 290);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(227, 32);
            this.Connect_btn.Style = MetroFramework.MetroColorStyle.Black;
            this.Connect_btn.TabIndex = 8;
            this.Connect_btn.Text = "Se connecter";
            this.Connect_btn.UseCustomBackColor = true;
            this.Connect_btn.UseCustomForeColor = true;
            this.Connect_btn.UseSelectable = true;
            this.Connect_btn.UseStyleColors = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Admin_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 494);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passwd_txt);
            this.Controls.Add(this.login_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_connexion";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox login_txt;
        private MetroFramework.Controls.MetroTextBox passwd_txt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile Exit;
        private MetroFramework.Controls.MetroTile Client;
        private MetroFramework.Controls.MetroTile Home;
        private MetroFramework.Controls.MetroButton Connect_btn;
    }
}