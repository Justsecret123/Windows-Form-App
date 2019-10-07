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
    public partial class Admin_modif_infos_client : MetroForm
    {
        int changed;
        string id;
        public Admin_modif_infos_client(string id, string nom, int telephone, string secret_code)
        {
            InitializeComponent();
            this.nom_client.Text = nom;
            this.tel_client.Text = telephone.ToString();
            this.code_client.Text = secret_code;
            this.Text = "Mise à jour du client " + id + "";
            this.id = id;
        }

        private void Admin_modif_infos_client_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_accueil_1();
            f1.Show();
            this.Close();
        }

        private void formule_abo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changed = 1;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous enregistrer ces modifications ? ", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int d = formule_abo.FindStringExact(formule_abo.Text);
                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection conn = new MySqlConnection(connectionstring))
                {
                    conn.Open();
                    string c;
                    if (changed == 1)
                    { c = "update  projet.client set id_formule = '" + d + "', telephone = '" + tel_client.Text + "', nom_client = '" + nom_client.Text + "', secret_code = '" + code_client.Text + "' where (id_client = " + id + ");"; }
                    else
                    { c = "update  projet.client set telephone = '" + tel_client.Text + "', nom_client = '" + nom_client.Text + "', secret_code = '" + code_client.Text + "' where (id_client = " + id + ");"; }
                    MySqlCommand cmd = new MySqlCommand(c, conn);
                    int g = cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Modifications enregistrées ! ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
