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
    public partial class Client_inscription : MetroFramework.Forms.MetroForm
    {
        int id;
        public Client_inscription(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Client_inscription_Load(object sender, EventArgs e)
        {
            warning_name.Visible = false;
            warning_phone.Visible = false;
            warning_prenom.Visible = false;
        }

        public Boolean Int()
        {
            try
            {
                char[] t = Phone_txt.Text.ToCharArray();
                for (int i = 0; i <= t.Length; i++)
                {
                    if (t[i] != '0' && t[i] != '1' && t[i] != '2' && t[i] != '3' && t[i] != '4' && t[i] != '5' && t[i] != '6' && t[i] != '7' && t[i] != '8' && t[i] != '9')
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            { return true; }
        }



        public Boolean Char(char[] t)
        {
            try
            {
                for (int i = 0; i <= t.Length; i++)
                {
                    if (t[i] < 'A' && t[i] != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            { return true; }
        }



        private void Validate_Click(object sender, EventArgs e)
        {

            char[] t = Name_txt.Text.ToCharArray();
            char[] t1 = Prenom_txt.Text.ToCharArray();

            if (Int() == false)
            {
                warning_phone.Visible = true;
                MetroFramework.MetroMessageBox.Show(this, "Le numéro de téléphone ne peut contenir de caractère autre qu'un entier.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (Char(t) == false)
            {
                warning_name.Visible = true;
                MetroFramework.MetroMessageBox.Show(this, "Le nom ne peut contenir de chiffre ou de caractère.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (Char(t1) == false)
            {
                warning_prenom.Visible = true;
                MetroFramework.MetroMessageBox.Show(this, "Le prénom ne peut contenir de chiffre ou de caractère.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (Int() == true && Char(t) == true && Char(t1) == true && Name_txt.Text!="" && Prenom_txt.Text !="" &&  Phone_txt.Text!="")
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenue parmi nous, " + Prenom_txt.Text + " ! Votre code secret vous sera communiqué par SMS.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DateTime today = DateTime.Today;
                int AA = today.Year - Date_dtp.Value.Year;
                int MM = today.Month - Date_dtp.Value.Month;
                int JJ = today.Day - Date_dtp.Value.Day;

                int age = (JJ + MM * 30 + AA * 365) / 365;
                //MessageBox.Show(age.ToString());
                int formule = 0;

                if(age >= 3 && age <=14)
                {
                    formule = 1; 
                }
               else if( age >14 && age<=24)
                {
                    formule = 2;
                }
                else if (age > 24 && age <= 50)
                {
                    formule = 3;
                }
                else if (age > 50)
                {
                    formule = 4;
                }
                Guid g = Guid.NewGuid();
                string code = g.ToString();
                code = code.Remove(0, 28);
                //MessageBox.Show(code);



                string connectionstring = "server=localhost; database=projet; user=Developper; password=ffff";
                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    con.Open();
                    string sqlQuery = "insert into projet.client(ID_formule,Nom_client,Adresse_client,Telephone,Secret_code, Type_client) values(    " + formule+  ",'"    +Name_txt.Text+ ""  +Prenom_txt.Text+   "','"   +Adresse_txt.Text+  "','"   +Phone_txt.Text+    "' ,'"  +code+   "', 2);"    ;
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.CommandText = sqlQuery;
                    int c = cmd.ExecuteNonQuery();
                    Form f1 = new Client_accueil(id);
                    f1.Show();
                    this.Close();

                }
            }
            else if (Name_txt.Text == "" || Prenom_txt.Text == "" || Phone_txt.Text == "")
                { MetroFramework.MetroMessageBox.Show(this, "Les champs 'Nom', 'Prénom' et 'Date de naissance' ne peuvent être vides." ,"Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Name_txt.Focus();  }



        }

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char[] t = Name_txt.Text.ToCharArray();

                if (Char(t) == false)
                { warning_name.Visible = true; }
                else
                { warning_name.Visible = false; }

            }
            catch (Exception ex)
            { }
        }

        private void Phone_txt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int() == false)
                { warning_phone.Visible = true; }
                else
                { warning_phone.Visible = false; }
            }
            catch (Exception ex)
            { warning_phone.Visible = false; }
        }

        private void Phone_txt_TextChanged(object sender, EventArgs e)
        {
            if (Int() == false)
            {
                warning_phone.Visible = true;
            }
            else
            { warning_phone.Visible = false; }
        }

        private void Prenom_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                char[] t = Prenom_txt.Text.ToCharArray();

                if (Char(t) == false)
                { warning_prenom.Visible = true; }
                else
                { warning_prenom.Visible = false; }

            }
            catch (Exception ex)
            { }
        }

        private void Back_Click(object sender, EventArgs e)
        {
           
            Form f1 = new Client_abonnement(id);
            f1.Show();
            this.Close();
        }

        private void Home_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(id);
            f1.Show();
            this.Close();
        }

        private void Name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter )
            { Prenom_txt.Focus(); }
        }

        private void Prenom_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            { Adresse_txt.Focus(); }
            else if (e.KeyCode == Keys.Up)
            { Name_txt.Focus(); }
        }

        private void Adresse_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            { Phone_txt.Focus(); }
            else if (e.KeyCode == Keys.Up)
            { Prenom_txt.Focus(); }
        }

        private void Phone_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            { Adresse_txt.Focus(); }
            else if (e.KeyCode == Keys.Enter)
            { Validate_Click(Phone_txt, e); }
        }
    }
}
