using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard: IBingoBoulier
    {
        int[,] carteJoueur = new int[5, 5];
        int[,] carteAnnonceur = new int[5, 15];

        public BingoCard()
        {

        }

        public void add(BingoBall element)
        {
            //Chaque fois qu'une boule est pigée au hasard, on ajoute ce résultat à carteAnnonceur
        }

        public BingoBall getRanbomBall()
        {
            //Choisi une boule au hasard parmis la liste listeBoules
            return null;
        }

        public int getSize()
        {
           //Nous informe sur le contenu des cartes
           return carteAnnonceur.Length;
        }

        public bool isEmpty()
        {
            //Nous informe si oui ou non les cartes contiennent quelque chose
            return (true);
        }

        public void restartBoulier()
        {
            //Réinitialise le contenu de carteAnnonceur
        }

        public void CreerCartes()
        {

        }

        public void AfficherCartes()
        {

        }

        public void AfficherCarteA()
        {

        }
    }
}
