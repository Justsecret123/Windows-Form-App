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
    public partial class Client_connexion : MetroForm
    {
        public Client_connexion()
        {
            InitializeComponent();
        }

        private void Client_connexion_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }
 
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f1 = new Accueil();
            f1.Show();
            this.Close();
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_connexion();
            f1.Show();
            this.Close();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(0);
            f1.Show();
            this.Close();
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if(login.Text != "" && secret_code.Text != "")
            { string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string c = "select * from projet.client where telephone = " + login.Text + " AND secret_code = '" + secret_code.Text + "' ;";
                    MySqlCommand cmd = new MySqlCommand(c, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Bienvenue, " + reader.GetString(2) + "!", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Form f1 = new Client_accueil(int.Parse(reader.GetString(0)));
                        f1.Show();
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Login ou mot de passe erroné. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                { secret_code.Focus(); }
        }

        private void secret_code_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                { Connect_btn_Click(Connect_btn,e); }
            else if(e.KeyCode == Keys.Up)
                { login.Focus(); }
        }
    }
}
