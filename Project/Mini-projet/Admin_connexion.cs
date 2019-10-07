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
    public partial class Admin_connexion : MetroFramework.Forms.MetroForm
    {
        public Admin_connexion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            string c = login_txt.Text.ToString();
            string d = passwd_txt.Text.ToString();
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            if (c != "" && d != "")
            {
                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    con.Open();
                    string sqlQuery = "select nom_admin from admin where(login ='" + c + "' AND mot_de_passe = '" + d + "');";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.CommandText = sqlQuery;
                    MySqlDataReader reader = cmd.ExecuteReader();



                    if (reader.Read() == false)
                    { MetroFramework.MetroMessageBox.Show(this, "Login ou mot de passe erroné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        Form f1 = new Admin_question();
                        f1.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f1 = new Accueil();
            f1.Show();
            this.Close();
        }

        private void Client_Click(object sender, EventArgs e)
        {

            Form f1 = new Client_connexion();
            f1.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {this.Close();}

        }

        private void login_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                { passwd_txt.Focus(); }
        }

        private void passwd_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            { login_txt.Focus(); }
            else if(e.KeyCode == Keys.Enter)
            { Connect_btn_Click(passwd_txt, e); }
        }
    }
}
