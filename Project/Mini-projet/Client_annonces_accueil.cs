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
using MySql.Data.Types;

namespace Mini_projet
{
    public partial class Client_annonces_accueil : MetroForm
    {
        int id;
        public Client_annonces_accueil(int id)
        {
            InitializeComponent();
            this.id = id;
        }



        private void Annonces_accueil_Load(object sender, EventArgs e)
        {

            Liste_.Items.Clear();

            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                Gare.Items.Add("N'importe quelle gare...");
                conn.Open();
                string query = "select nom_gare from projet.gare";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Gare.Items.Add(reader.GetString(0));
                }
                reader.Close();



                refresh_list(Liste_);
 
            




            }




        }


        public void refresh_list(System.Windows.Forms.ListBox list)
        {

            string connectionstring = "server=localhost; database=projet; user=root; password= Eyeshield 21";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query2 = "SELECT  nom_gare FROM gare WHERE(DISPONIBILITE_GARE = 0)";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    list.Items.Add(reader2.GetString(0));
                }
                reader2.Close(); }
        }         



        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Gare_mt_Click(object sender, EventArgs e)
        {
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Back.Visible = false;
            Spinner.Visible = true;
            while(Spinner.Value < 800)
            { Spinner.Value += 1; }
            Spinner.Visible = false;
            Spinner.Value = 0;
            Back.Visible = true;
            Liste.Items.Clear();
            Spinner.Visible = false;




            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
 
                int c1 = Annonce_cb.FindStringExact(Annonce_cb.Text.ToString())+1;
                int c = Gare.FindStringExact(Gare.Text.ToString()) + 1;


                //Toutes annonces toutes gares
                if(c==1 && c1 == 5)
                    {
                    string query = "select Libelle from projet.annonce ;";


                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Liste.Items.Add("-" + reader.GetString(0));
                        Liste.Items.Add("");
                    }
                    reader.Close();


                    Liste.Visible = true;

                    }




                //Gare et type spécifiés
                else if (c > 1 && c1 !=5 && c1 >=1)
                {
                    string query2 = "select Libelle from projet.annonce where Type_annonce = " + c1 + " AND ID_gare = "+(c-1)+";";


                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        Liste.Items.Add("-"+reader2.GetString(0));
                        Liste.Items.Add("");
                    }
                    reader2.Close();


                    Liste.Visible = true;

                }


                //Gare non-spécifiée et type spécifié
                else if (c==1 && c1 !=5 && c1 >=1)
                {
                    string query2 = "select Libelle from projet.annonce where Type_annonce = " + c1 + ";";


                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        Liste.Items.Add("-" + reader2.GetString(0));
                        Liste.Items.Add("");
                    }
                    reader2.Close();


                    Liste.Visible = true;

                }

                //Gare spécifiée et type non-spécifié
                else if (c>1 && c1==5)
                {
                    string query2 = "select Libelle from projet.annonce where ID_gare = " + (c-1) + ";";


                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        Liste.Items.Add("-" + reader2.GetString(0));
                        Liste.Items.Add("");
                    }
                    reader2.Close();


                    Liste.Visible = true;

                }



            }

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Liste.Visible)
            { Liste.Visible = false; }
        }

        private void Annonce_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Liste.Visible)
            { Liste.Visible = false; }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(id);
            f1.Show();
            this.Close();        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back.Size = new System.Drawing.Size(63,62);
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.Size = new System.Drawing.Size(58,57);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

            Back_.Visible = false;
            Spinner_.Visible = true;
            while (Spinner_.Value < 800)
            { Spinner_.Value += 1; }
            Spinner_.Visible = false;
            Spinner_.Value = 0;
            Back_.Visible = true;
            Liste_.Items.Clear();

            refresh_list(Liste_);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Back__MouseEnter(object sender, EventArgs e)
        {
            Back_.Size = new System.Drawing.Size(63, 62);
        }

        private void Back__MouseLeave(object sender, EventArgs e)
        {
            Back_.Size = new System.Drawing.Size(58, 57);
        }

        private void Back__Click(object sender, EventArgs e)
        {
            Back_Click(Back_, e);
        }

        private void Spinner_Click(object sender, EventArgs e)
        {

        }
    }
}
