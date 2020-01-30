using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> menuItems = new Dictionary<string, double>();
            menuItems["Apple Pie"] = 2.99;
            menuItems["Forest Cupcakes"] = 2.99;
            menuItems["Turtle Cookies"] = 1.99;
            menuItems["Chocolate Cookies"] = 1.99;
            menuItems["Cranberry Cookies"] = 1.99;
            menuItems["Buttery Bliss"] = 2.99;
            menuItems["Cherry Tart"] = 5.99;
            menuItems["Fruit Galette"] = 6.99;

            List<string> foodName = new List<string>();
            foodName.Add("apple pie");
            foodName.Add("forest cupcakes");
            foodName.Add("turtle cookies");
            foodName.Add("chocolate cookies");
            foodName.Add("cranberry cookies");
            foodName.Add("buttery bliss");
            foodName.Add("cherry tart");
            foodName.Add("fruit galette");

            List<double> foodPrice = new List<double>();
            foodPrice.Add(2.99);
            foodPrice.Add(2.99);
            foodPrice.Add(1.99);
            foodPrice.Add(1.99);
            foodPrice.Add(1.99);
            foodPrice.Add(2.99);
            foodPrice.Add(5.99);
            foodPrice.Add(6.99);

            List<string> orderName = new List<string>();
            List<double> orderPrice = new List<double>();

            string answer = "";
            double average = 0.0;
            double sum = 0.0;
            
            Console.WriteLine($"Welcome to Home Maid Sweets\n\n");

            do
            {

                do
                {
                    Console.WriteLine($"\t\tSweets \t\tMunnies");
                    Console.WriteLine("\t=================================");

                    foreach (KeyValuePair<string, double> kvPair in menuItems)
                    {
                        Console.WriteLine($"{kvPair.Key,30}: {kvPair.Value,5}");
                    }

                    string item = GetString($"\nWhich item would you like: ").ToLower();
                    //if food is in list
                    while (!foodName.Contains(item))
                    {
                        Console.WriteLine($"\nPlease select an item from the list.");
                        item = GetString($"\nWhich item would you like: ").ToLower();
                    }
                    orderName.Add(item);
                    Console.WriteLine($"\nItem added: {item}");
                    orderPrice.Add(foodPrice[IndexOf(foodName, item)]);
                    answer = GetString($"\nWould you like to add more sweets?\nYes/No").ToLower();
                    Console.Clear();
                } while (answer.Equals("yes") || answer.Equals("y"));

                Console.WriteLine("\nThanks for your order: \nHere's what you got:");
                //prints selected items
                for (int i = 0; i < orderName.Count; i++)
                {

                    Console.WriteLine($"{orderName[i],10}\t${orderPrice[i],10}");
                    sum += orderPrice[i];

                }
                average = Math.Round((sum / orderName.Count),2);

                Console.WriteLine($"\nOrder average: ${average}");

                answer = GetString($"\nWould you like to shop agian?\nYes/No").ToLower();
                Console.Clear();
            } while (answer.Equals("yes") || answer.Equals("y"));


        }
        static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        static int IndexOf(List<string> arr, string s)
        {
            //don't use a foreach--we need index
            for (int i = 0; i < arr.Count; i++)
            {
                if (s == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
