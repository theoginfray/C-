using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public interface IRentable
    {
        decimal CalculateRent();
    }

    public class Livre : IRentable
    {
        public string Titre { get; set; }
        public int Pages { get; set; }

        public decimal CalculateRent()
        {
            return Pages * 0.05m; // Coût de location basé sur le nombre de pages
        }
    }

    public class Disque : IRentable
    {
        public string Titre { get; set; }
        public int Duree { get; set; } // Durée en minutes

        public decimal CalculateRent()
        {
            return Duree * 0.10m; // Coût de location basé sur la durée
        }
    }

    public class Video : IRentable
    {
        public string Titre { get; set; }
        public double Duree { get; set; } // Durée en heures

        public decimal CalculateRent()
        {
            return (decimal)Duree * 2.50m; // Coût de location basé sur la durée
        }
    }
}
