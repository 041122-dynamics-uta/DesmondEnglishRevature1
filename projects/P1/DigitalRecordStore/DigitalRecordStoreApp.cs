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
            //Console.WriteLine("What Store would you like to shop at today?");
            Console.WriteLine("Would you like to see a list of stores today?\n");
            string answer = Console.ReadLine();

            DigitalRepoClass drc = new DigitalRepoClass();
            BusinessLayerClass blc = new BusinessLayerClass(drc);
            
            if (answer.CompareTo("yes") == 0)
            {
                List<StoreClass> stores = blc.StoreClassList();
                foreach (StoreClass s in stores)
                {
                    Console.WriteLine($"Store {s.StoreName}");
                }
            }






        }
    }
}


// Sign in or Sign Up- loop
//Ask to view store list - What store would you like to shop at? (menu from sql) switch case, 
//show store list menu, products in chosen store from user.
//Afterwards let customer add to cart and switch between stores.
//add more than 1 product but no more than $500 total cost and 50 items 
//view current cart then return to shopping 
//cancel purchase even with items in cart
//checkout & log to past purchases and 
//view past purchases (date of purchase,item id, item name, quantity, & total cost)