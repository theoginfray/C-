using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public struct Article
    {
        private string Nom;
        private decimal Prix;
        private int Quantite;
        // Constructeur
        public Article(string nom, decimal prix, int quantite)
        {
           
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        // Méthode pour afficher l'article
        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}, Prix : {Prix} euro, Quantité : {Quantite}");
        }

        // Méthode pour ajouter une quantité
        public void Ajouter(int quantite)
        {
            if (quantite < 0)
                throw new ArgumentException("La quantité à ajouter doit être positive.");

            Quantite += quantite;
        }

        // Méthode pour retirer une quantité
        public void Retirer(int quantite)
        {
            if (quantite < 0)
                throw new ArgumentException("La quantité à retirer doit être positive.");
            if (quantite > Quantite)
                throw new InvalidOperationException("La quantité à retirer dépasse la quantité disponible.");

            Quantite -= quantite;
        }
    }
}
