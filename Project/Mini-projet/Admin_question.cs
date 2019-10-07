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
    public partial class Admin_question : MetroForm
    {
        public Admin_question()
        {
            InitializeComponent();
        }

        private void Admin_question_Load(object sender, EventArgs e)
        {

        }

        private void Go_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_connexion();
            f1.Show();
            this.Close();
        }

        private void announce_btn_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_accueil_2();
            f1.Show();
            this.Close();
        }

        private void option_2_Click(object sender, EventArgs e)
        {
            Form f1 = new Admin_accueil_1();
            f1.Show();
            this.Close();
        }
    }
}
