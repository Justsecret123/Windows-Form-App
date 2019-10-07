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
    public partial class Admin_modif_annonce : MetroForm
    {
        string id;
        bool changed_gare = false;
        bool changed_type = false; 
        public Admin_modif_annonce(string id, string libelle)
        {
            InitializeComponent();
            this.Text = "Mise à jour de l'annonce "+ id+"";
            this.libelle.Text = libelle;
            this.id = id;
        }



        private void Admin_modif_annonce_Load(object sender, EventArgs e)
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
                    gare_annonce.Items.Add(reader.GetString(0));
                }
            }
        }
       

        private void back_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_accueil_2();
            f1.Show();
            this.Close();
        }

        private void gare_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed_gare = true;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed_type = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int type;
            int gare;
            bool updated = false;
            string query = "";
            string connectionstring = "server=localhost; database=projet; user=root; password=Eyeshield 21";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                if (changed_gare == true && changed_type == true)
                {
                    type = type_annonce.FindStringExact(type_annonce.Text) + 1;
                    gare = gare_annonce.FindStringExact(gare_annonce.Text) + 1;
                    query = "update annonce set type_annonce = " + type + " ,id_gare = " + gare + " , libelle = '" + libelle.Text + "' where id_annonce = " + id + ";";
                    updated = true;
                    //MessageBox.Show("cas 1");
                }
                else if (changed_type == true && changed_gare == false)
                {
                    type = type_annonce.FindStringExact(type_annonce.Text) + 1;
                    query = "update annonce set type_annonce = " + type + ", libelle = '" + libelle.Text + "' where id_annonce = " + id + " ;";
                    updated = true;
                   // MessageBox.Show("cas 2");
                }
                else if (changed_type == false && changed_gare == true)
                {
                    gare = gare_annonce.FindStringExact(gare_annonce.Text) + 1;
                    query = "update annonce set id_gare = " + gare + " , libelle = '" + libelle.Text + "' where id_annonce = " + id + ";";
                    updated = true;
                    //MessageBox.Show("cas 3");
                }

            if(updated == true )
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int m = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Informations mises à jour ! ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form f1 = new Admin_accueil_2();
                    f1.Show();
                    this.Close();
                }
            }
        }
    }
}
