using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    public struct ArticleTypé
    {
        public string Nom { get; private set; }
        public decimal Prix { get; private set; }
        public int Quantite { get; private set; }
        public TypeArticle Type { get; private set; }

        // Constructeur
        public ArticleTypé(string nom, decimal prix, int quantite, TypeArticle type)
        {
            if (prix < 0 || quantite < 0)
                throw new ArgumentException("Le prix et la quantité doivent être positifs.");

            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }

        // Méthode pour afficher l'article
        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}, Prix : {Prix} euro, Quantité : {Quantite}, Type : {Type}");
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
