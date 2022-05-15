using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        
        
        

        class Wishes
        {
            string title;
            string present;
            

            public Wishes(string _title, string _present)
            {
                title = _title;
                present = _present;
                
            }
            
            public string Title
            {
                get { return title; }
            }
            public string Present
            {
                get { return present; }
            }
            
            static void Main(string[] args)
            {
                List<Wishes> myWishes = new List<Wishes>();
                string[] WishesFromFile = GetDataFromFile();

                foreach (string line in WishesFromFile)
                {
                    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    Wishes newWishes = new Wishes(tempArray[0], tempArray[1]);
                    myWishes.Add(newWishes);

                }
                foreach (Wishes WishesFromList in myWishes)
                {
                    Console.WriteLine($" {WishesFromList.Title} wants {WishesFromList.present}");
                }

            }
            public static void DisplayElementsFromArray(string[] someArray)
            {
                foreach (string element in someArray)
                {
                    Console.WriteLine($"String from array: {element}");
                }

            }

            public static string[] GetDataFromFile()
            {
                string filePath = @"C:\Users\Anti\Samples\frozen.txt";
                string[] dataFromFile = File.ReadAllLines(filePath);
                return dataFromFile;
            }


        }
    }
}
