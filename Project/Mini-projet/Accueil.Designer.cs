namespace Mini_projet
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.Admin_btn = new System.Windows.Forms.PictureBox();
            this.Client_btn = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Client = new MetroFramework.Controls.MetroTile();
            this.Admin = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_btn)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_btn.BackgroundImage")));
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_btn.Location = new System.Drawing.Point(701, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(48, 69);
            this.Exit_btn.TabIndex = 5;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            this.Exit_btn.MouseEnter += new System.EventHandler(this.Exit_btn_MouseEnter);
            this.Exit_btn.MouseLeave += new System.EventHandler(this.Exit_btn_MouseLeave);
            // 
            // Admin_btn
            // 
            this.Admin_btn.BackColor = System.Drawing.Color.Transparent;
            this.Admin_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_btn.BackgroundImage")));
            this.Admin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Admin_btn.Location = new System.Drawing.Point(59, 92);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(150, 150);
            this.Admin_btn.TabIndex = 6;
            this.Admin_btn.TabStop = false;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            this.Admin_btn.MouseEnter += new System.EventHandler(this.Admin_btn_MouseEnter);
            this.Admin_btn.MouseLeave += new System.EventHandler(this.Admin_btn_MouseLeave);
            // 
            // Client_btn
            // 
            this.Client_btn.BackColor = System.Drawing.Color.Transparent;
            this.Client_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Client_btn.BackgroundImage")));
            this.Client_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Client_btn.Location = new System.Drawing.Point(572, 92);
            this.Client_btn.Name = "Client_btn";
            this.Client_btn.Size = new System.Drawing.Size(150, 150);
            this.Client_btn.TabIndex = 7;
            this.Client_btn.TabStop = false;
            this.Client_btn.Click += new System.EventHandler(this.Client_btn_Click);
            this.Client_btn.MouseEnter += new System.EventHandler(this.Client_btn_MouseEnter);
            this.Client_btn.MouseLeave += new System.EventHandler(this.Client_btn_MouseLeave_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.Client);
            this.metroPanel1.Controls.Add(this.Admin);
            this.metroPanel1.Controls.Add(this.Exit_btn);
            this.metroPanel1.Controls.Add(this.Client_btn);
            this.metroPanel1.Controls.Add(this.Admin_btn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 23);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(770, 375);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // Client
            // 
            this.Client.ActiveControl = null;
            this.Client.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Client.CausesValidation = false;
            this.Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Client.Location = new System.Drawing.Point(560, 261);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(179, 46);
            this.Client.TabIndex = 9;
            this.Client.Text = "Client";
            this.Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Client.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Client.UseCustomBackColor = true;
            this.Client.UseCustomForeColor = true;
            this.Client.UseMnemonic = false;
            this.Client.UseSelectable = true;
            this.Client.UseStyleColors = true;
            this.Client.UseTileImage = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Admin
            // 
            this.Admin.ActiveControl = null;
            this.Admin.BackColor = System.Drawing.Color.SteelBlue;
            this.Admin.CausesValidation = false;
            this.Admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin.Location = new System.Drawing.Point(46, 261);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(179, 46);
            this.Admin.TabIndex = 8;
            this.Admin.Text = "Administrateur";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Admin.UseCustomBackColor = true;
            this.Admin.UseCustomForeColor = true;
            this.Admin.UseMnemonic = false;
            this.Admin.UseSelectable = true;
            this.Admin.UseStyleColors = true;
            this.Admin.UseTileImage = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 397);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_btn)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.PictureBox Admin_btn;
        private System.Windows.Forms.PictureBox Client_btn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile Client;
        private MetroFramework.Controls.MetroTile Admin;
    }
}

