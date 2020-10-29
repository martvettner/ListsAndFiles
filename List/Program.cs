using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\data\test.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from: {line}");
            }

            dataFromFile.Add("grapes");
            File.WriteAllLines(filePath, dataFromFile);


        }
    }
}
