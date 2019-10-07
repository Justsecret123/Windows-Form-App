namespace Mini_projet
{
    partial class Admin_modif_annonce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_modif_annonce));
            this.gare_annonce = new MetroFramework.Controls.MetroComboBox();
            this.gare_c = new MetroFramework.Controls.MetroTile();
            this.libelle = new System.Windows.Forms.TextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.type_annonce = new MetroFramework.Controls.MetroComboBox();
            this.type_a = new MetroFramework.Controls.MetroTile();
            this.back = new MetroFramework.Controls.MetroTile();
            this.Save = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // gare_annonce
            // 
            this.gare_annonce.FormattingEnabled = true;
            this.gare_annonce.ItemHeight = 23;
            this.gare_annonce.Location = new System.Drawing.Point(44, 223);
            this.gare_annonce.Name = "gare_annonce";
            this.gare_annonce.Size = new System.Drawing.Size(228, 29);
            this.gare_annonce.TabIndex = 10;
            this.gare_annonce.UseSelectable = true;
            this.gare_annonce.SelectedIndexChanged += new System.EventHandler(this.gare_SelectedIndexChanged);
            // 
            // gare_c
            // 
            this.gare_c.ActiveControl = null;
            this.gare_c.BackColor = System.Drawing.Color.DimGray;
            this.gare_c.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gare_c.Location = new System.Drawing.Point(44, 77);
            this.gare_c.Name = "gare_c";
            this.gare_c.Size = new System.Drawing.Size(228, 121);
            this.gare_c.TabIndex = 9;
            this.gare_c.Text = "Gare concernée";
            this.gare_c.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gare_c.TileImage = ((System.Drawing.Image)(resources.GetObject("gare_c.TileImage")));
            this.gare_c.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gare_c.UseCustomBackColor = true;
            this.gare_c.UseCustomForeColor = true;
            this.gare_c.UseSelectable = true;
            this.gare_c.UseStyleColors = true;
            this.gare_c.UseTileImage = true;
            // 
            // libelle
            // 
            this.libelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelle.Location = new System.Drawing.Point(424, 223);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(255, 29);
            this.libelle.TabIndex = 19;
            this.libelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.DimGray;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(424, 77);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(255, 121);
            this.metroTile2.TabIndex = 18;
            this.metroTile2.Text = "Libellé";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            // 
            // type_annonce
            // 
            this.type_annonce.FormattingEnabled = true;
            this.type_annonce.ItemHeight = 23;
            this.type_annonce.Items.AddRange(new object[] {
            "Voyage retardé ",
            "Voyage annulé",
            "Indisponibilté de gare",
            "Indisponibilité de train"});
            this.type_annonce.Location = new System.Drawing.Point(241, 430);
            this.type_annonce.Name = "type_annonce";
            this.type_annonce.Size = new System.Drawing.Size(228, 29);
            this.type_annonce.TabIndex = 21;
            this.type_annonce.UseSelectable = true;
            this.type_annonce.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // type_a
            // 
            this.type_a.ActiveControl = null;
            this.type_a.BackColor = System.Drawing.Color.DimGray;
            this.type_a.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.type_a.Location = new System.Drawing.Point(241, 284);
            this.type_a.Name = "type_a";
            this.type_a.Size = new System.Drawing.Size(228, 121);
            this.type_a.TabIndex = 20;
            this.type_a.Text = "Type d\'annonce";
            this.type_a.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.type_a.TileImage = ((System.Drawing.Image)(resources.GetObject("type_a.TileImage")));
            this.type_a.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.type_a.UseCustomBackColor = true;
            this.type_a.UseCustomForeColor = true;
            this.type_a.UseSelectable = true;
            this.type_a.UseStyleColors = true;
            this.type_a.UseTileImage = true;
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back.Location = new System.Drawing.Point(23, 489);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 73);
            this.back.TabIndex = 22;
            this.back.Text = "Retour";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.UseCustomBackColor = true;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseStyleColors = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Save
            // 
            this.Save.ActiveControl = null;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.Location = new System.Drawing.Point(631, 451);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 95);
            this.Save.TabIndex = 23;
            this.Save.Text = "Sauvegarder";
            this.Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Save.TileImage = ((System.Drawing.Image)(resources.GetObject("Save.TileImage")));
            this.Save.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Save.UseCustomBackColor = true;
            this.Save.UseCustomForeColor = true;
            this.Save.UseSelectable = true;
            this.Save.UseStyleColors = true;
            this.Save.UseTileImage = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Admin_modif_annonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 569);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.back);
            this.Controls.Add(this.type_annonce);
            this.Controls.Add(this.type_a);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.gare_annonce);
            this.Controls.Add(this.gare_c);
            this.Name = "Admin_modif_annonce";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Mise à jour de l\'annonce";
            this.Load += new System.EventHandler(this.Admin_modif_annonce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox gare_annonce;
        private MetroFramework.Controls.MetroTile gare_c;
        private System.Windows.Forms.TextBox libelle;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroComboBox type_annonce;
        private MetroFramework.Controls.MetroTile type_a;
        private MetroFramework.Controls.MetroTile back;
        private MetroFramework.Controls.MetroTile Save;
    }
}