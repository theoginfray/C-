using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo;

namespace ArticleTableauApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisation du tableau de trois articles
            ArticleTypé[] articles = new ArticleTypé[3];
            articles[0] = new ArticleTypé("Pomme", 1.20m, 50, TypeArticle.Alimentaire);
            articles[1] = new ArticleTypé("Savon", 2.50m, 30, TypeArticle.Droguerie);
            articles[2] = new ArticleTypé("T-shirt", 15.00m, 20, TypeArticle.Habillement);

            // Affichage initial des articles
            Console.WriteLine("Articles initiaux :");
            foreach (var article in articles)
            {
                article.Afficher();
            }

            // Modification des quantités des articles
            Console.WriteLine("\nModification des quantités...");
            articles[0].Ajouter(10); // Ajouter 10 à la quantité de Pomme
            articles[1].Retirer(5);  // Retirer 5 à la quantité de Savon
            articles[2].Ajouter(15); // Ajouter 15 à la quantité de T-shirt

            // Affichage après modification
            Console.WriteLine("\nArticles après modification :");
            foreach (var article in articles)
            {
                article.Afficher();
            }

            // Ajout d'un nouvel article par l'utilisateur
            Console.WriteLine("\nAjout d'un nouvel article :");
            try
            {
                Console.Write("Entrez le nom de l'article : ");
                string nom = Console.ReadLine();

                Console.Write("Entrez le prix de l'article : ");
                decimal prix = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Entrez la quantité de l'article : ");
                int quantite = Convert.ToInt32(Console.ReadLine());

                Console.Write("Entrez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir) : ");
                string typeInput = Console.ReadLine();
                TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle), typeInput, true);

                // Ajout de l'article au tableau (redimensionnement du tableau)
                Array.Resize(ref articles, articles.Length + 1);
                articles[articles.Length - 1] = new ArticleTypé(nom, prix, quantite, type);

                // Affichage de tous les articles
                Console.WriteLine("\nTous les articles après ajout :");
                foreach (var article in articles)
                {
                    article.Afficher();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}