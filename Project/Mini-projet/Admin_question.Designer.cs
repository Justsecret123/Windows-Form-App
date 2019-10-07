namespace Mini_projet
{
    partial class Admin_question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_question));
            this.option_2 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.announce_btn = new MetroFramework.Controls.MetroTile();
            this.back = new MetroFramework.Controls.MetroTile();
            this.option_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // option_2
            // 
            this.option_2.ActiveControl = null;
            this.option_2.BackColor = System.Drawing.Color.DimGray;
            this.option_2.Controls.Add(this.metroPanel1);
            this.option_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.option_2.Location = new System.Drawing.Point(397, 139);
            this.option_2.Name = "option_2";
            this.option_2.Size = new System.Drawing.Size(257, 125);
            this.option_2.TabIndex = 0;
            this.option_2.Text = "Clients/Voyages";
            this.option_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.option_2.TileImage = ((System.Drawing.Image)(resources.GetObject("option_2.TileImage")));
            this.option_2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.option_2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.option_2.UseCustomBackColor = true;
            this.option_2.UseCustomForeColor = true;
            this.option_2.UseSelectable = true;
            this.option_2.UseStyleColors = true;
            this.option_2.UseTileImage = true;
            this.option_2.Click += new System.EventHandler(this.option_2_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(161, 52);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(44, 41);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // announce_btn
            // 
            this.announce_btn.ActiveControl = null;
            this.announce_btn.BackColor = System.Drawing.Color.DimGray;
            this.announce_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.announce_btn.Location = new System.Drawing.Point(70, 139);
            this.announce_btn.Name = "announce_btn";
            this.announce_btn.Size = new System.Drawing.Size(257, 125);
            this.announce_btn.TabIndex = 1;
            this.announce_btn.Text = "Modifier les annonces";
            this.announce_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.announce_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("announce_btn.TileImage")));
            this.announce_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.announce_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.announce_btn.UseCustomBackColor = true;
            this.announce_btn.UseCustomForeColor = true;
            this.announce_btn.UseSelectable = true;
            this.announce_btn.UseStyleColors = true;
            this.announce_btn.UseTileImage = true;
            this.announce_btn.Click += new System.EventHandler(this.announce_btn_Click);
            // 
            // back
            // 
            this.back.ActiveControl = null;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back.Location = new System.Drawing.Point(13, 360);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 73);
            this.back.TabIndex = 2;
            this.back.Text = "Retour";
            this.back.TileImage = ((System.Drawing.Image)(resources.GetObject("back.TileImage")));
            this.back.UseCustomBackColor = true;
            this.back.UseCustomForeColor = true;
            this.back.UseSelectable = true;
            this.back.UseStyleColors = true;
            this.back.UseTileImage = true;
            this.back.Click += new System.EventHandler(this.Go_Click);
            // 
            // Admin_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 442);
            this.Controls.Add(this.back);
            this.Controls.Add(this.announce_btn);
            this.Controls.Add(this.option_2);
            this.Name = "Admin_question";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Que souhaitez-vous ?";
            this.Load += new System.EventHandler(this.Admin_question_Load);
            this.option_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile option_2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile announce_btn;
        private MetroFramework.Controls.MetroTile back;
    }
}