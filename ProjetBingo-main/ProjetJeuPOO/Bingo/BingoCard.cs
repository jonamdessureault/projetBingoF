using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard
    {
        private int[,] carteJoueur = new int[5, 5];

        public BingoCard()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Random random = new Random();
                    int numero = random.Next(75);
                    CarteJoueur[i, j] = numero;                }
            }
        }

        public int[,] CarteJoueur { get => carteJoueur; set => carteJoueur = value; }

        public void AfficherCartes(string choix)
        {
            string B = "B", I = "I", N = "N", G = "G", O = "O";
            Console.WriteLine("Carte du joueur numéro {0}", choix);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("{0,4} {1,4} {2,4} {3,4} {4,4} ", B, I, N, G, O);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0,5} {1,5} {2,5} {3,5} {4,5}", carteJoueur[i, 0], carteJoueur[i, 1], carteJoueur[i, 2], carteJoueur[i, 3], carteJoueur[i, 4]);
            }

        }
    }
}
