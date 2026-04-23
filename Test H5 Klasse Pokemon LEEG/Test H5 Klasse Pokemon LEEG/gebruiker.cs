using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {

        // Declaratie van de instatie variable
        private string Name;
        private int Gezondheid;
        private int PositieX;
        private int PositieY;
        private Boolean IsLevend;



        // IsLevend
        public Boolean islevend
        {
            get { return IsLevend; }
            set { IsLevend = value; }
        }

        // PositieY
        public int positiey
        {
            get { return PositieY; }
            set { PositieY = value; }
        }

        // PositieX
        public int positiex
        {
            get { return PositieX; }
            set { PositieX = value; }
        }

        // Gezondheid
        public int gezondheid
        {
            get { return Gezondheid; }
            set { Gezondheid = value; }
        }

        // Name
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        // default constructor
        public Speler()
        {
            name = "Naamloos";
            gezondheid = 100;
            positiex = 0;
            positiey = 0;
            islevend = true;

        }

        // constructor overloading
        public Speler(string N, int G, int PX, int PY, Boolean L )
        {
            name = N;
            gezondheid = G;
            positiex = PX;
            positiey = PY;
            islevend = L;   
            
        }

        // methodes
        public int verplaats()
        {
            return 0;
        }

        public int OntvangSchade(int schade)
        {
            // de waarde schade aftrellen van gezondheid
            return gezondheid - schade;
        }

        public int Genees(int genees)
        {
            // de waarde genees bij op gezondheid tellen
            return gezondheid + genees;
        }
    }
}
