using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data_Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\products.txt";
            string line;

            using (StreamReader stream = new StreamReader(path, true))
            {               
                Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();

                while ((line = stream.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.Length == 0)
                    {
                        continue;
                    }

                    // Розділення рядка на назву продукту та категорію
                    string[] parts = line.Split('-');
                    if (parts.Length != 2)
                    {
                        continue;
                    }

                    string product = parts[0].Trim();
                    string category = parts[1].Trim();

                    // Додавання продукту до категорії
                    if (!categories.ContainsKey(category))
                    {
                        categories[category] = new List<string>();
                    }
                    categories[category].Add(product);
                }

                Console.WriteLine("Вiдгрупованi категорiї товарiв: ");
                foreach (KeyValuePair<string, List<string>> category in categories)
                {
                    Console.WriteLine(category.Key + ":");
                    string productList = string.Join(", ", category.Value.Select(p => p.Trim()));
                    Console.WriteLine("  " + productList);
                }
            }
            Console.ReadLine();
        }
    }
}
