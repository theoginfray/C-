using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Exo
{
    public static class JsonHandler
    {
        public static void ExportToJson(List<ArticleTypé> articles, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Formatage lisible
            var jsonString = JsonSerializer.Serialize(articles, options);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"Liste des articles exportée vers le fichier : {filePath}");
        }
    }

    public static List<ArticleTypé> ImportFromJson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Le fichier {filePath} n'existe pas.");
                return new List<ArticleTypé>();
            }

            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<ArticleTypé>>(jsonString);
        }
    }
}
