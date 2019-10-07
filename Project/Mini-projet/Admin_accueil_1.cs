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
    public partial class Admin_accueil_1 : MetroForm
    {
        public Admin_accueil_1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // TODO: cette ligne de code charge les données dans la table 'projetDataSet.voyage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.voyageTableAdapter.Fill(this.projetDataSet.voyage);
            // TODO: cette ligne de code charge les données dans la table 'projetDataSet.voyage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.voyageTableAdapter.Fill(this.projetDataSet.voyage);
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();

                //Voyages
                DataTable table = new DataTable();
                string c = "select * from projet.voyage";
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "voyage");
                DataTable dt = ds.Tables["voyage"];
                voyages_dg.DataSource = ds.Tables["voyage"];

                //Clients
                DataTable table2 = new DataTable();
                c = "select * from projet.client";
                MySqlDataAdapter da2 = new MySqlDataAdapter(c, conn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "client");
                DataTable dt2 = ds2.Tables["client"];
                client_dg.DataSource = ds2.Tables["client"];
                c = "select nom_gare from projet.gare";
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { this.gare_dep.Items.Add(reader.GetString(0)); }
                reader.Close();
                //Trains
                string c1 = "select id_train from projet.train where disponibilite_train = true ";
                MySqlCommand cmd1 = new MySqlCommand(c1, conn);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                { Train.Items.Add(reader1.GetString(0)); }
                reader1.Close();

                //Liste des gares de départ 
                c = "select nom_gare from projet.gare";
                MySqlCommand cmd2 = new MySqlCommand(c, conn);
                MySqlDataReader reader3 = cmd2.ExecuteReader();
                while (reader3.Read())
                {
                    gare_d_cb.Items.Add(reader3.GetString(0));
                }
            }


            //HH & MM
            for (int i = 0; i < 60; i++)
            {
                if (i <= 9)
                { MM.Items.Add("0" + i.ToString()); }
                else
                { MM.Items.Add(i); }
            }
            for (int i = 0; i < 24; i++)
            {
                if (i <= 9)
                { HH.Items.Add("0" + i.ToString()); }
                else
                { HH.Items.Add(i); }
            }
        }



        private void Quit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); }
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

        private void gare_dep_SelectedIndexChanged(object sender, EventArgs e)
        {


            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {


                this.gare_arr.Items.Clear();
                conn.Open();
                string c = "select nom_gare from projet.gare";
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string t = reader.GetString(0);
                    if (t != gare_dep.Text)
                    { this.gare_arr.Items.Add(t); }
                }
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Search_Click(Search, e);
        }


        public void search_id()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.client where id_client = '" + Zone.Text.ToString() + "' ;";

                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "client");
                DataTable dt = ds.Tables["client"];
                clients_dg.DataSource = ds.Tables["client"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    settings_customer.Visible = true;
                    settings_customer_lbl.Visible = true;
                    delete_btn.Visible = true;
                    delete_lbl.Visible = true;
                }
            }
        }

        public void search_nom()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.client where nom_client LIKE ('%" + Zone.Text.ToString() + "%');";
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "client");
                DataTable dt = ds.Tables["client"];
                clients_dg.DataSource = ds.Tables["client"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    settings_customer.Visible = true;
                    settings_customer_lbl.Visible = true;
                    delete_btn.Visible = true;
                    delete_lbl.Visible = true;
                }
            }
        }

        public void search_code()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.client where secret_code= '" + Zone.Text.ToString() + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "client");
                DataTable dt = ds.Tables["client"];
                clients_dg.DataSource = ds.Tables["client"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    settings_customer.Visible = true;
                    settings_customer_lbl.Visible = true;
                    delete_btn.Visible = true;
                    delete_lbl.Visible = true;
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
            if (Zone.Text != "")
            {
                if (check_id.Visible)
                {
                    search_id();
                    check_id.Visible = false;
                }
                else if (check_name.Visible)
                {
                    search_nom();
                    check_name.Visible = false;
                }
                else if (check_code.Visible)
                {
                    search_code();
                    check_code.Visible = false;
                }
                clients_dg.Visible = true;
            }


        }

        private void ID_Click(object sender, EventArgs e)
        {

            clients_dg.Visible = false;
            check_code.Visible = false;
            check_name.Visible = false;
            check_id.Visible = true;
            clients_dg.Visible = false;
            settings_customer.Visible = false;
            settings_customer_lbl.Visible = false;
            delete_btn.Visible = false;
            delete_lbl.Visible = false;
        }

        private void Nom_Click(object sender, EventArgs e)
        {
            clients_dg.Visible = false;
            check_code.Visible = false;
            check_name.Visible = true;
            check_id.Visible = false;
            clients_dg.Visible = false;
            settings_customer.Visible = false;
            settings_customer_lbl.Visible = false;
            delete_btn.Visible = false;
            delete_lbl.Visible = false;
        }

        private void Code_Click(object sender, EventArgs e)
        {
            clients_dg.Visible = false;
            check_code.Visible = true;
            check_name.Visible = false;
            check_id.Visible = false;
            clients_dg.Visible = false;
            settings_customer.Visible = false;
            settings_customer_lbl.Visible = false;
            delete_btn.Visible = false;
            delete_lbl.Visible = false;
        }


        public Boolean exists(MySqlConnection conn, int num, int a, int d, string Date)
        {
            //MessageBox.Show("Connexion ouverte");
            string query = "select * from projet.voyage where id_gare = " + d + " AND gar_id_gare = " + a + " AND DATE LIKE '%" + Date + "%' AND id_train = " + num + " ;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
           
           if(reader.Read())
            {
                return true;
            }
            reader.Close();
            return false;
        }

        public Boolean free_train(MySqlConnection conn, int num, int a, int d, string Date)
        {

            string query = "select * from projet.voyage where id_gare = " + d + " AND gar_id_gare = " + a + " AND DATE LIKE '%" + Date + "%' AND id_train = " + num + " ;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            Time T = new Time();
            Time T2 = new Time();
            string depart;
            string duree;

            if(reader.Read()==false)
            {
                reader.Close();
                return true; }

            while(reader.Read())
            {
                depart = reader.GetString(4);
                duree = reader.GetString(5);
                T.GetTimeSql(depart, T);
                //MessageBox.Show(T.HH + ":" + T.MM);
                T2.GetTimeText(duree, T2);
                MessageBox.Show(T2.HH + ":" + T2.MM);
                if(T.Sup_ab(T,A) == false && T.Addition(T,T2).Sup_ab(T,A))
                {   //MessageBox.Show("false");
                    reader.Close();
                    return false; }
                else
                {
                    //MessageBox.Show("false");
                    reader.Close();
                    return true;  }
            }
            


            return false;
        }

        public string duree(int d, int a)
        {
            //De Casa vers Rabat Agdal ou de Rabat Agdal vs Casa 
            if (a == 1 && d == 4 || a == 2 && d == 4 || a == 3 && d ==4 || d == 1 && a == 4 || d == 2 && a == 4 || d == 3 && a == 4  )
            { return "01:02:00"; }

            //De Casa vers Rabat Ville ou de Rabat Ville vers Casa
            if(a == 1 && d == 5 || a == 2 && d == 5 || a == 3 && d == 5 || d == 1 && a == 5 || d == 2 && a == 5 || d == 3 && a == 5 )
            { return "01:15:00"; }

            //De Casa vers Marrakech ou de Marrakech vers Casa
            if(a == 1 && d == 6 || a == 2 && d == 6 || a == 3 && d == 6 || d == 1 && a == 6 || d == 2 && a == 6 || d == 3 && a == 6)
            { return "02:25:00"; }

            //De Casa vers Agadir ou d'Agadir vers Casa 
            if(a == 1 && d == 7 || a == 2 && d == 7 || a == 3 && d == 7 || d == 1 && a == 7 || d == 2 && a == 7 || d == 3 && a == 7)
            { return "06:34:00"; }

            //De Casa vers Ain Sebaa ou de Ain Sebaa vers Casa 
            if(a == 1 && d == 8 || a == 2 && d == 8 || a == 3 && d == 8 || d == 1 && a == 8 || d == 2 && a == 8 || d == 3 && a == 8)
            { return "00:15:23"; }

            //De Rabat Agdal vers Marrakech ou de Marrakech vers Rabat Agdal 
            if (a == 4 && d == 6 || a == 6 && d == 4)
            { return "02:45:00"; }

            //De Rabat Ville vers Marrakech ou de Marrakech vers Rabat Ville
            if (a == 5 && d == 6 || a == 6 && d == 5) 
            { return "03:00:00"; }

            //De Rabat Agdal vers Ain Sebaa ou de Ain Sebaa vers Rabat Agdal 
            if (a == 4 && d == 8 || a == 8 && d == 4 )
            { return "00:50:00"; }

            //De Rabat Ville vers Ain Sebaa ou de Ain Sebaa vers Rabat Ville
            if (a == 5 && d == 8 || a == 8 && d == 5 )
            { return "00:53:00"; }

            //De Rabat Agdal vers Agadir ou d'Agadir vers Rabat Agdal 
            if (a == 4 && d == 7 || a == 7 && d == 4 ) 
            { return "07:09:00"; }

            //De Rabat Ville vers Agadir ou d'Agadir vers Rabat Agdal 
            if (a == 5 && d == 7 || a == 7 && d == 5 )
            { return "07:15:00"; }

            //D'Agadir vers Marrakech ou de Marrakech vers Agadir 
            if (a == 7 && d == 6 || a == 6 && d == 7 ) 
            { return "02:15:00"; }

            //D'Agadir vers Ain Sebaa ou d'Ain Sebaa vers Agadir 
            if (a == 7 && d == 8 || a == 8 && d == 7 ) 
            { return "05:20:00"; }



            return "00:10:00";
        }

        public int prix(int a, int d)
        {
            //De Casa vers Rabat Agdal ou de Rabat Agdal vs Casa 
            if (a == 1 && d == 4 || a == 2 && d == 4 || a == 3 && d == 4 || d == 1 && a == 4 || d == 2 && a == 4 || d == 3 && a == 4)
            { return 34; }

            //De Casa vers Rabat Ville ou de Rabat Ville vers Casa
            if (a == 1 && d == 5 || a == 2 && d == 5 || a == 3 && d == 5 || d == 1 && a == 5 || d == 2 && a == 5 || d == 3 && a == 5)
            { return 37; }

            //De Casa vers Marrakech ou de Marrakech vers Casa
            if (a == 1 && d == 6 || a == 2 && d == 6 || a == 3 && d == 6 || d == 1 && a == 6 || d == 2 && a == 6 || d == 3 && a == 6)
            { return 54; }

            //De Casa vers Agadir ou d'Agadir vers Casa 
            if (a == 1 && d == 7 || a == 2 && d == 7 || a == 3 && d == 7 || d == 1 && a == 7 || d == 2 && a == 7 || d == 3 && a == 7)
            { return 67; }

            //De Casa vers Ain Sebaa ou de Ain Sebaa vers Casa 
            if (a == 1 && d == 8 || a == 2 && d == 8 || a == 3 && d == 8 || d == 1 && a == 8 || d == 2 && a == 8 || d == 3 && a == 8)
            { return 15; }

            //De Rabat Agdal vers Marrakech ou de Marrakech vers Rabat Agdal 
            if (a == 4 && d == 6 || a == 6 && d == 4)
            { return 68; }

            //De Rabat Ville vers Marrakech ou de Marrakech vers Rabat Ville
            if (a == 5 && d == 6 || a == 6 && d == 5)
            { return 70; }

            //De Rabat Agdal vers Ain Sebaa ou de Ain Sebaa vers Rabat Agdal 
            if (a == 4 && d == 8 || a == 8 && d == 4)
            { return 28; }

            //De Rabat Ville vers Ain Sebaa ou de Ain Sebaa vers Rabat Ville
            if (a == 5 && d == 8 || a == 8 && d == 5)
            { return 28; }

            //De Rabat Agdal vers Agadir ou d'Agadir vers Rabat Agdal 
            if (a == 4 && d == 7 || a == 7 && d == 4)
            { return 90; }

            //De Rabat Ville vers Agadir ou d'Agadir vers Rabat Agdal 
            if (a == 5 && d == 7 || a == 7 && d == 5)
            { return 95; }

            //D'Agadir vers Marrakech ou de Marrakech vers Agadir 
            if (a == 7 && d == 6 || a == 6 && d == 7)
            { return 35; }

            //D'Agadir vers Ain Sebaa ou d'Ain Sebaa vers Agadir 
            if (a == 7 && d == 8 || a == 8 && d == 7)
            { return 70; }


            return 10;
        }

        public void nouveau_voyage(MySqlConnection conn, int num, int d, int a, string Date)
        {

            
            string query = "insert into projet.voyage (id_gare, gar_id_gare, id_train,date,duree, prix_voyage) values ('" + d + "','" + a + "','" + num + "','" + Date + "','" + duree(d, a) + "','" + prix(a, d) + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int f = cmd.ExecuteNonQuery();
        }


        Time A = new Time();
        private void create_Click(object sender, EventArgs e)
        {
            int num = Train.FindStringExact(Train.Text) + 1;
            int d = gare_dep.FindStringExact(gare_dep.Text) + 1;
            int a = gare_dep.FindStringExact(gare_arr.Text) + 1;
            Date D = new Date();
            Time T = new Time();
            D.GetDateDtp(calendar, D);
            T.HH = HH.Text;
            T.MM = MM.Text;
            this.A = T;
            string Date = D.AA + "-" + D.MM + "-" + D.JJ + " " + A.HH + ":" + A.MM + ":00";
            string Date2 = D.AA + "-" + D.MM + "-" + D.JJ;
            //MessageBox.Show(Date);

            if (T.HH != "" && T.MM != "" && gare_dep.FindStringExact(gare_dep.Text) + 1 > 0 && gare_arr.FindStringExact(gare_arr.Text) + 1 > 0)
            {

                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    if (exists(conn, num, a, d, Date) == false)
                        {//MessageBox.Show("N'existe pas");
                            if (free_train(conn, num, a, d, Date2) == false)
                                {MetroFramework.MetroMessageBox.Show(this, "Le train sélectionné est occupé. Veuillez changer l'heure, la date ou le numéro de train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                            else
                                { nouveau_voyage(conn, num, d, a, Date);
                                  MetroFramework.MetroMessageBox.Show(this, "Voyage créé !", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataTable table = new DataTable();
                            string m = "select * from projet.voyage";
                            MySqlDataAdapter da = new MySqlDataAdapter(m, conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "voyage");
                            DataTable dt = ds.Tables["voyage"];
                            voyages_dg.DataSource = ds.Tables["voyage"];
                        }
                        }

                    else
                        {MetroFramework.MetroMessageBox.Show(this, "Ce voyage existe déjà. Veuillez réessayer. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }
            }



        }

        private void Train_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gare_arr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clients_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Zone.Text = "";
            clients_dg.Visible = false;
            settings_customer.Visible = false;
            settings_customer_lbl.Visible = false;
            delete_btn.Visible = false;
            delete_lbl.Visible = false;
        }

        //Récupérer l'identifiant du client via le DataGrid 

        public string get_id_customer()
        {
            string c = clients_dg.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(c);
            return c;
        }

        private void settings_customer_Click(object sender, EventArgs e)
        {
            if (settings_customer.Visible == true && settings_customer_lbl.Visible == true)
            {
                string c = get_id_customer();

                {
                    string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                    using (MySqlConnection conn = new MySqlConnection(connectionstring))
                    {
                        conn.Open();
                        string t = "select * from client where id_client = " + int.Parse(c) + ";";
                        MySqlCommand cmd = new MySqlCommand(t, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            int formule = int.Parse(reader.GetString(1));
                            //MessageBox.Show(formule.ToString());
                            string nom = reader.GetString(2);
                            //MessageBox.Show(nom);
                            int tel = int.Parse(reader.GetString(4));
                            string secret_code = reader.GetString(6);
                            Form f1 = new Admin_modif_infos_client(id, nom, tel, secret_code);
                            f1.Show();
                            this.Close();
                        }


                    }
                }
            }
        }

        private void settings_customer_lbl_Click(object sender, EventArgs e)
        {
            settings_customer_Click(settings_customer, e);
        }

        private void Zone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { Search_Click(Zone, e); }
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void id_train_Click(object sender, EventArgs e)
        {
            settings_voyages.Visible = false;
            settings_voyages_lbl.Visible = false;
            supprimer_btn.Visible = false;
            supprimer_lbl.Visible = false;
            results.Visible = false;
            id_train_check.Visible = true;
            voyage_id_tb.Visible = true;
            erase_btn.Visible = true;
            train_trajet_check.Visible = false;
            voyages_id_search.Visible = true;
            voyages_trajet_search.Visible = false;
            gare_d_cb.Visible = false;
            gare_d_lbl.Visible = false;
            gare_a_cb.Visible = false;
            gare_a_lbl.Visible = false;
        }

        private void trajet_train_Click(object sender, EventArgs e)
        {
            settings_voyages.Visible = false;
            settings_voyages_lbl.Visible = false;
            supprimer_btn.Visible = false;
            supprimer_lbl.Visible = false;
            results.Visible = false;
            voyages_id_search.Visible = false;
            id_train_check.Visible = false;
            train_trajet_check.Visible = true;
            voyages_trajet_search.Visible = true;
            gare_d_cb.Visible = true;
            gare_d_lbl.Visible = true;
            gare_a_cb.Visible = true;
            gare_a_lbl.Visible = true;
            voyage_id_tb.Visible = false;
            erase_btn.Visible = false;
        }

        private void erase_btn_Click(object sender, EventArgs e)
        {
            results.Visible = false;
            voyage_id_tb.Text = "";
        }

        private void grey_spin()
        {
            grey_spinner.Visible = true;
            while (grey_spinner.Value < 800)
            { grey_spinner.Value += 1; }
            grey_spinner.Value = 0;
            grey_spinner.Visible = false;
        }

        private void gare_d_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            gare_a_cb.Items.Clear();
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c1 = gare_d_cb.FindStringExact(gare_d_cb.Text) + 1;
                string c = "select nom_gare from projet.gare where NOT ID_gare = " + c1 + ";";
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gare_a_cb.Items.Add(reader.GetString(0));
                }
            }
        }

        private void option_voyageID()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string c = "select * from projet.voyage where ID_voyage = " + voyage_id_tb.Text + ";";
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "voyage");
                DataTable dt = ds.Tables["voyage"];
                results.DataSource = ds.Tables["voyage"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    settings_voyages.Visible = true;
                    settings_voyages_lbl.Visible = true;
                    supprimer_btn.Visible = true;
                    supprimer_lbl.Visible = true;
                }

            }
        }

        private void option_voyageTr()
        {
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                int c1 = gare_d_cb.FindStringExact(gare_d_cb.Text.ToString()) + 1;
                int c2 = gare_d_cb.FindStringExact(gare_a_cb.Text.ToString()) + 1;

                string c = "select * from projet.voyage where ID_gare = '" + c1 + "' AND gar_id_gare = '" + c2 + "' ;";
                //MessageBox.Show("*" + c1 + "----" + c2);
                MySqlDataAdapter da = new MySqlDataAdapter(c, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "voyage");
                DataTable dt = ds.Tables["voyage"];
                results.DataSource = ds.Tables["voyage"];
                MySqlCommand cmd = new MySqlCommand(c, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    settings_voyages.Visible = true;
                    settings_voyages_lbl.Visible = true;
                    supprimer_btn.Visible = true;
                    supprimer_lbl.Visible = true;
                }

            }
        }


        private void voyages_id_search_Click(object sender, EventArgs e)
        {
            grey_spin();
            if (voyage_id_tb.Text != "")
            {
                option_voyageID();
                results.Visible = true;
            }
        }

        private void voyages_trajet_search_Click(object sender, EventArgs e)
        {
            grey_spin();
            option_voyageTr();
            results.Visible = true;
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            voyages_id_search_Click(voyages_id_search, e);
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {
            voyages_trajet_search_Click(voyages_trajet_search, e);
        }

        //Récupérer l'identifiant du voyage via le DataGrid, peu importe le mode de recherche sélectionné

        public string get_id_voyage()
        {
            string c = results.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(c);
            return c;
        }

        private void settings_voyages_Click(object sender, EventArgs e)
        {
            if (settings_voyages.Visible == true && settings_voyages_lbl.Visible == true)
            {
                string c = get_id_voyage();

                {
                    string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                    using (MySqlConnection conn = new MySqlConnection(connectionstring))
                    {
                        conn.Open();
                        string t = "select * from projet.voyage where id_voyage = " + int.Parse(c) + ";";
                        MySqlCommand cmd = new MySqlCommand(t, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            int d = int.Parse(reader.GetString(1));
                            int a = int.Parse(reader.GetString(2));
                            int num = int.Parse(reader.GetString(3));
                            string date = reader.GetString(4);
                            string date2 = date;
                            date2.ToCharArray();
                            date = date2[6].ToString() + date2[7].ToString() + date2[8].ToString() + date2[9].ToString() + "-" + date2[3].ToString() + date2[4].ToString() + "-" + date2[0].ToString() + date2[1].ToString() + " " + date2[11].ToString() + date2[12].ToString() + ":" + date2[14].ToString() + date2[15].ToString() + ":00"; 
                            string duree = reader.GetString(5);
                            string prix = reader.GetString(6);
                            Form f1 = new Admin_modif_infos_voyage(id, date, duree, prix, num, a, d);
                            f1.Show();
                            this.Close();
                        }


                    }
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string c = get_id_customer();
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous supprimer ce client ? ", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "delete from projet.client where id_client = " + c + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int g = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Client surppimé ! ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clients_dg.DataSource = null;
                    clients_dg.Visible = false;
                    DataTable table2 = new DataTable();
                    c = "select * from projet.client";
                    MySqlDataAdapter da2 = new MySqlDataAdapter(c, conn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "client");
                    DataTable dt2 = ds2.Tables["client"];
                    client_dg.DataSource = ds2.Tables["client"];
                }
            }

        }

        private void supprimer_btn_Click(object sender, EventArgs e)
        {
            string c = get_id_voyage();
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous supprimer ce voyage ? ", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "delete from projet.voyage where id_voyage = " + c + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int g = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Voyage surppimé ! ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    results.DataSource = null;
                    results.Visible = false;
                    DataTable table = new DataTable();
                    string m = "select * from projet.voyage";
                    MySqlDataAdapter da = new MySqlDataAdapter(m, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "voyage");
                    DataTable dt = ds.Tables["voyage"];
                    voyages_dg.DataSource = ds.Tables["voyage"];

                }
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            string c = g.ToString().Remove(0, 28);
            code_client.Text = c;
        }

        private void create_customer_Click(object sender, EventArgs e)
        {
            if (nom_client.Text == "")
            { nom_client_warning.Visible = true; }
            else
            { nom_client_warning.Visible = false; }
            if (formule_abo.FindStringExact(formule_abo.Text) < 0)
            { formule_abo_warning.Visible = true; }
            else
            { formule_abo_warning.Visible = false; }
            if (tel_client.Text == "" || tel_client.Text.Length < 10)
            { tel_client_warning.Visible = true; }
            else
            { tel_client_warning.Visible = false; }
            if (code_client.Text == "")
            { code_client_warning.Visible = true; }
            else
            { code_client_warning.Visible = false; }

            if (nom_client_warning.Visible == false && formule_abo_warning.Visible == false && tel_client_warning.Visible == false && code_client_warning.Visible == false)
            {
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "insert into projet.client (id_formule,nom_client,adresse_client, telephone,type_client,secret_code) values ('" + (formule_abo.FindStringExact(formule_abo.Text) + 1) + "', '" + nom_client.Text + "', '" + adresse_client.Text + "', '" + tel_client.Text + "' , '2', '" + code_client.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int d = cmd.ExecuteNonQuery();
                    DataTable table2 = new DataTable();
                    string j = "select * from projet.client";
                    MySqlDataAdapter da2 = new MySqlDataAdapter(j, conn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "client");
                    DataTable dt2 = ds2.Tables["client"];
                    client_dg.DataSource = ds2.Tables["client"];
                    MetroFramework.MetroMessageBox.Show(this, "Client créé ! ", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            else
            { MetroFramework.MetroMessageBox.Show(this, "Erreur de saisie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
