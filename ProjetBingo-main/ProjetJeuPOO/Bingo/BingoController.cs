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
        private List<BingoCard> listeCards;
        private bool partieEnCours = false;
        
        // Arraylist ou list de bingocard

        public BingoController()
        {

        }

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }
        public bool PartieEnCours { get => partieEnCours; set => partieEnCours = value; }
        internal List<BingoCard> ListeCards { get => ListeCards; set => ListeCards = value; }

        public static void AppuyerEnter()
        {
            Console.WriteLine("Veuillez appuyer sur enter pour poursuivre");
            Console.ReadLine();
        }
        public void NouvellePartie()
        {
            this.PartieEnCours = true;
            boulier.fillBoulier();
            PartiesJouees++;
            ChoixNombre();
        }
        public void NombreCartes()
        {
            Console.WriteLine("Veuillez inscrire le numéro de la carte à consulter");
            string nombreCarte = Console.ReadLine();
            ChoixCartes(nombreCarte);
        }
        public void ChoixCartes(string choix)
        {

            switch (choix)
            {
                case "1":
                    listeCards[1].bingoCard.AfficherCartes();
                    break;
                case "2":
                    listeCards[2].bingoCard.AfficherCartes();
                    break;
                case "3":
                    listeCards[3].bingoCard.AfficherCartes();
                    break;
                case "4":
                    listeCards[4].bingoCard.AfficherCartes();
                    break;
                default:
                    Console.WriteLine("Nombre de cartes invalide");
                    break;
            }

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
                this.PartieEnCours = false;
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
            ChoixBingo(choixBingo);
        }

        public void ChoixBingo(string choix)
        {
            switch(choix)
            {
                case "1":
                    NouvellePartie();
                    break;
                case "2":
                    NombreCartes();
                    break;
                case "3":
                    boulier.AfficherCarteA();
                    break;
                case "4":
                    boulier.TirerBoule();
                    break;
                case "5":
                    Console.WriteLine("s");
                    break;
            }
        }

        public void ChoixNombre()
        {
            Console.WriteLine("Combien de cartes désirez-vous jouer ? (4 max)");
            int choixCarte = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < choixCarte; i++)
            {
                BingoCard bingoCard = new BingoCard();
                listeCards = new List<BingoCard>();
                listeCards.Add(bingoCard);
            }

        }
    }
 }