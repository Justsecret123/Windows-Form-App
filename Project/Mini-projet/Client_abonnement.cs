using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Mini_projet
{
    public partial class Client_abonnement : MetroForm
    {
        int id;
        public Client_abonnement(int id)
        {
            InitializeComponent();
            this.id = id;
            
        }

        

            public bool abo()
            {
            
                if(this.Resizable == false)
                    { return false; }
            return true;

            }
        

        private void Abonnement_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 140, 140);
            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, 150, 150);
            kids.Region = new Region(path);
            adults.Region = new Region(path2);
            old.Region = new Region(path);
            student.Region = new Region(path);



            adults_description.Visible = false;
            kids_description2.Visible = false;
            old_description.Visible = false;
            student_description.Visible = false;
            adult_lbl.Visible = false;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_accueil(id);
            this.Close();
            f1.Show();
        }

        private void back_btn_MouseEnter(object sender, EventArgs e)
        {
            back_btn.Size = new System.Drawing.Size(66, 68);
        }

        private void back_btn_MouseLeave(object sender, EventArgs e)
        {
            back_btn.Size = new System.Drawing.Size(46, 48);
        }

        private void adults_MouseEnter(object sender, EventArgs e)
        {
            kids.Visible = false;
            old.Visible = false;
            student.Visible = false;
            adults_label.Visible = false; 
            adults.Size = new System.Drawing.Size(200,200);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            adults.Region = new Region(path);
            adults_description.Visible = true;
            kids_lbl.Visible = false;
            old_lbl.Visible = false;
            student_lbl.Visible = false;
        }

        private void adults_MouseLeave(object sender, EventArgs e)
        {
            adults.Size = new System.Drawing.Size(150, 150);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 150, 150);
            adults.Region = new Region(path);
            adults_description.Visible = false;
            adults_label.Visible = true;
            kids.Visible = true;
            old.Visible = true;
            student.Visible = true;
            kids_lbl.Visible = true;
            old_lbl.Visible = true;
            student_lbl.Visible = true; 
        }

        private void kids_MouseEnter(object sender, EventArgs e)
        {
            adults.Visible = false;
            old.Visible = false;
            student.Visible = false;
            kids_lbl.Visible = false;
            kids.Size = new System.Drawing.Size(200, 200);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            kids.Region = new Region(path);
            kids_description2.Visible = true;
            adults_label.Visible = false;
            old_lbl.Visible = false;
            student_lbl.Visible = false;
            adults_label.Visible = false;

        }

        private void kids_MouseLeave(object sender, EventArgs e)
        {
            kids.Size = new System.Drawing.Size(150, 150);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 140, 140);
            kids.Region = new Region(path);
            kids_description2.Visible = false;
            kids_lbl.Visible = true;
            adults.Visible = true;
            old.Visible = true;
            student.Visible = true;
            adults_label.Visible = true;
            old_lbl.Visible = true;
            student_lbl.Visible = true;
            kids.Visible = true; 
        }

        private void old_MouseEnter(object sender, EventArgs e)
        {
            adults.Visible = false;
            kids.Visible = false;
            student.Visible = false;
            old_lbl.Visible = false;
            old.Size = new System.Drawing.Size(200, 200);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            old.Region = new Region(path);
            old_description.Visible = true;
            adult_lbl.Visible = false;
            kids_lbl.Visible = false;
            adults_label.Visible = false;

            student_lbl.Visible = false;
        }

        private void old_MouseLeave(object sender, EventArgs e)
        {
           old.Size = new System.Drawing.Size(150, 150);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 140, 140);
            old.Region = new Region(path);
            old_description.Visible = false;
            kids_lbl.Visible = true;
            adults.Visible = true;
            kids.Visible = true;
            student.Visible = true;
            adults_label.Visible = true;
            old_lbl.Visible = true;
            student_lbl.Visible = true;
            old.Visible = true;
        }

        private void student_MouseEnter(object sender, EventArgs e)
        {
            adults.Visible = false;
            kids.Visible = false;
            old.Visible = false;
            student_lbl.Visible = false;
            student.Size = new System.Drawing.Size(200, 200);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            student.Region = new Region(path);
            student_description.Visible = true;
            adults_label.Visible = false;
            kids_lbl.Visible = false;
            old_lbl.Visible = false;
            adults_label.Visible = false;

        }

        private void student_MouseLeave(object sender, EventArgs e)
        {
            student.Size = new System.Drawing.Size(150, 150);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 140, 140);
            student.Region = new Region(path);
            student_description.Visible = false;
            kids_lbl.Visible = true;
            adults.Visible = true;
            kids.Visible = true;
            old.Visible = true;
            adults_label.Visible = true;
            student_lbl.Visible = true;
            student_lbl.Visible = true;
            old_lbl.Visible = true;
            
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Placez le curseur sur une icône pour afficher la description.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void kids_Click(object sender, EventArgs e)
        {
            Form f1 = new  Client_inscription(id);
            this.Close();
            f1.Show();
        }

        private void adults_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_inscription(id);
            this.Close();
            f1.Show();
        }

        private void old_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_inscription(id);
            this.Close();
            f1.Show();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Form f1 = new Client_inscription(id);
            this.Close();
            f1.Show();
        }

        private void back_btn_Load(object sender, EventArgs e)
        {

        }
    }
}
