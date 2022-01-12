using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    class BingoController
    {
        private int partiesJouees = 0;
        private int partiesGagnees = 0;
        Boulier boulier = new Boulier();
        BingoCard bingoCard = new BingoCard();
        // Arraylist ou list de bingocard

        public BingoController()
        {
        }

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }

        public void NouvellePartie()
        {
            boulier.fillBoulier();
            PartiesJouees++;
            Console.WriteLine("COOL");
            MenuBingo();
        }

        public void RefairePartie()
        {
            Console.WriteLine("Voulez-vous refaire une partie ? O/N");
            string choixPartie = Console.ReadLine();
            if(choixPartie == "O")
            {
                NouvellePartie();
            }
            else if(choixPartie == "N")
            {
            }
        }

        public void MenuBingo()
        {
            Console.WriteLine("Bienvenue dans le jeu Bingo!");
            Console.WriteLine("Choisissez une option: ");
            Console.WriteLine("1- Initialiser une nouvelle partie");
            Console.WriteLine("2- Visualiser une des cartes du joueur");
            Console.WriteLine("3- Visualiser la carte de l'annonceur");
            Console.WriteLine("4- Tirez une boule");
            Console.WriteLine("5- Fin de partie");
            string choixBingo = Console.ReadLine();
        }

        public void ChoixBingo(string choix)
        {
            switch(choix)
            {
                case "1":
                    NouvellePartie();
                    break;
                case "2":
                    bingoCard.AfficherCartes();
                    break;
                case "3":
                    bingoCard.AfficherCarteA();
                    break;
                case "4":
                    boulier.TirerBoule();
                    break;
                case "5":
                    Console.WriteLine("s");
                    break;
            }
        }

        public void ChoixCartes(string choix)
        {
            Console.WriteLine("Combien de cartes désirez-vous jouer ? (4 max)");

            switch(choix)
            {
                case "1":
                    bingoCard.CreerCartes();
                    break;

                case "2":
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    break;

                case "3":
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    break;

                case "4":
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    bingoCard.CreerCartes();
                    break;

                default:
                    Console.WriteLine("Veuillez choisir un chiffre entre 1 et 4");
                    break;
            }

        }


    }
 }