namespace Mini_projet
{
    partial class Client_achat_ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_achat_ticket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.infos = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.hour = new MetroFramework.Controls.MetroComboBox();
            this.gares_a = new MetroFramework.Controls.MetroComboBox();
            this.gares_d = new MetroFramework.Controls.MetroComboBox();
            this.Back_ = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(165, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gare de départ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(418, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gare d\'arrivée";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(539, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(270, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 51);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(240, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choisir une date";
            // 
            // dateTime
            // 
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dateTime.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dateTime.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(212, 214);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 27);
            this.dateTime.TabIndex = 9;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(466, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Horaire";
            // 
            // infos
            // 
            this.infos.Location = new System.Drawing.Point(58, 239);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(83, 20);
            this.infos.TabIndex = 17;
            this.infos.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.hour);
            this.metroPanel1.Controls.Add(this.gares_a);
            this.metroPanel1.Controls.Add(this.gares_d);
            this.metroPanel1.Controls.Add(this.Back_);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.pictureBox3);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.infos);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.dateTime);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-13, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(614, 445);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.Color.Black;
            this.hour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hour.FormattingEnabled = true;
            this.hour.ItemHeight = 23;
            this.hour.Location = new System.Drawing.Point(439, 214);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(132, 29);
            this.hour.TabIndex = 22;
            this.hour.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hour.UseCustomBackColor = true;
            this.hour.UseCustomForeColor = true;
            this.hour.UseSelectable = true;
            this.hour.UseStyleColors = true;
            // 
            // gares_a
            // 
            this.gares_a.BackColor = System.Drawing.Color.Black;
            this.gares_a.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gares_a.FormattingEnabled = true;
            this.gares_a.ItemHeight = 23;
            this.gares_a.Location = new System.Drawing.Point(422, 95);
            this.gares_a.Name = "gares_a";
            this.gares_a.Size = new System.Drawing.Size(169, 29);
            this.gares_a.TabIndex = 21;
            this.gares_a.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gares_a.UseCustomBackColor = true;
            this.gares_a.UseCustomForeColor = true;
            this.gares_a.UseSelectable = true;
            this.gares_a.UseStyleColors = true;
            this.gares_a.SelectedIndexChanged += new System.EventHandler(this.gares_a_SelectedIndexChanged);
            // 
            // gares_d
            // 
            this.gares_d.BackColor = System.Drawing.Color.Black;
            this.gares_d.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gares_d.FormattingEnabled = true;
            this.gares_d.ItemHeight = 23;
            this.gares_d.Location = new System.Drawing.Point(36, 95);
            this.gares_d.Name = "gares_d";
            this.gares_d.Size = new System.Drawing.Size(169, 29);
            this.gares_d.TabIndex = 20;
            this.gares_d.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gares_d.UseCustomBackColor = true;
            this.gares_d.UseCustomForeColor = true;
            this.gares_d.UseSelectable = true;
            this.gares_d.UseStyleColors = true;
            this.gares_d.SelectedIndexChanged += new System.EventHandler(this.gares_d_SelectedIndexChanged);
            this.gares_d.Click += new System.EventHandler(this.gares_d_SelectedIndexChanged);
            // 
            // Back_
            // 
            this.Back_.ActiveControl = null;
            this.Back_.BackColor = System.Drawing.Color.Transparent;
            this.Back_.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back_.Location = new System.Drawing.Point(26, 370);
            this.Back_.Name = "Back_";
            this.Back_.Size = new System.Drawing.Size(57, 57);
            this.Back_.TabIndex = 19;
            this.Back_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Back_.TileImage = ((System.Drawing.Image)(resources.GetObject("Back_.TileImage")));
            this.Back_.UseCustomBackColor = true;
            this.Back_.UseCustomForeColor = true;
            this.Back_.UseSelectable = true;
            this.Back_.UseStyleColors = true;
            this.Back_.UseTileImage = true;
            this.Back_.Click += new System.EventHandler(this.Back__Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Black;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTile1.Location = new System.Drawing.Point(192, 317);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(256, 41);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Valider";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.Validate_btn_Click);
            // 
            // Client_achat_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 466);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client_achat_ticket";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Achat_ticket_Load);
            this.MouseEnter += new System.EventHandler(this.Achat_ticket_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox infos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile Back_;
        private MetroFramework.Controls.MetroComboBox hour;
        private MetroFramework.Controls.MetroComboBox gares_a;
        private MetroFramework.Controls.MetroComboBox gares_d;
    }
}