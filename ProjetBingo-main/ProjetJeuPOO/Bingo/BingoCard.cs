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

        public BingoCard()
        {

        }

        public void NombreCartes()
        {
            Console.WriteLine("Veuillez inscrire le numéro de la carte à consulter");
            string nombreCarte = Console.ReadLine();
            ChoixCartes(nombreCarte);
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


        public void AfficherCartes(string choixCarte)
        {

        }

    }
}
