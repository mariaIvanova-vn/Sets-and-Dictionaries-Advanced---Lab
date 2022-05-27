using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, List<decimal>>();
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name=input[0];   
                decimal grade=decimal.Parse(input[1]);
                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, new List<decimal>());
                    }                   
                     dic[name].Add(grade);                   
            }
            foreach (var item in dic.Keys)
            {
                List<decimal> grades = dic[item];
                string gradesStr = string.Join(" ", grades.Select(g => g.ToString("f2")));
                decimal avg = grades.Average();
                Console.WriteLine($"{item} -> {gradesStr} (avg: {avg:f2})");
            }
        }
    }
}
