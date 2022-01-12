using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliBlackJack
{
    class BlackJackController
    {
        private int partiesJouees = 0;
        private int partiesGagnees = 0;

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }
        public BlackJackController()
        {


        }

        public void NouvellePartie()
        {
            Console.WriteLine("À VENIR");
        }
    }
}
