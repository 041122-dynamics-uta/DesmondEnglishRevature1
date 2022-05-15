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
        static void Main(string[] args)
        {   
            //Greeting
            Console.WriteLine("Welcome to SpaceTime Records!");
            Console.WriteLine("A Digital Record Store where the Vibes are Celestial!!!!\n ");
            
            
            //Ask to view store list 
            Console.WriteLine("Would you like to see a list of stores today?\n");
            string listanswer = Console.ReadLine();
            Console.WriteLine("\n");
            
            //(menu from sql db)
            DigitalRepoClass drc = new DigitalRepoClass();
            BusinessLayerClass blc = new BusinessLayerClass(drc);
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
            Console.WriteLine("\nWhat Store would you like to shop at today?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (num) 
            {
                case 4:
                    Console.WriteLine("Titan");
                    break;
                case 6:
                    Console.WriteLine("Quantum Realm");
                    break;
                case 8:
                    Console.WriteLine("Ancestral Plane");
                    break;
                case 10:
                    Console.WriteLine("Knowhere");
                    break;
                case 12:
                    Console.WriteLine("Kamar-Taj");
                    break;
                case 14:
                    Console.WriteLine("Citadel at the End of Time");
                    break;
                case 16:
                    Console.WriteLine("BattleWord");
                    break;
                default:
                    Console.WriteLine("That is not an option, Please choose a Store!");
                    break;
             } 
             
        }
    }
}


// Sign in or Sign Up- loop

//show store product menu.
//Afterwards let customer add to cart and switch between stores.
//add more than 1 product but no more than $500 total cost and 50 items 
//view current cart then return to shopping 
//cancel purchase even with items in cart
//checkout & log to past purchases and 
//view past purchases (date of purchase,item id, item name, quantity, & total cost)