using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JasonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Product product = new Product(1, "Test Product", 100.01m, 100, new DateTime(2023, 06, 30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product object:");
            Console.WriteLine(json);
            Console.WriteLine(new string('-',50));
            */

            List<Product> products = new List<Product>()
            {
                new Product(1, "Milk", 2.59m, 100, new DateTime(2023, 06, 30)),
                new Product(2, "Lyutenica", 2.39m, 100, new DateTime(2023, 06, 13)),
                new Product(3, "Rice", 1.5m, 100, new DateTime(2023, 06, 12)),
                new Product(4, "Salt", 100.01m, 100, new DateTime(2023, 06, 12)),
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("List of products:");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-', 50));

            //Deserialize a list of data:
            string jsonSizes = @"['Small','Medium','Large']";
            JArray a = JArray.Parse(jsonSizes);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
