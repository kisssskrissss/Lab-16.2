using System;
using System.IO;
using System.Text.Json;

namespace Lab_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = string.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json")) 
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product max = products[0];
            foreach (Product e in products)
            {
                if (e.Price>max.Price)
                {
                    max = e;
                }
                Console.WriteLine($"{max.Num},{max.Name},{max.Price}");
                Console.ReadKey();
            }
        }
    }
}
