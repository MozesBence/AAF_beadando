using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<int> szamok = new List<int>();
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void generalas_Click(object sender, EventArgs e)
        {
            jobbadatsor.Items.Clear();
            mennyiseg.Text = "0/1000";
            szamok.Clear();
            mutat.Enabled = true;
            baladatsor.Items.Clear();
            Random r = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int szam = r.Next(1, 1000);
                baladatsor.Items.Add(szam);
                szamok.Add(szam);


            }



        }


        private int Prime(int sz)
        {
            for (int i = 2; i < sz; i++)
            {
                if (sz % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        private void mutat_Click(object sender, EventArgs e)
        {
            if (v1.Checked)
            {
                for(int i = 0; i < szamok.Count; i++)
                {
                    if(Prime(szamok[i]) != 1 || szamok[i] == 1)
                    {
                        szamok.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (v2.Checked)
            {
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] % 2 == 1)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
                }
            }
                

            if (v3.Checked)
            {
               for (int i = 0; i < szamok.Count; i++)
               {
                    if (szamok[i] % 2 == 0)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
               }
                    
            }

            if (v4.Checked)
            {
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] % 3 != 0)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
                }

            }

            if (v5.Checked)
            {
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] % 6 != 0)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
                }

            }

            if (v6.Checked)
            {
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] % 9 != 0)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
                }

            }

            if (v7.Checked)
            {
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (Math.Sqrt(szamok[i]) % 1 != 0)
                    {
                        szamok.RemoveAt(i);
                        i--;

                    }
                }

            }

            for(int i = 0; i < szamok.Count; i++)
            {
                jobbadatsor.Items.Add(szamok[i]);
            }





            mennyiseg.Text = szamok.Count + "/1000";
            mutat.Enabled = false;

            }

        private void Form1_Load(object sender, EventArgs e)
        {
            mutat.Enabled = false;
            mennyiseg.Text = "0/1000";
        }

        private void mennyiseg_Click(object sender, EventArgs e)
        {

        }
    }

    }


