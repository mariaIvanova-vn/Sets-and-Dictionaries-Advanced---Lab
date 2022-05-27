using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToArray().Take(3);
           
             Console.Write(String.Join(" ",input));
            
        }
    }
}
