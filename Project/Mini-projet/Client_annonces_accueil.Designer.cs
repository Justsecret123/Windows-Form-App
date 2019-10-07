namespace Mini_projet
{
    partial class Client_annonces_accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_annonces_accueil));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Liste = new System.Windows.Forms.ListBox();
            this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Valider = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Annonce_cb = new MetroFramework.Controls.MetroComboBox();
            this.Gare = new MetroFramework.Controls.MetroComboBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.Gare_mt = new MetroFramework.Controls.MetroTile();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Spinner_ = new MetroFramework.Controls.MetroProgressSpinner();
            this.refresh = new MetroFramework.Controls.MetroTile();
            this.Back_ = new System.Windows.Forms.PictureBox();
            this.Liste_ = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(300, 37);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 25);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(662, 501);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.Back);
            this.tabPage4.Controls.Add(this.Liste);
            this.tabPage4.Controls.Add(this.Spinner);
            this.tabPage4.Controls.Add(this.Valider);
            this.tabPage4.Controls.Add(this.metroTile1);
            this.tabPage4.Controls.Add(this.Annonce_cb);
            this.tabPage4.Controls.Add(this.Gare);
            this.tabPage4.Controls.Add(this.metroTile2);
            this.tabPage4.Controls.Add(this.Gare_mt);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(654, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rechercher par mot-clé";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(20, 390);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(58, 57);
            this.Back.TabIndex = 11;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // Liste
            // 
            this.Liste.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Liste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 17;
            this.Liste.Location = new System.Drawing.Point(98, 310);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(519, 106);
            this.Liste.TabIndex = 10;
            this.Liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Spinner
            // 
            this.Spinner.Location = new System.Drawing.Point(10, 350);
            this.Spinner.Maximum = 800;
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(68, 63);
            this.Spinner.TabIndex = 9;
            this.Spinner.UseCustomBackColor = true;
            this.Spinner.UseCustomForeColor = true;
            this.Spinner.UseSelectable = true;
            this.Spinner.UseStyleColors = true;
            this.Spinner.Visible = false;
            this.Spinner.Click += new System.EventHandler(this.Spinner_Click);
            // 
            // Valider
            // 
            this.Valider.ActiveControl = null;
            this.Valider.Location = new System.Drawing.Point(245, 255);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(176, 36);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Valider";
            this.Valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Valider.UseSelectable = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(243, 500);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(89, 43);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // Annonce_cb
            // 
            this.Annonce_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Annonce_cb.FormattingEnabled = true;
            this.Annonce_cb.ItemHeight = 23;
            this.Annonce_cb.Items.AddRange(new object[] {
            "Voyage retardé ",
            "Voyage annulé",
            "Indisponibilité de gare",
            "Indisponibilité de train",
            "Tout type d\'annonce..."});
            this.Annonce_cb.Location = new System.Drawing.Point(425, 200);
            this.Annonce_cb.Name = "Annonce_cb";
            this.Annonce_cb.PromptText = "Type d\'annonce....";
            this.Annonce_cb.Size = new System.Drawing.Size(214, 29);
            this.Annonce_cb.TabIndex = 4;
            this.Annonce_cb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Annonce_cb.UseSelectable = true;
            this.Annonce_cb.SelectedIndexChanged += new System.EventHandler(this.Annonce_cb_SelectedIndexChanged);
            // 
            // Gare
            // 
            this.Gare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gare.FormattingEnabled = true;
            this.Gare.ItemHeight = 23;
            this.Gare.Location = new System.Drawing.Point(23, 200);
            this.Gare.Name = "Gare";
            this.Gare.PromptText = "Sélectionner une gare....";
            this.Gare.Size = new System.Drawing.Size(214, 29);
            this.Gare.TabIndex = 3;
            this.Gare.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Gare.UseSelectable = true;
            this.Gare.SelectedIndexChanged += new System.EventHandler(this.Gare_SelectedIndexChanged);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(425, 51);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(214, 118);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Sélectionner le type d\'annonce";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            // 
            // Gare_mt
            // 
            this.Gare_mt.ActiveControl = null;
            this.Gare_mt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Gare_mt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gare_mt.Location = new System.Drawing.Point(23, 51);
            this.Gare_mt.Name = "Gare_mt";
            this.Gare_mt.Size = new System.Drawing.Size(214, 118);
            this.Gare_mt.TabIndex = 0;
            this.Gare_mt.Text = "Sélectionner une gare";
            this.Gare_mt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gare_mt.TileImage = ((System.Drawing.Image)(resources.GetObject("Gare_mt.TileImage")));
            this.Gare_mt.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gare_mt.UseCustomBackColor = true;
            this.Gare_mt.UseCustomForeColor = true;
            this.Gare_mt.UseSelectable = true;
            this.Gare_mt.UseTileImage = true;
            this.Gare_mt.Click += new System.EventHandler(this.Gare_mt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Controls.Add(this.Spinner_);
            this.tabPage3.Controls.Add(this.refresh);
            this.tabPage3.Controls.Add(this.Back_);
            this.tabPage3.Controls.Add(this.Liste_);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(654, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gares indisponibles";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Spinner_
            // 
            this.Spinner_.Location = new System.Drawing.Point(10, 350);
            this.Spinner_.Maximum = 800;
            this.Spinner_.Name = "Spinner_";
            this.Spinner_.Size = new System.Drawing.Size(68, 63);
            this.Spinner_.TabIndex = 14;
            this.Spinner_.UseCustomBackColor = true;
            this.Spinner_.UseCustomForeColor = true;
            this.Spinner_.UseSelectable = true;
            this.Spinner_.UseStyleColors = true;
            this.Spinner_.Visible = false;
            // 
            // refresh
            // 
            this.refresh.ActiveControl = null;
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.Location = new System.Drawing.Point(251, 275);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(187, 41);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Actualiser";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refresh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.refresh.UseCustomBackColor = true;
            this.refresh.UseCustomForeColor = true;
            this.refresh.UseSelectable = true;
            this.refresh.UseStyleColors = true;
            this.refresh.UseTileImage = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Back_
            // 
            this.Back_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_.BackgroundImage")));
            this.Back_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_.Location = new System.Drawing.Point(20, 390);
            this.Back_.Name = "Back_";
            this.Back_.Size = new System.Drawing.Size(58, 57);
            this.Back_.TabIndex = 12;
            this.Back_.TabStop = false;
            this.Back_.Click += new System.EventHandler(this.Back__Click);
            this.Back_.MouseEnter += new System.EventHandler(this.Back__MouseEnter);
            this.Back_.MouseLeave += new System.EventHandler(this.Back__MouseLeave);
            // 
            // Liste_
            // 
            this.Liste_.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Liste_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Liste_.FormattingEnabled = true;
            this.Liste_.ItemHeight = 17;
            this.Liste_.Location = new System.Drawing.Point(35, 39);
            this.Liste_.Name = "Liste_";
            this.Liste_.Size = new System.Drawing.Size(594, 208);
            this.Liste_.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.metroLabel4);
            this.tabPage1.Controls.Add(this.metroPanel2);
            this.tabPage1.Controls.Add(this.metroPanel1);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.metroLabel3);
            this.tabPage1.Controls.Add(this.metroLabel2);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(654, 456);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Rubrique d\'aide";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(200, 300);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(233, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Ensuite, cliquez sur le bouton \"valider\".";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(46, 350);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(605, 38);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Il est possible que l\'annonce que vous recherchez ne soit plus d\'actualité. Dans " +
    "ce cas, elle n\'apparaîtra \r\nplus dans l\'application.";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(349, 77);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(257, 209);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(48, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(261, 209);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(450, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(192, 25);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.oncf.ma/";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel3.Location = new System.Drawing.Point(1, 400);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(651, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Pour plus d\'informations, veuillez vous rendre sur notre site web via le lien ci-" +
    "après : ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(33, 325);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(376, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "2.Pourquoi une annonce ne s\'affiche-t-elle pas ?";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(33, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(276, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "1.Comment afficher une annonce ?";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // Client_annonces_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 537);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Client_annonces_accueil";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Annonces_accueil_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back_)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroComboBox Gare;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile Gare_mt;
        private MetroFramework.Controls.MetroComboBox Annonce_cb;
        private MetroFramework.Controls.MetroTile Valider;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroProgressSpinner Spinner;
        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.ListBox Liste_;
        private System.Windows.Forms.PictureBox Back_;
        private MetroFramework.Controls.MetroTile refresh;
        private MetroFramework.Controls.MetroProgressSpinner Spinner_;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}