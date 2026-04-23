using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        // daclaratie spelers
        private string speler1 = "Bert", speler2 = "Vis";

        // declaratie random will
        private Random will = new Random();

        // globaal onze instantia aanmaken Speler
        Speler _spel = new Speler();

        public Form1()
        {
            InitializeComponent();
            // we vullen de labels in
            // labels speler invullen
            labelSpeler1.Text = speler1;
            labelSpeler2.Text = speler2;

            // labels gezondheid invullen
            labelGezondheid1.Text = _spel.gezondheid.ToString();
            labelGezondheid2.Text = _spel.gezondheid.ToString();

            // posities geven
            _spel.positiex = will.Next(500);
            _spel.positiey = will.Next(500);

            // levend zetten op true
            _spel.islevend = true;


        }

        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            // schaden aanlevern tussen de 1 en 10
            _spel.OntvangSchade(will.Next(10));

            if (_spel.gezondheid <= 0)
            {
                // tonen dat speler 2 dood is 
                MessageBox.Show(speler2 + "is dood");
            }

            // label updaten
            labelGezondheid2.Text = _spel.gezondheid.ToString();
        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            // genzing aanlevern tussen de 1 en 5
            _spel.Genees(will.Next(5));

            // label updaten
            labelGezondheid1.Text = _spel.gezondheid.ToString();
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            // schaden aanlevern tussen de 1 en 10
            _spel.OntvangSchade(will.Next(10));

            if (_spel.gezondheid <= 0)
            {
                // tonen dat speler 1 dood is 
                MessageBox.Show(speler1 + "is dood");
            }

            // label updaten
            labelGezondheid1.Text = _spel.gezondheid.ToString();

        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            // genzing aanlevern tussen de 1 en 5
            _spel.Genees(will.Next(5));

            // label updaten
            labelGezondheid2.Text = _spel.gezondheid.ToString();
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {


            // cordinaten laten zien door op de knop Toon posities te klikken
            MessageBox.Show(speler1 + ": (" + _spel.positiex + ", " + _spel.positiey + ")\n" + 
                            speler2 + ": (" + _spel.positiex + ", " + _spel.positiey + ")");
        }

        


    }
}
