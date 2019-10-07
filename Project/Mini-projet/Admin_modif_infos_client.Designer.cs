namespace Mini_projet
{
    partial class Admin_modif_infos_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_modif_infos_client));
            this.back = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.formule_abo = new MetroFramework.Controls.MetroComboBox();
            this.nom_client = new System.Windows.Forms.TextBox();
            this.code_client = new System.Windows.Forms.TextBox();
            this.tel_client = new System.Windows.Forms.TextBox();
            this.Save = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back.Location = new System.Drawing.Point(22, 484);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 73);
            this.back.TabIndex = 1;
            this.back.Text = "Retour";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.UseCustomBackColor = true;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseStyleColors = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DimGray;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile1.Location = new System.Drawing.Point(39, 77);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(235, 123);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Formule d\'abonnement";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.DimGray;
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile2.Location = new System.Drawing.Point(427, 77);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(235, 123);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Nom du client ";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.DimGray;
            this.metroTile3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile3.Location = new System.Drawing.Point(39, 277);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(235, 120);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Numéro de téléphone";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.DimGray;
            this.metroTile4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile4.Location = new System.Drawing.Point(427, 277);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(235, 120);
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Code secret";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.UseTileImage = true;
            // 
            // formule_abo
            // 
            this.formule_abo.FormattingEnabled = true;
            this.formule_abo.ItemHeight = 23;
            this.formule_abo.Items.AddRange(new object[] {
            "Formule \"enfants\"",
            "Formule \"ados\"",
            "Formule \"adultes\"",
            "Formule \"personnes âgées\""});
            this.formule_abo.Location = new System.Drawing.Point(39, 211);
            this.formule_abo.Name = "formule_abo";
            this.formule_abo.PromptText = "Sélectionner une fomule....";
            this.formule_abo.Size = new System.Drawing.Size(233, 29);
            this.formule_abo.TabIndex = 6;
            this.formule_abo.UseCustomBackColor = true;
            this.formule_abo.UseCustomForeColor = true;
            this.formule_abo.UseSelectable = true;
            this.formule_abo.UseStyleColors = true;
            this.formule_abo.SelectedIndexChanged += new System.EventHandler(this.formule_abo_SelectedIndexChanged);
            // 
            // nom_client
            // 
            this.nom_client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_client.Location = new System.Drawing.Point(427, 211);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(235, 29);
            this.nom_client.TabIndex = 7;
            this.nom_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // code_client
            // 
            this.code_client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_client.Location = new System.Drawing.Point(427, 419);
            this.code_client.Name = "code_client";
            this.code_client.Size = new System.Drawing.Size(235, 29);
            this.code_client.TabIndex = 8;
            this.code_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tel_client
            // 
            this.tel_client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_client.Location = new System.Drawing.Point(39, 419);
            this.tel_client.Name = "tel_client";
            this.tel_client.Size = new System.Drawing.Size(235, 29);
            this.tel_client.TabIndex = 9;
            this.tel_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Save
            // 
            this.Save.ActiveControl = null;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.Location = new System.Drawing.Point(615, 474);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 95);
            this.Save.TabIndex = 10;
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
            // Admin_modif_infos_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 569);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tel_client);
            this.Controls.Add(this.code_client);
            this.Controls.Add(this.nom_client);
            this.Controls.Add(this.formule_abo);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.back);
            this.MaximizeBox = false;
            this.Name = "Admin_modif_infos_client";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Mise à jour du client ";
            this.Load += new System.EventHandler(this.Admin_modif_infos_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile back;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroComboBox formule_abo;
        private System.Windows.Forms.TextBox nom_client;
        private System.Windows.Forms.TextBox code_client;
        private System.Windows.Forms.TextBox tel_client;
        private MetroFramework.Controls.MetroTile Save;
    }
}