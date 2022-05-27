using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            var input=Console.ReadLine();   
            while (input != "END")
            {
                var inputPArams=input.Split(", ");
                if (inputPArams[0]=="IN")
                {
                    names.Add(inputPArams[1]);
                }
                else
                {
                    names.Remove(inputPArams[1]);
                }
                input = Console.ReadLine();
            }
            if (names.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
            }           
        }
    }
}
