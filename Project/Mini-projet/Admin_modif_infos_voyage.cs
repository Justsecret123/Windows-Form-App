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
    public partial class Admin_modif_infos_voyage : MetroForm
    {
        string id, Date, Date2;
        bool changed = false;
        int a, d, num;
        Time A = new Time();
        public Admin_modif_infos_voyage(string id, string date, string duree, string prix, int num, int a, int d)
        {
            InitializeComponent();
            this.Text = "Mise à jour du voyage " + id + "";
            this.date.Text = date;
            this.duree.Text = duree;
            this.prix.Text = prix;
            this.id = id;
            this.a = a;
            this.d = d;
            this.num = num;

        }


        public Boolean exists(MySqlConnection conn, int num, int a, int d, string Date)
        {
            //MessageBox.Show("Connexion ouverte");
            string query = "select * from projet.voyage where id_gare = " + d + " AND gar_id_gare = " + a + " AND DATE LIKE '%" + Date + "%' AND id_train = " + num + " ;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
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

            if (reader.Read() == false)
            {
                reader.Close();
                return true;
            }

            while (reader.Read())
            {
                depart = reader.GetString(4);
                duree = reader.GetString(5);
                T.GetTimeSql(depart, T);
                //MessageBox.Show(T.HH + ":" + T.MM);
                T2.GetTimeText(duree, T2);
                MessageBox.Show(T2.HH + ":" + T2.MM);
                if (T.Sup_ab(T, A) == false && T.Addition(T, T2).Sup_ab(T, A))
                {
                    //MessageBox.Show("false");
                    reader.Close();
                    return false;
                }
                else
                {
                    //MessageBox.Show("false");
                    reader.Close();
                    return true;
                }
            }



            return false;
        }



        private void Admin_modif_infos_voyage_Load(object sender, EventArgs e)
        {
            for (int i = 1; i<=7; i++)
            {
                train.Items.Add(i);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_accueil_1();
            f1.Show();
            this.Close();
        }

        private void train_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changed = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string c = "";
            string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();

                if (exists(conn, num, a, d, date.Text) == false)
                {
                    if (free_train(conn, num, a, d, date.Text) == false)
                    { MetroFramework.MetroMessageBox.Show(this, "Le train sélectionné est occupé. Veuillez changer l'heure, la date ou le numéro de train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (this.changed == true)
                        {
                            int num = train.FindStringExact(train.Text);
                            c = "update projet.voyage set id_train = " + num + " , date = '" + date.Text + "'  , duree = '" + duree.Text + "' ,  prix_voyage = " + prix.Text + " where id_voyage = " + id + ";";
                        }
                        else
                        { c = "update projet.voyage set  date = '" + date.Text + "' , duree = '" + duree.Text + "' , prix_voyage = " + prix.Text + " where id_voyage = " + id + ";"; }
                    }
                    MySqlCommand cmd = new MySqlCommand(c, conn);
                    int k = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Voyage modifié !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                { MetroFramework.MetroMessageBox.Show(this, "Ce voyage existe déjà. Veuillez réessayer. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}