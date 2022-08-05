using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string znak;
        decimal first = 0;
        decimal second;
        decimal wynik = 0;
        bool hFirst = true;
        bool hWynik = false;
        bool hZnak = false;

        void PrzydzielNum(int x)
        {
            if (hWynik == true && hZnak == true)
            {
                second = x;
            }
            else
            {
                hWynik = false;
                if (hFirst == true)
                {
                    first = x;
                }
                else
                {
                    second = x;
                }
            }
        }

        void Wypisz()
        {
            if (hWynik == true && hZnak == true) textBox1.Text = wynik + " " + znak + " " + second;
            else textBox1.Text = first + " " + znak + " " + second;
        }

        private void bEqual_Click(object sender, EventArgs e) // rownanie
        {
            if (second != 0){
                if (znak == "+") wynik = first + second;
                else if (znak == "-") wynik = first - second;
                else if (znak == "*") wynik = first * second;
                else if (znak == "/") wynik = first / second;
                textBox1.Text = wynik.ToString();
                hWynik = true;
                hZnak = false;
                hFirst = true;
            }
            else{
                textBox1.Text = "Error 404";
            }
        }
        private void b0_Click(object sender, EventArgs e)
        {
            PrzydzielNum(0);
            Wypisz();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            PrzydzielNum(1);
            Wypisz();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            PrzydzielNum(2);
            Wypisz();
        }
        private void b3_Click(object sender, EventArgs e)
        {
            PrzydzielNum(3);
            Wypisz();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            PrzydzielNum(4);
            Wypisz();
        }
        private void b5_Click(object sender, EventArgs e)
        {
            PrzydzielNum(5);
            Wypisz();
        }
        private void b6_Click(object sender, EventArgs e)
        {
            PrzydzielNum(6);
            Wypisz();
        }
        private void b7_Click(object sender, EventArgs e)
        {
            PrzydzielNum(7);
            Wypisz();
        }
        private void b8_Click(object sender, EventArgs e)
        {
            PrzydzielNum(8);
            Wypisz();
        }
        private void b9_Click(object sender, EventArgs e)
        {
            PrzydzielNum(9);
            Wypisz();
        }
        private void bRem_Click(object sender, EventArgs e) // odejmij
        {
            znak = "-";
            hZnak = true;
            hFirst = false;
            Wypisz();
        }
        private void bAdd_Click(object sender, EventArgs e) // dodaj
        {
            znak = "+";
            hZnak = true;
            hFirst = false;
            Wypisz();
        }
        private void bTimes_Click(object sender, EventArgs e) // razy
        {
            znak = "*";
            hZnak = true;
            hFirst = false;
            Wypisz();
        }
        private void bDivide_Click(object sender, EventArgs e) // dzielenie
        {
            znak = "/";
            hZnak = true;
            hFirst = false;
            Wypisz();
        }
    }
}
