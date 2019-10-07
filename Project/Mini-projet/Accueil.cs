using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;


namespace Mini_projet
{
    public partial class Accueil : MetroForm
    {
        public Accueil()
        {
            InitializeComponent();
        }


       

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            
            Form f1 = new Admin_connexion();
            this.Hide();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_btn_MouseEnter(object sender, EventArgs e)
        {
            Admin_btn.Size = new System.Drawing.Size(160,160);
           
        }

        private void Admin_btn_MouseLeave(object sender, EventArgs e)
        {
            Admin_btn.Size = new System.Drawing.Size(150, 150);
         
        }

        private void Client_btn_MouseEnter(object sender, EventArgs e)
        {
            Client_btn.Size = new System.Drawing.Size(160,160);
            
        }

        private void Client_btn_MouseLeave(object sender, EventArgs e)
        {
            Client_btn.Size = new System.Drawing.Size(150, 150);

            
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }
        }



   

        private void Admin_lbl_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Admin_lbl_MouseLeave(object sender, EventArgs e)
        {
            Admin_btn.Size = new System.Drawing.Size(152, 22);
        }

        private void Client_btn_Click(object sender, EventArgs e)
        {
            
            Form f1 = new Client_connexion();
            f1.Show();
            this.Hide();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 155,155);
            Client_btn.Region = new Region(path);
            Admin_btn.Region = new Region(path);
            Admin.Focus();

        }

        private void Client_btn_MouseEnter_1(object sender, EventArgs e)
        {
            Client_btn.Size = new System.Drawing.Size(160, 160);
        }

        private void Client_btn_MouseLeave_1(object sender, EventArgs e)
        {
            Client_btn.Size = new System.Drawing.Size(150, 150);
        }

        private void Exit_btn_MouseEnter(object sender, EventArgs e)
        {
            Exit_btn.Size = new System.Drawing.Size(58, 79);
        }

        private void Exit_btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_btn.Size = new System.Drawing.Size(48, 69);
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Admin_btn_Click(Admin, e);
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client_btn_Click(Client, e);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
