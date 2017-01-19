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

            //incarca imaginile din resurse
            //intr-o lista
            listaImagini = new List<Image>();

            listaImagini.Add(Resources.piatra);
            listaImagini.Add(Resources.hartie);
            listaImagini.Add(Resources.foarfeca);
        }

        public void startJoc()
        {   
            //afiseaza imaginea de loading cand dai start
            picBox_loading.Image = Resources.loading;
            
            //este folosit pentru a genera numere la intamplare
            Random numarRandom = new Random();

            //generarea unui numar la intamplare
            //din intervalul 0 -> 3
            int jucator1 = numarRandom.Next(0, 3);

            //in functie de numarul generat se afiseaza
            //imaginea din lista, numarul generat este pozitia
            //imaginii din lista initializata mai sus
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

            //generarea unui numar la intamplare
            //din intervalul 0 -> 3
            int jucator2 = numarRandom.Next(0, 3);

            //in functie de numarul generat se afiseaza
            //imaginea din lista, numarul generat este pozitia
            //imaginii din lista initializata mai sus
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

            //pune threadul in care se face generarea numerelor
            //pe pauza timp de 2 secunde. 
            //1 secunda = 1000 de milisecunde
            //2 secunde = 2000 de milisecunde
            Thread.Sleep(2000);

            //facem invoke pe threadul principal
            //MethodInvoker ii spune aplicatie ca trebuie sa ruleze
            //ceva pe threadul principal
            //delegate ne permite sa facem apel catre o actiune/metoda
            //ai informatii despre ce ii delegate aici: http://blog.zeltera.eu/?p=329
            this.Invoke((MethodInvoker)delegate
           {
               //imaginea de loading este pusa pe invizivil pentru vedea imaginile
               //obtinute si pentru a vedea castigatorul
               picBox_loading.Visible = false;

               //butonul devine activ
               btn_start.Enabled = true;

               //aceasta metoda returneza castigatorul 
               //dintre jucatorul 1 si jucatorul 2
               int jucatorCastigator = castigator(jucator1, jucator2);

               // verificam rezultatul obtinut
               if (jucatorCastigator == -1)
               {
                   MessageBox.Show(string.Format("Remiza intre {0} si {1}", numeJucator1, numeJucator2));
               }
               else if(jucatorCastigator == jucator1)
               {
                   MessageBox.Show(string.Format("A castigat {0}", numeJucator1));

                   //adauga la scor valoare 1
                   scorJucator1++;

                   //setam scorul
                   //scorJucator1.ToString() transforma numarul intreg in sir de caractere(string)
                   lbl_scorJucator1.Text = scorJucator1.ToString();
               }
               else
               {
                   MessageBox.Show(string.Format("A castigat {0}", numeJucator2));

                   //adauga la scor valoare 1
                   scorJucator2++;

                   //setam scorul
                   //scorJucator2.ToString() transforma numarul intreg in sir de caractere(string)
                   lbl_scorJucator2.Text = scorJucator2 + "";
               }

           });

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //punem imagine de loading sa fie vizibila
            picBox_loading.Visible = true;

            //pentru acel pictureBox punem sa afiseze imagine cu cele 3 maini
            picBox_loading.Image = Resources.logo;

            //setam scoul la 0 pentru ambii jucatori
            lbl_scorJucator1.Text = "0";
            lbl_scorJucator2.Text = "0";

            //punem grupboxul unde se introduce numele
            //jucatorilor sa fie activ
            groupBox_infoJucatori.Enabled = true;

            //resetam numele jucatorilor
            txt_numeJucator1.Text = "";
            txt_numeJucator2.Text = "";

            //resetam textul de label-uri
            txt_numeJucator1.Text = "Jucator 1";
            txt_numeJucator2.Text = "Jucator 2";
        }

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            //inchide aplicatia
            Application.Exit();
        }

        //returneaza castigatorul
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
            //daca nu sunt completate campurile cu nume 
            if(txt_numeJucator1.Text == "" || txt_numeJucator2.Text == "")
            {
                MessageBox.Show("Introduceti numele voastre!");
            }
            else
            {
                //pune grupul cu numele jucatorilor sa fie 
                //inactiv ca sa nu mai poti modifica numele
                //numai daca dai reset
                groupBox_infoJucatori.Enabled = false;

                //seteaza numele jucatorilor in 2 variablile 
                //globale de care o sa avem nevoie sa afisam
                //cine a castigat
                numeJucator1 = txt_numeJucator1.Text;
                numeJucator2 = txt_numeJucator2.Text;

                //stetam numele jucatorilor in tabela cu scor
                lbl_numeJucator1.Text = numeJucator1;
                lbl_numeJucator2.Text = numeJucator2;

                //se creaza un thread pentru a gasi castigatorii
                new Thread(new ThreadStart(startJoc)).Start();

                //pune imaginea de loading sa fie vizibila
                picBox_loading.Visible = true;

                //pune butonul de start sa fie inactiv
                btn_start.Enabled = false;
            }
        }
    }
}
