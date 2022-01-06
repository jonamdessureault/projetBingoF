﻿using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        private static Controller controller = new Controller();
       private static BingoController bingoController = new BingoController();
        private static BlackJackController blackJackController = new BlackJackController();
         private static PenduController penduController = new PenduController();

        internal static BingoController BingoController { get => bingoController; set => bingoController = value; }
        internal static BlackJackController BlackJackController { get => blackJackController; set => blackJackController = value; }
        internal static PenduController PenduController { get => penduController; set => penduController = value; }
        internal static Controller controllerEX { get => controller; set => controller = value; }

        static void Main(string[] args)
        {
            Demarrer();
        }

        static void Demarrer()
        {
            do
            {   Console.Clear();
                TableauScore();
                MenuJeux();
            }
            while (true);

        }
        static void TableauScore()
        {

            Console.WriteLine("Bienvenue dans vos jeux!");
            Console.WriteLine("Veuillez entrer votre nom:");
            string nomJoueur = Console.ReadLine();
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("Nom du joueur: {0}", nomJoueur);
            Console.Write("|"); Console.WriteLine("BINGO: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", BingoController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire:{0}", BingoController.PartiesGagnees);
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("BLACKJACK: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", BlackJackController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire: {0}", BlackJackController.PartiesGagnees);
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("LE PENDU: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", PenduController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire: {0}", PenduController.PartiesGagnees);
            Console.WriteLine("******************************");
        }

        static void MenuJeux()
        {
            Console.WriteLine("Veuillez choisir un jeu");
            Console.WriteLine("1- Bingo");
            Console.WriteLine("2- BlackJack");
            Console.WriteLine("3- Le pendu");
            string choixJeux = Console.ReadLine();
            ChoixJeux(choixJeux);
        }
        static void ChoixJeux(string choix)
        {
            switch (choix)
            {
                case "1":
                    bingoController.MenuBingo();
                    break;

                case "2":
                    blackJackController.NouvellePartie();
                    break;
                case "3":
                    penduController.NouvellePartie();
                    break;
            }
        }
  
        
    }
}
