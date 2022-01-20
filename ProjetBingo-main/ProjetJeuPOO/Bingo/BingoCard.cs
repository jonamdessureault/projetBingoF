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
        

    }
}
