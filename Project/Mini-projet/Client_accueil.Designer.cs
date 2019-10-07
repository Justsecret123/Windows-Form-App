namespace Mini_projet
{
    partial class Client_accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_accueil));
            this.Quit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Abonnement = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Achat = new MetroFramework.Controls.MetroTile();
            this.Back = new MetroFramework.Controls.MetroTile();
            this.Annonces = new MetroFramework.Controls.MetroTile();
            this.Menu = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quit.BackgroundImage")));
            this.Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quit.Location = new System.Drawing.Point(492, 27);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(46, 64);
            this.Quit.TabIndex = 11;
            this.Quit.TabStop = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.MouseEnter += new System.EventHandler(this.Quit_MouseEnter);
            this.Quit.MouseLeave += new System.EventHandler(this.Quit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 117);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(131, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 121);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Abonnement
            // 
            this.Abonnement.ActiveControl = null;
            this.Abonnement.BackColor = System.Drawing.Color.Black;
            this.Abonnement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Abonnement.Location = new System.Drawing.Point(0, 0);
            this.Abonnement.Name = "Abonnement";
            this.Abonnement.Size = new System.Drawing.Size(112, 141);
            this.Abonnement.TabIndex = 18;
            this.Abonnement.Text = "Abonnement";
            this.Abonnement.TileImage = ((System.Drawing.Image)(resources.GetObject("Abonnement.TileImage")));
            this.Abonnement.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Abonnement.UseCustomBackColor = true;
            this.Abonnement.UseCustomForeColor = true;
            this.Abonnement.UseSelectable = true;
            this.Abonnement.UseStyleColors = true;
            this.Abonnement.UseTileImage = true;
            this.Abonnement.Click += new System.EventHandler(this.Abonnement_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.Achat);
            this.metroPanel1.Controls.Add(this.Abonnement);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(112, 510);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Achat
            // 
            this.Achat.ActiveControl = null;
            this.Achat.BackColor = System.Drawing.Color.Black;
            this.Achat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Achat.Location = new System.Drawing.Point(0, 133);
            this.Achat.Name = "Achat";
            this.Achat.Size = new System.Drawing.Size(110, 158);
            this.Achat.TabIndex = 20;
            this.Achat.Text = "Achat de ticket";
            this.Achat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Achat.TileImage = ((System.Drawing.Image)(resources.GetObject("Achat.TileImage")));
            this.Achat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Achat.UseCustomBackColor = true;
            this.Achat.UseCustomForeColor = true;
            this.Achat.UseSelectable = true;
            this.Achat.UseStyleColors = true;
            this.Achat.UseTileImage = true;
            this.Achat.Click += new System.EventHandler(this.Achat_Click);
            // 
            // Back
            // 
            this.Back.ActiveControl = null;
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(2, 448);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(110, 88);
            this.Back.TabIndex = 20;
            this.Back.TileImage = ((System.Drawing.Image)(resources.GetObject("Back.TileImage")));
            this.Back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.UseCustomBackColor = true;
            this.Back.UseCustomForeColor = true;
            this.Back.UseSelectable = true;
            this.Back.UseStyleColors = true;
            this.Back.UseTileImage = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Annonces
            // 
            this.Annonces.ActiveControl = null;
            this.Annonces.BackColor = System.Drawing.Color.Black;
            this.Annonces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Annonces.Location = new System.Drawing.Point(2, 314);
            this.Annonces.Name = "Annonces";
            this.Annonces.Size = new System.Drawing.Size(110, 135);
            this.Annonces.TabIndex = 20;
            this.Annonces.Text = "Annonces ";
            this.Annonces.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Annonces.TileImage = ((System.Drawing.Image)(resources.GetObject("Annonces.TileImage")));
            this.Annonces.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Annonces.UseCustomBackColor = true;
            this.Annonces.UseCustomForeColor = true;
            this.Annonces.UseSelectable = true;
            this.Annonces.UseStyleColors = true;
            this.Annonces.UseTileImage = true;
            this.Annonces.Click += new System.EventHandler(this.Annonces_Click);
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.pictureBox2);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.Quit);
            this.Menu.HorizontalScrollbarBarColor = true;
            this.Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.Menu.HorizontalScrollbarSize = 10;
            this.Menu.Location = new System.Drawing.Point(112, 26);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(559, 510);
            this.Menu.TabIndex = 20;
            this.Menu.VerticalScrollbarBarColor = true;
            this.Menu.VerticalScrollbarHighlightOnWheel = false;
            this.Menu.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(159, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quelle action souhaitez-vous effectuer ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(245, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bonjour !";
            // 
            // Client_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(673, 537);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Annonces);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client_accueil";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Client_accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Quit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile Abonnement;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel Menu;
        private MetroFramework.Controls.MetroTile Back;
        private MetroFramework.Controls.MetroTile Annonces;
        private MetroFramework.Controls.MetroTile Achat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}