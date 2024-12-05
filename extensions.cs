using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public static class Extensions
    {
        // Méthode d'extension pour afficher tous les articles
        public static void AfficherTous(this List<ArticleTypé> articles)
        {
            foreach (var article in articles)
            {
                article.Afficher();
            }
        }
    }
}
