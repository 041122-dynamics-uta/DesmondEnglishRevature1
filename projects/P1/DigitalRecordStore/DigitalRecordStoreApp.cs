using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using digitalStoreDomain;
using DigitalRecordStoreModel;
using Repo;
using DigitalRecordStore;

namespace DigitalRecordStore
{
    class Program
    {
        private static DateTime DateCreated;

        static void Main(string[] args)
        {   
            DigitalRepoClass drc = new DigitalRepoClass();
            BusinessLayerClass blc = new BusinessLayerClass(drc);

            
            Greeting();
            
            //Greeting
            void Greeting() 
            { 
                Console.WriteLine("Welcome to SpaceTime Records!");
                Console.WriteLine("A Digital Record Store where the Vibes are Celestial!!!\n ");
            }

            // Sign in or Sign Up loop
            CustomerClass NewCustomer = new CustomerClass();
            bool sign = true;
            while(sign == true)
            { 
                Console.WriteLine("Sign In or Sign Up? \nSign In = 1\nSign Up = 2\n");
                string SignInUpExit = (Console.ReadLine());

                switch (SignInUpExit)
                {
                    case "1":
                        Console.WriteLine("Enter your Username");
                        string Username = Console.ReadLine();
                        Console.WriteLine("Enter your Password");
                        string Password = Console.ReadLine();
                        Console.WriteLine($"Hello {Username} ");
                        sign = false;
                        break;
                    case "2": //Add new member to DB w/ User & Pswd & Welcome
                        Console.WriteLine("Enter a First Name");
                        string Fname = Console.ReadLine();
                        Console.WriteLine("Enter a Last Name");
                        string Lname = Console.ReadLine();
                        Console.WriteLine("Enter an Email");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Enter a Username");
                        string SUser = Console.ReadLine();
                        Console.WriteLine("Enter a Password");
                        string SPass = Console.ReadLine();
                        NewCustomer = blc.NewCustomer(SUser, SPass, Email, Fname, Lname, DateCreated);
                        Console.WriteLine($"Hello, {NewCustomer.Fname} {NewCustomer.Lname}");
                        sign = false;
                        break;
                    case "admin":
                        Console.WriteLine("\nHello Sorcerer Supreme");
                        sign = false;
                        break;
                    default:
                        Console.WriteLine("Not a Valid Choice. Try Again!");
                        break;
                }
            }
            
            //Ask to view store list 
            Console.WriteLine("\nWould you like to see a list of stores today?\n");
            string listanswer = Console.ReadLine();
            Console.WriteLine("\n");
            if (listanswer.CompareTo("yes") == 0)
            {
                List<StoreClass> stores = blc.StoreClassList();
                foreach (StoreClass s in stores)
                {
                    Console.WriteLine($"Store {s.StoreID} is {s.StoreName}");
                }
            }
            //What store would you like to shop at? 
            //switch case Store picker
            bool store = true;
            while(store == true)
            { 
            Console.WriteLine("\nWhat Store would you like to shop at today?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            switch (num) 
            {
                case 4:
                    Console.WriteLine("Titan");
                    store = false;
                    break;
                case 6:
                    Console.WriteLine("Quantum Realm");
                    store = false;
                    break;
                case 8:
                    Console.WriteLine("Ancestral Plane");
                    store = false;
                    break;
                case 10:
                    Console.WriteLine("Knowhere");
                    store = false;
                    break;
                case 12:
                    Console.WriteLine("Kamar-Taj");
                    store = false;
                    break;
                case 14:
                    Console.WriteLine("Citadel at the End of Time");
                    store = false;
                    break;
                case 16:
                    Console.WriteLine("BattleWord");
                    store = false;
                    break;
                default:
                    Console.WriteLine("That is not an option, Please choose a Store!");
                    store = true;
                    break;
            }
         }
        
             
             
            //show store product menu. 
            Console.WriteLine("\nHere is a list of products from each store!\n");
            List<ProductClass> products = blc.ProductClassList();
            foreach (ProductClass p in products)
            {
                Console.WriteLine($"Store {p.StoreID} ~ ({p.ProductID}) {p.Name} is ${p.Price} by {p.Artist} with {p.Quantity} copies left in Stock\n");
            }

            bool items = true;
            while(items == true)
            { 
            //Afterwards let customer add to cart and switch between stores.
            // make order cart, look at and update changes to.
            Console.WriteLine("What Product() would you like to add to your cart? ");
            int  item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many copies to add to your cart?");
            int  copy = Convert.ToInt32(Console.ReadLine());
        
            //limit the cart selection here
            //add more than 1 product but no more than $500 total cost and 50 items 
            if (copy > 11 )
            {
                Console.WriteLine("This action exceeds the $500 cart limit. Please add less items!");
            } else if (copy < 1)
            {
                Console.WriteLine("You need to add more to your cart!");
            }
            else
            {
                Console.WriteLine("You can proceed!");
                items = false;
            }
            
            BoolCheck();

            //view current cart then return to shopping 
            Console.WriteLine("\nHere is a mid order receipt!");
            Console.WriteLine("Product is ");
            Console.Write(item);
            Console.WriteLine("\n");
            Console.WriteLine("Copies");
            Console.WriteLine(copy);
            }
        

            //cancel purchase even with items in cart
            Console.WriteLine("\nWould you like to cancel anything or checkout?");
            string check = Console.ReadLine();
            Console.WriteLine("\n");
            if (listanswer.CompareTo("cancel") == 0)
            {
                switch (check)
                {
                    case "cancel":
                        Console.WriteLine("Cancel Order");
                    break;
                    case "checkout":
                        Console.WriteLine("Checkout");
                    break;
                }
            }
            
            Console.WriteLine("Thanks for shopping!");
            //checkout
            //view past purchases (date of purchase,item id, item name, quantity, & total cost)
            //sign out & return to top. 
        }

        private static void BoolCheck()
        {
            //throw new NotImplementedException();
        }
    }
}

