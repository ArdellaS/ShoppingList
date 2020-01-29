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

            List<string> foodOrder = new List<string>();

            string answer = "";
            double average = 0;

            string welcome = "Welcome to Home Maid Sweets";

            Console.WriteLine($"{welcome}\n\n");
            //while (true)
            //{
            Console.WriteLine($"\t\tSweets \t\tMunnies");
            Console.WriteLine("\t=================================");

            


            do
            {
                foreach (KeyValuePair<string, double> kvPair in menuItems)
                {
                    Console.WriteLine($"{kvPair.Key,30}: {kvPair.Value,5}");
                }

                string item = GetString("Which item would you like: ").ToLower();
                //if food is in list
                while (!foodName.Contains(item))
                {
                    Console.WriteLine("Please select an item from the list.");
                    item = GetString("Which item would you like: ").ToLower();
                }
                foodOrder.Add(item);
                Console.WriteLine($"Order contains: {item}");

                answer = GetString("Would you like to add more sweets?\nYes/No").ToLower();
                Console.Clear();
            } while (answer.Equals("yes") || answer.Equals("y"));
            

            Console.WriteLine("Thanks for your order: \nHere's what you go");
            //prints selected items
            for (int i = 0; i < foodOrder.Count; i++)
            {
                Console.WriteLine($"{foodOrder[i]}\t{foodPrice[i]}");
            }



            //}

        }
        static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
