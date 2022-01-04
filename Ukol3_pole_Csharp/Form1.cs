using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol3_pole_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zmena_Click(object sender, EventArgs e)
        {
            try
            {
                vystup.Clear();

                char[] pole = vstup.Text.ToCharArray();
                char max = '0';
                

                int pocet = pole.Length - 1;
                int pozice_max = 0;
                int i = 0;
                int i2 = 0;
                int y = 0;

                if (pole[pocet] >= '0' && pole[pocet] <= '9')
                {
                    while (i <= pocet)
                    {
                        if (pole[i] >= '0' && pole[i] <= '9')
                        {
                            pole[i] = 'x';
                        }

                        i++;
                    }
                }
                else
                {
                    while (i2 <= pocet)
                    {
                        if (pole[i2] > max)
                        {
                            max = pole[i2];
                            pozice_max = i2;
                        }

                        i2++;
                    }

                    char posledni = pole[pocet];
                    pole[pocet] = max;
                    pole[pozice_max] = posledni;
                    MessageBox.Show(Convert.ToString(max));
                }

                while (y <= pocet)
                {
                    vystup.AppendText(Convert.ToString(pole[y]));
                    y++;
                }
            }
            catch
            {
                MessageBox.Show("Prvně zadej nějaké znaky!", "Error");
            }
        }
    }
}