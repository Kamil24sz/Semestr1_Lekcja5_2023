using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr1_Lekcja5_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal kosztFilamentu = decimal.Parse(textBox1.Text);
            int zuzytyFilamet = int.Parse(textBox2.Text);

            //jak obliczyć koszt materiału?
            //koszt filamentu zł za 1kg = 1000g
            //zużyty filament w gramach

            decimal kosztMateriału = (kosztFilamentu * zuzytyFilamet) / 1000;

            label3.Text = "Cena materiału wynosi: " + Math.Round(kosztMateriału,2) +"zł";

            // (mocDrukarki * czasWydruku) / 1000  * stawka - obliczanie ceny prądu

            const decimal stawka = 0.95M;

            int mocDrukarki = int.Parse(textBox3.Text);
            int czasWydruku = int.Parse(textBox4.Text);

            decimal cenaPradu = (mocDrukarki * czasWydruku) / 1000M * stawka;

            label6.Text = "Cena prądu wynosi: " + cenaPradu +"zł";
            label7.Text = "Razem: " + (kosztMateriału + cenaPradu+"zł");

        }
    }
}
