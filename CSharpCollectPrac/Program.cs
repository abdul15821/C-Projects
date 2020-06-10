using System;
using System.Collections.Generic;

namespace CSharpCollectPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }
            
            int[] array2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            bool[] booleanArr = new bool[10];
            for (int i = 0; i < booleanArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    booleanArr[i] = true;
                }
                else
                {
                    booleanArr[i] = false;
                }
        }
        //List of Flavors
            string[] flavors = {"Pralines 'n' Creme", "Butter Pecan", "Strawberry", "Chocolate Mint", "Birthday Cake"};
            List<string> flavorsList = new List<string>();
            for (var i = 0; i < flavors.Length; i++)
            {
                flavorsList.Add(flavors[i]);
            }

            Console.WriteLine("The length of our Ice Cream flavorsList is {0}", flavorsList.Count);

            Console.WriteLine("The 3rd flavor in this list is {0}.", flavorsList[2]);
            flavorsList.RemoveAt(2);
            Console.WriteLine("Now we have removed the 3rd element. The new 3rd element in the flavorsList is {0}.", flavorsList[2]);

            Console.WriteLine("The new length of the list is now " + flavorsList.Count + ".");

            // USER INFO DICTIONARY
            Dictionary<string,string> flavor = new Dictionary<string,string>();
            flavor.Add("Kevin", "Chocolate Chip Cookie Dough");
            flavor.Add("Kyle", "Chocolate Chip");
            flavor.Add("Debra", "Mint Chocolate Chip");
            flavor.Add("John", "Sherbert");
            flavor.Add("Patrick", "Vanilla");
            foreach(KeyValuePair<string,string> entry in flavor)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
    }
