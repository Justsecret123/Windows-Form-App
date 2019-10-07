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
   
    public partial class Client_accueil : MetroForm
    {
        int id;
        public Client_accueil(int id)
        {
            InitializeComponent();
            this.id = id;
            
        }
        public bool abo()
        {

            if (this.Resizable == false)
            { return false; }
            return true;

        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Client_accueil_Load(object sender, EventArgs e)
        {
        }







        //Mouse Enter & Leave 


        private void Quit_MouseEnter(object sender, EventArgs e)
        {
            Quit.Size = new System.Drawing.Size(56, 74);

        }

        private void Quit_MouseLeave(object sender, EventArgs e)
        {
            Quit.Size = new System.Drawing.Size(46, 64);
        }

        //Fin///////////////////////////////////////////////////



        private void Quit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close(); }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form f1 = new Accueil();
            this.Close();
            f1.Show();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
           
            Form f1 = new Client_abonnement(id);
            this.Close();
            f1.Show();
        }

        private void train_Click(object sender, EventArgs e)
        {
            
            Form f1 = new Client_achat_ticket(id);
            this.Close();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Abonnement_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_abonnement(id);
            f1.Show();
            this.Close();
        }

        private void Achat_Click(object sender, EventArgs e)
        {

            Form f1 = new Client_achat_ticket(id);
            f1.Show();
            this.Close();
        }

        private void Annonces_Click(object sender, EventArgs e)
        {
            
            Form f1 = new Client_annonces_accueil(id);
            f1.Show();
            this.Close();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Form f1 = new Accueil();
            f1.Show();
            this.Close();
        }
    }
}
