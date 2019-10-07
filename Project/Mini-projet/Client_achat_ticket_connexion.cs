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
    public partial class Client_achat_ticket_connexion : MetroForm
    {
        int id;
        int id_voyage;
        float prix;
        DateTime t;
        string time;
        public Client_achat_ticket_connexion(int id, int id_voyage, float prix, DateTime t, string time)
        {
            InitializeComponent();
            this.id = id;
            this.id_voyage = id_voyage;
            this.prix = prix;
            this.t = t;
            this.time = time; 

        }

 



        private void Back__Click(object sender, EventArgs e)
        {
            Form f1 = new Client_achat_ticket(id);
            f1.Show();
            this.Close();
        }

        private void Client_achat_ticket_connexion_Load(object sender, EventArgs e)
        {

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            { secret_code.Focus(); }
        }

        private void secret_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Connect_btn_Click(Connect_btn, e); }
            else if (e.KeyCode == Keys.Up)
            { login.Focus(); }
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.client where telephone = " + login.Text + " AND secret_code = '" + secret_code.Text + "' ;";
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() != true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Login ou mot de passe erroné. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bon voyage, " + reader.GetString(2) + "!", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    int id2 = int.Parse(reader.GetString(0));
                    reader.Close();
                    string query = "insert into projet.reservation (id_client,id_voyage,classe,prix_reservation,date_reservation) values (" +id2+ ","+ id_voyage + ", 'A'," + prix + ", '" + t.Year + "-" + t.Month + "-" + t.Day + " " + time + "');";
                    MySqlCommand cmd2 = new MySqlCommand(query, conn);
                    //int f = cmd2.ExecuteNonQuery();
                    Form f1 = new Client_accueil(id2);
                    f1.Show();
                    this.Close();
                }
            }
        }
    }
}
