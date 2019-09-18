using ConsoleSecond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimenetund
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Shop

            List<Food> groceries = new List<Food>
            {
                new Food("banana", 1.2),
                new Food("potatoes", 1),
                new Food("icecream", 2.5)
            };

            //Client
            Console.WriteLine("Please enter your first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello," + firstName + "! Please enter your last name: ");
            string lastName = Console.ReadLine();


            Person client = new Person(firstName, lastName);


            Console.WriteLine("Welcome to our shop, " + client + "!");
            client.ShoppingCart = new ShoppingCart();

            ChooseFood(groceries, client);

            while (Console.ReadLine() == "Y")
            {
                ChooseFood(groceries, client);

            }

            double sum = client.ShoppingCart.CalculateSum();
            Console.WriteLine("Your total is " + sum +  " Thanks for visiting!");
              
        }

        private static void ChooseFood(List<Food> groceries, Person client)
        {
            Console.WriteLine("What do you want to buy?");
            string foodName = Console.ReadLine();

            Food chosenFood = groceries.FirstOrDefault(x => x.Name == foodName);

            if (chosenFood == null)
            {
                Console.WriteLine("Excuse me, we don't have " + foodName + "in our shop.");
            }
            else
            {
                Console.WriteLine("How much?");
                string amount = Console.ReadLine();
                int a;
                bool success = int.TryParse(amount, out a);

                while (!success)
                {
                    Console.WriteLine("Excuse me, amount should be integer value: ");
                    amount = Console.ReadLine();
                    success = int.TryParse(amount, out a);
                }
                client.ShoppingCart.AddToCart(chosenFood, a);
            }
            Console.WriteLine("Anything else? Y/N");

            }
        }
    }
