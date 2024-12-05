using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo;

namespace ArticleTableauApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialisation des articles
            List<ArticleTypé> articles = new List<ArticleTypé>
            {
                new ArticleTypé("Pomme", 2.5m, 50, TypeArticle.Alimentaire),
                new ArticleTypé("Savon", 3.2m, 30, TypeArticle.Droguerie),
                new ArticleTypé("T-shirt", 15.0m, 20, TypeArticle.Habillement)
            };

            // Étape 1 : Requêtes LINQ de base
            var alimentaires = articles.Where(a => a.Type == TypeArticle.Alimentaire);
            var articlesTries = articles.OrderByDescending(a => a.Prix);
            var stockTotal = articles.Sum(a => a.Quantite);

            Console.WriteLine("\n1. Articles de type 'Alimentaire' :");
            foreach (var article in alimentaires) article.Afficher();

            Console.WriteLine("\n2. Articles triés par prix décroissant :");
            foreach (var article in articlesTries) article.Afficher();

            Console.WriteLine("\n3. Stock total de tous les articles :");
            Console.WriteLine($"Stock total : {stockTotal}");

            // Étape 2 : Filtrage avancé avec OfType
            var objetsDivers = new List<object>
            {
                new ArticleTypé("Livre", 12.0m, 10, TypeArticle.Loisir),
                "Texte aléatoire",
                new ArticleTypé("Stylo", 1.5m, 100, TypeArticle.Droguerie),
                42,
                new ArticleTypé("Jouet", 20.0m, 5, TypeArticle.Habillement)
            };

            var articlesExtraits = objetsDivers.OfType<ArticleTypé>();
            Console.WriteLine("\n4. Articles extraits avec OfType :");
            foreach (var article in articlesExtraits) article.Afficher();

            // Étape 3 : Projection avec types anonymes
            var vueSimplifiee = articles.Select(a => new { a.Nom, a.Prix });
            Console.WriteLine("\n5. Vue simplifiée des articles (nom et prix) :");
            foreach (var vue in vueSimplifiee) Console.WriteLine($"Nom : {vue.Nom}, Prix : {vue.Prix} euro");

            // Étape 3 : Méthodes d’extension personnalisées
            Console.WriteLine("\n6. Affichage de tous les articles avec AfficherTous :");
            articles.AfficherTous();

            // Étape 3 : Calcul de la valeur totale du stock
            Console.WriteLine("\n7. Valeur totale du stock :");
            var valeurTotaleStock = articles.Sum(a => a.Prix * a.Quantite);
            Console.WriteLine($"Valeur totale du stock : {valeurTotaleStock} euro");

            // Étape 4 : Export JSON
            Console.WriteLine("\n8. Export des articles vers un fichier JSON :");
            string filePath = "articles.json";
            JsonHandler.ExportToJson(articles, filePath);

            // Étape 4 : Import JSON
            Console.WriteLine("\n9. Import des articles depuis un fichier JSON :");
            var importedArticles = JsonHandler.ImportFromJson(filePath);
            Console.WriteLine("Articles importés :");
            importedArticles.AfficherTous();
        }
    }
}