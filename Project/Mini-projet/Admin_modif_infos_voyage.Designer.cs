namespace Mini_projet
{
    partial class Admin_modif_infos_voyage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_modif_infos_voyage));
            this.Save = new MetroFramework.Controls.MetroTile();
            this.back = new MetroFramework.Controls.MetroTile();
            this.duree = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.train = new MetroFramework.Controls.MetroComboBox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.ActiveControl = null;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.Location = new System.Drawing.Point(651, 476);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 95);
            this.Save.TabIndex = 11;
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
            // back
            // 
            this.back.ActiveControl = null;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back.Location = new System.Drawing.Point(9, 489);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 73);
            this.back.TabIndex = 12;
            this.back.Text = "Retour";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.UseCustomBackColor = true;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseStyleColors = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // duree
            // 
            this.duree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duree.Location = new System.Drawing.Point(45, 404);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(235, 29);
            this.duree.TabIndex = 20;
            this.duree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prix
            // 
            this.prix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(433, 404);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(235, 29);
            this.prix.TabIndex = 19;
            this.prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(433, 233);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(235, 29);
            this.date.TabIndex = 18;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // train
            // 
            this.train.FormattingEnabled = true;
            this.train.ItemHeight = 23;
            this.train.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.train.Location = new System.Drawing.Point(45, 233);
            this.train.Name = "train";
            this.train.PromptText = "Sélectionner un train....";
            this.train.Size = new System.Drawing.Size(233, 29);
            this.train.TabIndex = 17;
            this.train.UseCustomBackColor = true;
            this.train.UseCustomForeColor = true;
            this.train.UseSelectable = true;
            this.train.UseStyleColors = true;
            this.train.SelectedIndexChanged += new System.EventHandler(this.train_SelectedIndexChanged);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.DimGray;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile4.Location = new System.Drawing.Point(433, 283);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(235, 108);
            this.metroTile4.TabIndex = 16;
            this.metroTile4.Text = "Prix";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.DimGray;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile3.Location = new System.Drawing.Point(45, 283);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(235, 108);
            this.metroTile3.TabIndex = 15;
            this.metroTile3.Text = "Durée du voyage";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.DimGray;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(433, 106);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(235, 116);
            this.metroTile2.TabIndex = 14;
            this.metroTile2.Text = "Date et heure de départ";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DimGray;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile1.Location = new System.Drawing.Point(45, 106);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(235, 116);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Numéro de train";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            // 
            // Admin_modif_infos_voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 569);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.date);
            this.Controls.Add(this.train);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Save);
            this.Name = "Admin_modif_infos_voyage";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Mise à jour du voyage ";
            this.Load += new System.EventHandler(this.Admin_modif_infos_voyage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Save;
        private MetroFramework.Controls.MetroTile back;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox date;
        private MetroFramework.Controls.MetroComboBox train;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}