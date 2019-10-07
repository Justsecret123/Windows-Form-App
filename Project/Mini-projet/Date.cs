using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_projet
{
    class Date
    {
        private string _JJ;
        private string _MM;
        private string _AA;

        public string JJ
        {
            get { return _JJ; }
            set { _JJ = value; }
        }

        public string MM
        {
            get { return _MM; }
            set { _MM = value; }
        }

        public string AA
        {
            get { return _AA; }
            set { _AA = value; }
        }

        //Constructeur 
        public Date(string J, string M, string A)
        { 
            this._JJ = J;
            this._MM = M;
            this._AA = A;
        }

        public Date()
            { }

        public void GetDateDtp(System.Windows.Forms.DateTimePicker d, Date D)
            {
            

            D.JJ = d.Value.Day.ToString();
            if (int.Parse(D.JJ) < 10)
            { D.JJ = "0" + D.JJ; }
                D.MM = d.Value.Month.ToString();
            if (int.Parse(D.MM) < 10)
            { D.MM = "0" + D.MM; }
            D.AA = d.Value.Year.ToString();
            }



    }
}
