using Joc.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Joc
{
    public partial class Form1 : Form
    {
        List<Image> listaImagini;

        string numeJucator1 = "", numeJucator2 = "";
        int scorJucator1 = 0, scorJucator2 = 0;

        public Form1()
        {
            InitializeComponent();

            init();

            //startJoc();
        }

        private void init()
        {
            picBox_loading.Image = Resources.logo;

            listaImagini = new List<Image>();

            listaImagini.Add(Resources.piatra);
            listaImagini.Add(Resources.hartie);
            listaImagini.Add(Resources.foarfeca);
        }

        public void startJoc()
        {          
            picBox_loading.Image = Resources.loading;
            

            Random numarRandom = new Random();

            int jucator1 = numarRandom.Next(0, 3);

            switch (jucator1)
            {
                case 0:
                    picBox_jucator1.Image = listaImagini[0];
                    break;

                case 1:
                    picBox_jucator1.Image = listaImagini[1];
                    break;

                case 2:
                    picBox_jucator1.Image = listaImagini[2];
                    break;
            }

            int jucator2 = numarRandom.Next(0, 3);

            switch (jucator2)
            {
                case 0:
                    picBox_jucator2.Image = listaImagini[0];
                    break;

                case 1:
                    picBox_jucator2.Image = listaImagini[1];
                    break;

                case 2:
                    picBox_jucator2.Image = listaImagini[2];
                    break;
            }

            Thread.Sleep(3000);

           this.Invoke((MethodInvoker)delegate
           {
              

               int jucatorCastigator = castigator(jucator1, jucator2);

               picBox_loading.Visible = false;
               btn_start.Enabled = true;

               if (jucatorCastigator == -1)
               {
                   MessageBox.Show(string.Format("Remiza intre {0} si {1}", numeJucator1, numeJucator2));
               }
               else if(jucatorCastigator == jucator1)
               {
                   MessageBox.Show(string.Format("A castigat {0}", numeJucator1));

                   scorJucator1++;

                   lbl_scorJucator1.Text = scorJucator1 + "";
               }
               else
               {
                   MessageBox.Show(string.Format("A castigat {0}", numeJucator2));

                   scorJucator2++;

                   lbl_scorJucator2.Text = scorJucator2 + "";
               }

           });

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            picBox_loading.Visible = true;
            picBox_loading.Image = Resources.logo;

            lbl_scorJucator1.Text = "0";
            lbl_scorJucator2.Text = "0";

            groupBox_infoJucatori.Enabled = true;

            txt_numeJucator1.Text = "";
            txt_numeJucator2.Text = "";

            
        }

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int castigator(int j1, int j2)
        {
            switch(j1)
            {
                case 0:
                    switch(j2)
                    {
                        case 0:
                            return -1;
                        case 1:
                            return j2;
                        case 2:
                            return j1;
                    }
                    break;

                case 1:
                    switch (j2)
                    {
                        case 0:
                            return j1;
                        case 1:
                            return -1;
                        case 2:
                            return j2;
                    }
                    break;

                case 2:
                    switch (j2)
                    {
                        case 0:
                            return j2;
                        case 1:
                            return j1;
                        case 2:
                            return -1;
                    }
                    break;
            }

            return 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(txt_numeJucator1.Text == "" || txt_numeJucator2.Text == "")
            {
                MessageBox.Show("Introduceti numele voastre!");
            }
            else
            {
                groupBox_infoJucatori.Enabled = false;

                numeJucator1 = txt_numeJucator1.Text;
                numeJucator2 = txt_numeJucator2.Text;

                lbl_numeJucator1.Text = numeJucator1;
                lbl_numeJucator2.Text = numeJucator2;

                new Thread(new ThreadStart(startJoc)).Start();
                picBox_loading.Visible = true;
                btn_start.Enabled = false;
            }

            
        }
    }
}
