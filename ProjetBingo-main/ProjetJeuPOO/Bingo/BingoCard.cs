using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard
    {
        int[,] carteJoueur = new int[5, 5];
        BingoCard bingoCard = new BingoCard();

        public BingoCard()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Random random = new Random();
                    int numero = random.Next(75);
                    carteJoueur[i, j] = numero;                }
            }
        }
        public void ChoixCartes(string choix)
        {

            switch(choix)
            {
                case "1":
                    Console.WriteLine("Carte 1");
                    break;
                case "2":
                    Console.WriteLine("Carte 2");
                    break;
                case "3":
                    Console.WriteLine("Carte 3");
                    break;
                case "4":
                    Console.WriteLine("Carte 4");
                    break;
                default: Console.WriteLine("Nombre de cartes invalide");
                    break;
            }

            AfficherCartes(choix);

        }


        public void AfficherCartes(string choix)
        {
            string B = "B", I = "I", N = "N", G = "G", O = "O";
            Console.WriteLine("Carte du joueur numéro {0}", choix);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("{0,4} {1,4} {2,4} {3,4} {4,4} ", B, I, N, G, O);

        }

        public void CreerCartes()
        {

        }

    }
}
