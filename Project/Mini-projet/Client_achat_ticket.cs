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
    public partial class Client_achat_ticket : MetroForm 
    {
        int id;
        public Client_achat_ticket(int id)
        {
            InitializeComponent();
            this.id = id;
            //MessageBox.Show(+id+"");

        }

   

        private void Back_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(id);
            this.Close();
            f1.Show();
        }

        private void fill_gare()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string sqlQuery = "SELECT nom_gare FROM projet.gare;";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gares_d.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
        }


        private void Achat_ticket_Load(object sender, EventArgs e)
        {
            fill_gare();
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back_.Size = new System.Drawing.Size(49, 35);
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back_.Size = new System.Drawing.Size(44, 30);
        }

        
        private void Achat_ticket_MouseEnter(object sender, EventArgs e)
        {
        }

        private void gares_d_SelectedIndexChanged(object sender, EventArgs e)
        {

            gares_a.Items.Clear();
            gares_a.Text = "";
            hour.Items.Clear();
            hour.Text = "";
            gares_a.Visible = true;
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c;
                int i = 0;
                c = gares_d.FindString(gares_d.Text.ToString()) + 1;
                string sqlQuery2 = "select gar_id_gare from projet.voyage where (id_gare =" + c.ToString() + ");";
                MySqlCommand cmd2 = new MySqlCommand(sqlQuery2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                string[] t = new string[20];
                while (reader2.Read())
                {
                    t[i] = reader2.GetString(0);
                    i++;
                }
                reader2.Close();
                int j = 0;
                while (j <= i)
                {
                    string sqlQuery3 = "select nom_gare from projet.gare where (id_gare = '" + t[j] + "');";
                    MySqlCommand cmd3 = new MySqlCommand(sqlQuery3, conn);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        if (gares_a.FindStringExact(reader3.GetString(0)) < 0)
                        { gares_a.Items.Add(reader3.GetString(0)); }
                    }
                    reader3.Close();
                    j++;
                }

                conn.Close();
            }
        }

        private void gares_a_SelectedIndexChanged(object sender, EventArgs e)
        {
            hour.Items.Clear();
            hour.Text = "";
            if (gares_a.Visible)
            {
                Date D = new Date();
                D.GetDateDtp(dateTime, D);
                
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();

                    int c = gares_d.FindString(gares_d.Text.ToString()) + 1;
                    int c1 = gares_d.FindString(gares_a.Text.ToString()) + 1;
                   
                    string sqlQuery = "SELECT DATE from projet.voyage where (date like('" + D.AA + "-" + D.MM + "-" + D.JJ + "%') AND id_gare= " + c + " AND gar_id_gare = " + c1 + " ) ";
                    //MessageBox.Show("-" + D.AA + "-" + D.MM + "-" + D.JJ);
                    //MessageBox.Show("" + c + "-" + c1);
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    string t;
                    Time A = new Time();
                    while (reader.Read())
                    {
                        t = reader.GetString(0);
                        A = A.GetTimeSql(t, A);
                        hour.Items.Add(A.HH+":"+A.MM);
                    }

                    reader.Close();





                    conn.Close();
                }
            }




        }

        private void gares_a_TextChanged(object sender, EventArgs e)
        {
            if (gares_d.Text == "")
            {
                gares_a.Items.Clear();
                gares_a.Text = "";
                gares_a.Visible = false;
                gares_d.Focus();
            }
        }





        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            hour.Items.Clear();
            hour.Text = "";
            gares_a_SelectedIndexChanged(dateTime, e);
        }

        private void hour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hour_TextChanged(object sender, EventArgs e)
        {

           

        }

        private int recup_prix(MySqlConnection conn , int id, int prix)
        {
            //MessageBox.Show("Recup");
            string c = "select * from projet.client where id_client = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(c, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                //MessageBox.Show("Recup");
                string e = reader.GetString(1);
                if(e=="1")
                {
                    prix = prix - (prix * 25 / 100);
                    //MessageBox.Show("Recup");
                    reader.Close();
                    return prix;
                }
                else if (e == "2")
                { prix = prix - (prix * 20 / 100);
                   //MessageBox.Show("Recup");
                    reader.Close();
                    return prix;
                }
                else if (e == "3")
                {
                    prix = prix - (prix * 15 / 100);
                    //MessageBox.Show("Recup");
                    reader.Close();
                    return prix;
                }
                else if (e == "4")
                {
                    prix = prix - (prix * 30 / 100);
                    //MessageBox.Show("Recup");
                    reader.Close();
                    return prix;
                }
                return prix;
            }
            return prix;
            
        }

        private void Validate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(gares_d.FindStringExact(gares_d.Text.ToString()) == -1)
                    { MetroFramework.MetroMessageBox.Show(this,"Veuillez sélectionner une gare de départ valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gares_d.Focus();}
                if (gares_a.FindStringExact(gares_a.Text.ToString()) == -1)
                    {
                    MetroFramework.MetroMessageBox.Show(this, "Veuillez sélectionner une gare d'arrivée valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gares_a.Focus();}
                if (hour.FindStringExact(hour.Text.ToString()) == -1)
                     {
                    MetroFramework.MetroMessageBox.Show(this,"Veuillez sélectionner un horaire valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hour.Focus();
                     }

                else if (gares_d.FindStringExact(gares_d.Text.ToString()) != -1 && gares_a.FindStringExact(gares_a.Text.ToString()) != -1 && hour.FindStringExact(hour.Text.ToString()) != -1)
                    { 
                    //Récupérer les identifiants des gares sélectionnées 
                    int c1 = gares_d.FindStringExact(gares_d.Text.ToString()) + 1;
                    int c2 = gares_d.FindStringExact(gares_a.Text.ToString()) + 1;
                    //MessageBox.Show("Récupération des id_gare réussie");



                    //Récupération du prix et de l'identifiant du voyage
                    string hh = hour.ToString();
                    int id_voyage = 0;
                    int prix = 0;
                    Date B = new Date();
                    B.AA = dateTime.Value.Year.ToString();
                    B.MM = dateTime.Value.Month.ToString();
                    B.JJ = dateTime.Value.Day.ToString();

                    string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                    using (MySqlConnection conn = new MySqlConnection(connectionstring))
                    {
                        conn.Open();
                        string c = "select * from projet.voyage where id_gare = " + c1 + " AND gar_id_gare = " + c2 + " AND DATE = '" + B.AA + "-" + B.MM + "-" + B.JJ + "" + hh + ":00';";
                        MySqlCommand cmd = new MySqlCommand(c, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            id_voyage = int.Parse(reader.GetString(0));
                            prix = int.Parse(reader.GetString(6));
                            //MessageBox.Show("Récupération des id_voyage et prix réussie");
                        }
                        conn.Close();
                        reader.Close();
                    }
                    

                    //Récupération de la date de la réservation
                    DateTime t = DateTime.Today;
                    string time = DateTime.Now.TimeOfDay.ToString();
                    //MessageBox.Show("Récupération de la date de la réservation réussie");


                    if (id!=0)
                        {

                        using (MySqlConnection conn = new MySqlConnection(connectionstring))
                        {
                            conn.Open();
                            prix = recup_prix(conn,id, prix);
                            string query = "insert into projet.reservation (id_client,id_voyage,classe,prix_reservation,date_reservation) values (" + id + "," + id_voyage + ", 'A'," + prix + ", '" + t.Year + "-" + t.Month + "-" + t.Day + " " + time + "');";
                            MySqlCommand cmd2 = new MySqlCommand(query, conn);
                            int f = cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "Une facture vous sera envoyée à votre adresse.", "Bon voyage !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form f1 = new Client_accueil(id);
                            f1.Show();
                            this.Close();
                        }
                       
                       
                        }
                    else
                    {
                        if(MetroFramework.MetroMessageBox.Show(this, "Possédez-vous une formule d'abonnement ?", "Bon voyage !", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                            {
                            Form f1 = new Client_achat_ticket_connexion(id,id_voyage,prix,t,time);
                            f1.Show();
                            this.Close();
                        }
                        else
                            {
                            Guid g = Guid.NewGuid();
                            string c = g.ToString().Remove(0, 32);
                            MetroFramework.MetroMessageBox.Show(this, "Veuillez récupérer votre ticket au guichet le plus proche, suivi du code suivant : " + c + "");

                            //MessageBox.Show("Ce n'est pas un abonné");
                                string connectionstring2 = "server=localhost; database=projet; user=Developper; password=ffff";
                                using (MySqlConnection conn = new MySqlConnection(connectionstring2))
                                {
                                conn.Open();
                                    //MessageBox.Show("Connexion ouverte. id_voyage = " + id_voyage+ " prix_reservation = "+prix+ " date_reservation = " + t.Year + "-" + t.Month + "-" + t.Day + " "+ time +  "';");
                                    string query = "insert into projet.reservation (id_voyage,classe,prix_reservation,date_reservation) values (" + id_voyage + ", 'B'," + prix + ", '" + t.Year + "-" + t.Month + "-" + t.Day + " " + time + "');";
                                    MySqlCommand cmd = new MySqlCommand(query, conn);
                                    int f = cmd.ExecuteNonQuery();
                                    //MessageBox.Show("Requête exécutée. " + f + " lignes affectées");
                                }
                                
                            }

                    }

                    }
            }
            catch(Exception ex)
            {  }
        }

        private void Back__Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(id);
            f1.Show();
            this.Close();
        }
    }
}