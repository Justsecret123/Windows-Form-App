namespace Mini_projet
{
    partial class Client_connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_connexion));
            this.Connect_btn = new MetroFramework.Controls.MetroButton();
            this.Home = new MetroFramework.Controls.MetroTile();
            this.Admin_btn = new MetroFramework.Controls.MetroTile();
            this.Exit = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.secret_code = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.Forward = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Connect_btn
            // 
            this.Connect_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Connect_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Connect_btn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Connect_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Connect_btn.Location = new System.Drawing.Point(198, 270);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(227, 32);
            this.Connect_btn.Style = MetroFramework.MetroColorStyle.Black;
            this.Connect_btn.TabIndex = 16;
            this.Connect_btn.Text = "Se connecter";
            this.Connect_btn.UseCustomBackColor = true;
            this.Connect_btn.UseCustomForeColor = true;
            this.Connect_btn.UseSelectable = true;
            this.Connect_btn.UseStyleColors = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Home
            // 
            this.Home.ActiveControl = null;
            this.Home.BackColor = System.Drawing.Color.SaddleBrown;
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Location = new System.Drawing.Point(0, 408);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(311, 75);
            this.Home.TabIndex = 15;
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
            // Admin_btn
            // 
            this.Admin_btn.ActiveControl = null;
            this.Admin_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Admin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin_btn.Location = new System.Drawing.Point(307, 408);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(296, 75);
            this.Admin_btn.TabIndex = 14;
            this.Admin_btn.Text = "Administrateur";
            this.Admin_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("Admin_btn.TileImage")));
            this.Admin_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Admin_btn.UseCustomBackColor = true;
            this.Admin_btn.UseCustomForeColor = true;
            this.Admin_btn.UseSelectable = true;
            this.Admin_btn.UseStyleColors = true;
            this.Admin_btn.UseTileImage = true;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Exit
            // 
            this.Exit.ActiveControl = null;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(520, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 91);
            this.Exit.TabIndex = 13;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(257, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Code secret";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(221, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Numéro de téléphone";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // secret_code
            // 
            // 
            // 
            // 
            this.secret_code.CustomButton.Image = null;
            this.secret_code.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.secret_code.CustomButton.Name = "";
            this.secret_code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.secret_code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secret_code.CustomButton.TabIndex = 1;
            this.secret_code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secret_code.CustomButton.UseSelectable = true;
            this.secret_code.CustomButton.Visible = false;
            this.secret_code.Lines = new string[0];
            this.secret_code.Location = new System.Drawing.Point(198, 226);
            this.secret_code.MaxLength = 32767;
            this.secret_code.Name = "secret_code";
            this.secret_code.PasswordChar = '●';
            this.secret_code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secret_code.SelectedText = "";
            this.secret_code.SelectionLength = 0;
            this.secret_code.SelectionStart = 0;
            this.secret_code.ShortcutsEnabled = true;
            this.secret_code.Size = new System.Drawing.Size(227, 23);
            this.secret_code.TabIndex = 10;
            this.secret_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secret_code.UseSelectable = true;
            this.secret_code.UseSystemPasswordChar = true;
            this.secret_code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secret_code.WaterMarkFont = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secret_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.secret_code_KeyDown);
            // 
            // login
            // 
            // 
            // 
            // 
            this.login.CustomButton.Image = null;
            this.login.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(198, 145);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(227, 23);
            this.login.TabIndex = 9;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // Forward
            // 
            this.Forward.ActiveControl = null;
            this.Forward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Forward.Location = new System.Drawing.Point(422, 321);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(181, 81);
            this.Forward.TabIndex = 17;
            this.Forward.Text = "Continuer sans se connecter";
            this.Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Forward.TileImage = ((System.Drawing.Image)(resources.GetObject("Forward.TileImage")));
            this.Forward.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Forward.UseCustomBackColor = true;
            this.Forward.UseCustomForeColor = true;
            this.Forward.UseSelectable = true;
            this.Forward.UseStyleColors = true;
            this.Forward.UseTileImage = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Client_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 485);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.secret_code);
            this.Controls.Add(this.login);
            this.Name = "Client_connexion";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Connexion";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Client_connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Connect_btn;
        private MetroFramework.Controls.MetroTile Home;
        private MetroFramework.Controls.MetroTile Admin_btn;
        private MetroFramework.Controls.MetroTile Exit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox secret_code;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroTile Forward;
    }
}