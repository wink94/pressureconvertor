using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressure_Converter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pressure_Units> lst_units = new List<Pressure_Units>();
            lst_units.Add(new Pressure_Units("Pascal", 1));
            lst_units.Add(new Pressure_Units("atm", 2));
            lst_units.Add(new Pressure_Units("mmHg", 3));
            lst_units.Add(new Pressure_Units("bar", 4));
            lst_units.Add(new Pressure_Units("torr", 5));
            lst_units.Add(new Pressure_Units("psi", 6));
            lst_units.Add(new Pressure_Units("psf", 7));

            cmbEntry.ValueMember = "ID";
            cmbEntry.DisplayMember = "Name";
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = lst_units;
            cmbEntry.DataSource = bs1;

            cmbOut.ValueMember = "ID";
            cmbOut.DisplayMember = "Name";
            cmbOut.DataSource = lst_units;

        }

        private double conversion(double value,int from,int to)
        {

            double[][] pressureTable = {
                new double[] {1, 0.00000986923266716 ,0.007500616827042 ,0.00001 ,0.007500616827042 ,0.0001450378911491,0.02088545632547  },
                new double[] {101325 ,1,760 ,1.01325 ,760 ,14.69596432068,2116.218862178  },
                new double[] {133.3223684211 ,0.001315789473684 ,1,0.001333223684211 ,1,0.01933679515879,2.784498502865  },
                new double[] {100000 ,0.986923266716 ,750.0616827042 ,1,750.0616827042,14.50378911491,2088.545632547  },
                new double[] {133.3223684211,0.001315789473684 ,1,0.001333223684211 ,1,0.01933679515879,2.784498502865   },
                new double[] {6894.75 ,0.0680458919319 ,51.71487786825 ,0.0689475 ,51.71487786825 ,1,144 },
                new double[] {47.88020833333 ,47.88020833333 ,0.3591310963073 ,0.0004788020833333,0.3591310963073 ,0.006944444444444 ,1}
            };


            return pressureTable[from][to] * value;


        }

        private string getUnit(int unit)
        {
            string val;
            switch (unit)
            {
                case 1:
                    val="Pa";
                    break;
                case 2:
                    val = "atm";
                    break;
                case 3:
                    val = "mmHg";
                    break;
                case 4:
                    val = "bar";
                    break;
                case 5:
                    val = "torr";
                    break;
                case 6:
                    val = "psi";
                    break;
                case 7:
                    val = "psf";
                    break;
                default:
                    val = null;
                    break;
            }

            return val;
        }



        private class Pressure_Units
        {
            public string Name { get; set; }
            public int ID { get; set; }

            public Pressure_Units(string name,int id)
            {
                Name = name;
                ID = id;
            }

            public static explicit operator Pressure_Units(List<Pressure_Units> v)
            {
                throw new NotImplementedException();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int convertFrom, convertTo;
            string value,units;
            double test,answer;
            //bool testValue;


            convertFrom = (int)cmbEntry.SelectedIndex;
            convertTo = (int)cmbOut.SelectedIndex;

            value = txtInput.Text;
            units = getUnit(convertTo+1);

            //testValue = Double.TryParse(value, out test);

            if (!String.IsNullOrEmpty(value) && Double.TryParse(value,out test))
            {
                answer = conversion(Convert.ToDouble(value), convertFrom, convertTo);
               

                lblDisplay.Text=Math.Round(answer,3).ToString()+" "+units;
            }
            else if(Regex.Matches(value, @"[a-zA-Z]").Count > 0)
            {
                lblDisplay.Text = "";
                MessageBox.Show("Enter a valid entry!!");
            }
            else
            {
                lblDisplay.Text = "";
                MessageBox.Show("Enter a value!!");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
