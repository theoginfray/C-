using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public delegate decimal DiscountStrategy(dynamic article);

    public static class DiscountStrategies
    {
        public static decimal FixedDiscount(dynamic article)
        {
            return 10.0m; // Remise fixe de 10 €
        }

        public static decimal PercentageDiscount(dynamic article)
        {
            return article.Prix * 0.10m; // Remise de 10 % du prix
        }

        public static decimal TypeBasedDiscount(dynamic article)
        {
            if (article is Livre) return 5.0m; // Remise de 5 € pour les livres
            if (article is Disque) return 3.0m; // Remise de 3 € pour les disques
            if (article is Video) return 7.0m; // Remise de 7 € pour les vidéos
            return 0.0m;
        }
    }
}
