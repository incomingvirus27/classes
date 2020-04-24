using System;
using System.Collections.Generic;


namespace ClassesAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {           


            while (true)
            {
               Catalog items = new Catalog("Volkswagen", "Jeta", 1999, 9450m);              
                
                List<Catalog> vehicles = new List<Catalog>() { items };
                Console.WriteLine("Welcome to James Stuart’s Cool “Tokunbo” Autos! ");
                Console.WriteLine($"Enter Add command for add, List for list and quit to quit ");               
                string command = Console.ReadLine();

             
                if (command.ToUpper() == "ADD")
                {
                    Console.WriteLine($"Please enter the make of the car");
                    string make = Console.ReadLine();
                    make = items.make;
                    Console.WriteLine($"Please enter the model of the car");
                    string model = Console.ReadLine();
                    model = items.model;
                    Console.WriteLine($"Please enter the year of the car");
                    int year = int.Parse(Console.ReadLine());
                    year = items.year;
                    Console.WriteLine($"Please enter the make of the car");
                    decimal salesPrice = decimal.Parse(Console.ReadLine());
                    salesPrice = items.salesPrice;
                }

               /* if (command.ToUpper() == "LIST")
                {
                    Console.WriteLine(list());
                } 
                */
                    else if (command.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    return;
                }

                }

        }
        


           
          
           
           /* while (true)
            {
                

                Console.WriteLine($"Welcome to James Stuart's cool \"Tokunbo\" autos!");
                Console.WriteLine($"Enter Add command for add, List for list and quit to quit ");

                string  = Console.ReadLine();
                Console.WriteLine($"Enter you Intial Balance ");
                decimal initailBalance = Convert.ToDecimal(Console.ReadLine());


                Account account3 = new Account(newUser, initailBalance);


                Console.WriteLine($"Enter your transtaction type Enter 1 for deposit\n and Enter 2 for withdrawal");
                int transaction = int.Parse(Console.ReadLine());

                if (transaction == 1)
                {

                    Console.WriteLine($"Pls enter amount to despost ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    account3.desposit(amount);

                    Console.WriteLine($"{account3.Name} account has been credited with {amount:C}\n" +
                $"Current balance is now {account3.Balance:C} Thank you for banking with us!");
                }
                if (transaction == 2)
                {
                    Console.WriteLine($"Pls enter amount to withdraw ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    string response = account3.withdrawal(amount);

                    Console.WriteLine($"{response}\nCurrent balance is now {account3.Balance:C} Thank you for banking with us!");
                }



                Console.WriteLine("Would you like to perform another transaction? [Y or N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thank you for Banking with Us");
                    return;
                }
                else
                {
                    return;
                }

            }
            */
        }
    }

