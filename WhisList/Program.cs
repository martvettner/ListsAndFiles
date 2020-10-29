using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace WhisList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> whishList = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter {i + 1} fruits: ");
                whishList.Add(Console.ReadLine());
            }
            string filepath = @"C:\data\WhishList.txt";
            File.WriteAllLines(filepath, whishList);



        }
    }
}
