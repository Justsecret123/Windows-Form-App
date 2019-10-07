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
    class Time
    {
        private string _HH;
        private string _MM;
        private string _SS;


        public string HH
        {
            get { return _HH; }
            set { _HH = value; }
        }

        public string MM
        {
            get { return _MM; }
            set { _MM = value; }
        }


        public string SS
        {
            get { return _SS; }
            set { _SS = value; }
        }

        //Constructeur 
        public Time (string H, string M)
        {
            this._HH = H;
            this._MM = M;
            this._SS = "00";
        }


        public Time()
        {
            this._SS = "00";
        }


 

        public Time GetTimeSql(string t, Time A)
        {

            string t1 = "2019-01-05 00:00:00";
            t.ToCharArray();
            string c = t[11].ToString() + t[12].ToString();
            A.HH = c;
            c = t[14].ToString() + t[15].ToString();
            A.MM = c;
            
            //MessageBox.Show(A.HH + ":" + A.MM);
            //MessageBox.Show(t1[11].ToString());
            return A;
        }


        public Time Addition(Time t1, Time t2)
        {
            int c = int.Parse(t1.MM);
            c = c + int.Parse(t2.MM);
            if (c >= 60)
            {
                t1.MM = (c - 60).ToString();
                int d = int.Parse(t2.HH) + 1;
                if (d >= 24)
                { t1.MM = "00"; }
                else
                { t1.MM = d.ToString(); }}
            else
            { t1.MM = c.ToString();}

            return t1;
            }

        public Boolean Sup_ab(Time t1, Time t2)
        {

            if(int.Parse(t1.HH) > int.Parse(t2.HH))
            {
                return true;
            }
            else if (int.Parse(t1.HH) < int.Parse(t2.HH))
            {
                return false;
            }

            else if (int.Parse(t1.HH) == int.Parse(t2.HH))
            {
                if (int.Parse(t1.MM) > int.Parse(t2.MM))
                {
                    return true;
                }

                else if (int.Parse(t1.MM) < int.Parse(t2.MM))
                {
                    return false;
                }
                return true;
            }
            return true;
        }

        public void GetTimeText(string t, Time A)
        {
            t.ToCharArray();
            A.HH = t[0].ToString() + t[1].ToString();
            A.MM = t[3].ToString() + t[4].ToString();

        }



    }





    }

