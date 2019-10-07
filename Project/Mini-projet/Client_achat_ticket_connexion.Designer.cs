namespace Mini_projet
{
    partial class Client_achat_ticket_connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_achat_ticket_connexion));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Connect_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.secret_code = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.Back_ = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.Connect_btn);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.secret_code);
            this.metroPanel1.Controls.Add(this.login);
            this.metroPanel1.Controls.Add(this.Back_);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 22);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(494, 469);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Connect_btn
            // 
            this.Connect_btn.BackColor = System.Drawing.Color.SaddleBrown;
            this.Connect_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Connect_btn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Connect_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Connect_btn.Location = new System.Drawing.Point(141, 303);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(227, 32);
            this.Connect_btn.Style = MetroFramework.MetroColorStyle.Black;
            this.Connect_btn.TabIndex = 25;
            this.Connect_btn.Text = "Se connecter";
            this.Connect_btn.UseCustomBackColor = true;
            this.Connect_btn.UseCustomForeColor = true;
            this.Connect_btn.UseSelectable = true;
            this.Connect_btn.UseStyleColors = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(200, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.TabIndex = 24;
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
            this.metroLabel1.Location = new System.Drawing.Point(164, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 25);
            this.metroLabel1.TabIndex = 23;
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
            this.secret_code.Location = new System.Drawing.Point(141, 259);
            this.secret_code.MaxLength = 32767;
            this.secret_code.Name = "secret_code";
            this.secret_code.PasswordChar = '●';
            this.secret_code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secret_code.SelectedText = "";
            this.secret_code.SelectionLength = 0;
            this.secret_code.SelectionStart = 0;
            this.secret_code.ShortcutsEnabled = true;
            this.secret_code.Size = new System.Drawing.Size(227, 23);
            this.secret_code.TabIndex = 22;
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
            this.login.Location = new System.Drawing.Point(141, 178);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(227, 23);
            this.login.TabIndex = 21;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // Back_
            // 
            this.Back_.ActiveControl = null;
            this.Back_.BackColor = System.Drawing.Color.Transparent;
            this.Back_.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back_.Location = new System.Drawing.Point(22, 390);
            this.Back_.Name = "Back_";
            this.Back_.Size = new System.Drawing.Size(57, 57);
            this.Back_.TabIndex = 20;
            this.Back_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Back_.TileImage = ((System.Drawing.Image)(resources.GetObject("Back_.TileImage")));
            this.Back_.UseCustomBackColor = true;
            this.Back_.UseCustomForeColor = true;
            this.Back_.UseSelectable = true;
            this.Back_.UseStyleColors = true;
            this.Back_.UseTileImage = true;
            this.Back_.Click += new System.EventHandler(this.Back__Click);
            // 
            // Client_achat_ticket_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 483);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_achat_ticket_connexion";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Client_achat_ticket_connexion_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile Back_;
        private MetroFramework.Controls.MetroButton Connect_btn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox secret_code;
        private MetroFramework.Controls.MetroTextBox login;
    }
}