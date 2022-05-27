using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, double>>();
            string input=Console.ReadLine();
            while (input!= "Revision")
            {
                string[] cmd=input.Split(", ");
                string shop=cmd[0]; 
                string product=cmd[1];  
                double price=double.Parse(cmd[2]);
                if (!dic.ContainsKey(shop))
                {
                    dic.Add(shop, new Dictionary<string, double>());
                }
                dic[shop].Add(product, price);  

                input = Console.ReadLine();
            }
            foreach (var shopAndProducts in dic.OrderBy(sp => sp.Key))
            {
                string shopName = shopAndProducts.Key;
                Console.WriteLine(shopName + "->");
                var products = shopAndProducts.Value;
                foreach (var productAndPrice in products)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value} ");
                }
            }
        }
    }
}
