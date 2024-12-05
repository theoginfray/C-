using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    public abstract class Publication
    {
        public string Titre { get; set; }

        public abstract void PublishDetails();
    }

    public class LivrePublication : Publication
    {
        public int Pages { get; set; }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre : {Titre}, Pages : {Pages}");
        }
    }

    public class VideoPublication : Publication
    {
        public double Duree { get; set; }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo : {Titre}, Durée : {Duree} heures");
        }
    }
}
