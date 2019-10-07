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
    public partial class Admin_accueil_2 : MetroForm
    {
        bool search = false;
        public Admin_accueil_2()
        {
            InitializeComponent();
        }

        private void fill()
        {

            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                DataTable table = new DataTable();
                string c = "select * from projet.annonce";
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "annonce");
                DataTable dt = ds.Tables["annonce"];
                grille.DataSource = ds.Tables["annonce"]; 
            }
        }


        private void Admin_accueil_2_Load(object sender, EventArgs e)
        {

            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();

                string c = "select nom_gare from projet.gare";
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gares.Items.Add(reader.GetString(0));
                    gares_search.Items.Add(reader.GetString(0));
                }

                fill();

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_question();
            f1.Show();
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f1 = new Accueil();
            f1.Show();
            this.Close();
        }

        private void gares_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c1 = gares.FindStringExact(gares.Text) + 1;
                string c = "select * from projet.voyage where id_gare = '" + c1 + "' or gar_id_gare = '" + c1 + "' ;";
                DataTable table = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "voyage");
                DataTable dt = ds.Tables["voyage"];
                voyages.DataSource = ds.Tables["voyage"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                { this.search = true; }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {
            check_id.Visible = true;
            check_gare.Visible = false;
            check_annonce.Visible = false;
            id_search.Visible = true;
            gares_search.Visible = false;
            type_search.Visible = false;
            results.Visible = false;
            delete.Visible = false;
            delete_lbl.Visible = false;
            settings.Visible = false;
            settings_lbl.Visible = false;

        }

        private void gare_c_Click(object sender, EventArgs e)
        {
            check_id.Visible = false;
            check_gare.Visible = true;
            check_annonce.Visible = false;
            id_search.Visible = false;
            gares_search.Visible = true;
            type_search.Visible = false;
            results.Visible = false;
            delete.Visible = false;
            delete_lbl.Visible = false;
            settings.Visible = false;
            settings_lbl.Visible = false;
        }

        private void type_a_Click(object sender, EventArgs e)
        {
            check_id.Visible = false;
            check_gare.Visible = false;
            check_annonce.Visible = true;
            id_search.Visible = false;
            gares_search.Visible = false;
            type_search.Visible = true;
            results.Visible = false;
            delete.Visible = false;
            delete_lbl.Visible = false;
            settings.Visible = false;
            settings_lbl.Visible = false;
        }


        private void search_id()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.annonce where id_annonce = " + id_search.Text.ToString() + ";";
                DataTable table = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "annonce");
                DataTable dt = ds.Tables["annonce"];
                results.DataSource = ds.Tables["annonce"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    delete.Visible = true;
                    delete_lbl.Visible = true;
                    settings.Visible = true;
                    settings_lbl.Visible = true;
                    results.Visible = true;
                }


            }
        }

        private void search_type()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c1 = type_search.FindStringExact(type_search.Text) + 1;
                string c = "select * from projet.annonce where type_annonce = " + c1 + ";";
                DataTable table = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "annonce");
                DataTable dt = ds.Tables["annonce"];
                results.DataSource = ds.Tables["annonce"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    delete.Visible = true;
                    delete_lbl.Visible = true;
                    settings.Visible = true;
                    settings_lbl.Visible = true;
                    results.Visible = true;
                }


            }
        }

        private void search_gare()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c1 = gares_search.FindStringExact(gares_search.Text) + 1;
                string c = "select * from projet.annonce where id_gare = '" + c1 + "' ;";
                DataTable table = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "annonce");
                DataTable dt = ds.Tables["annonce"];
                results.DataSource = ds.Tables["annonce"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    delete.Visible = true;
                    delete_lbl.Visible = true;
                    settings.Visible = true;
                    settings_lbl.Visible = true;
                    results.Visible = true;
                }


            }
        }



        private void Search_Click(object sender, EventArgs e)
        {
            Spinner.Visible = true;
            while (Spinner.Value < 800)
            { Spinner.Value += 1; }
            Spinner.Value = 0;
            Spinner.Visible = false;
            if (check_id.Visible && id_search.Text != "")
            {
                search_id();
            }
            if (check_gare.Visible)
            {
                search_gare();
            }
            if (check_annonce.Visible)
            {
                search_type();
            }




        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Search_Click(Search, e);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous supprimer cette annonce ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string c = get_id();
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "delete from projet.annonce where id_annonce = " + c + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int d = cmd.ExecuteNonQuery();
                    results.Visible = false;
                    results.DataSource = null;
                    results.Refresh();
                    fill();
                }
            }
        }

        public string get_id()
        {
            string c = results.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(c);
            return c;
        }


        private void settings_Click(object sender, EventArgs e)
        {
            string c = get_id();
            {
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "select * from projet.annonce where id_annonce = " + c + " ;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string libelle = reader.GetString(4);
                        string id = reader.GetString(0);
                        Form f1 = new Admin_modif_annonce(id, libelle);
                        f1.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (gares.Text == "")
            { gares_warning.Visible = true; }
            else
            { gares_warning.Visible = false; }
            if (type.Text == "")
            { type_warning.Visible = true; }
            else
            { type_warning.Visible = false; }
            if (libelle.Text == "")
            { libelle_warning.Visible = true; }
            else
            { libelle_warning.Visible = false; }
            string c;

            if (gares_warning.Visible == false && type_warning.Visible == false && libelle_warning.Visible == false && search == true)
            {
                c = voyages.SelectedRows[0].Cells[0].Value.ToString();
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "insert into projet.annonce (id_voyage,id_gare,type_annonce,libelle) values ('" + c + "', '" + (gares.FindStringExact(gares.Text) + 1) + "', '" + (type.FindStringExact(type.Text) + 1) + "', '" + libelle.Text + " ');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int p = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Annonce créée!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fill();
                }
            }
            else
            { MetroFramework.MetroMessageBox.Show(this, "Erreur de saisie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}