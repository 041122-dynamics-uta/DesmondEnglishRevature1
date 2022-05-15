using System.Data.SqlClient;
using DigitalRecordStoreModel;
using System;

namespace Repo
{
    public class DigitalMapperClass
    {
        public CustomerClass DboToCustomer(SqlDataReader reader)
        {
            CustomerClass c = new CustomerClass
            {
                CustomerID = (int)reader[0],
                Fname = (string)reader[1],
                Lname = (string)reader[2],
                Email = (string)reader[3],
                UserName = (string)reader[4],
                Pswd = (byte)reader[5],
                DateCreated = (DateTime)reader[6],

            };
            return c;
        }

        public ProductClass DboToProduct(SqlDataReader reader)
        {
            ProductClass p = new ProductClass
            {
                ProductID = (int)reader[0],
                Name = (string)reader[1],
                Price = (int)reader[2],
                Description = (string)reader[3],
                Quantity = (int)reader[4],
                StoreID = (int)reader[5],
                Artist = (string)reader[6],

            };
            return p;
        }

        public StoreClass DboToStore(SqlDataReader reader)
        {
            StoreClass s = new StoreClass
            {
                StoreID = (int)reader[0],
                StoreName = (string)reader[1],
                Location = (string)reader[2],
                Inventory = (int)reader[3],
            };
            return s;
        }

        public InventoryClass DboToInventory(SqlDataReader reader)
        {
            InventoryClass i = new InventoryClass
            {
                InventoryID = (int)reader[0],
                InventoryNumber = (int)reader[1],
                ProductID = (int)reader[2],


            };
            return i;
        }

        public OrdersClass DboToOrders(SqlDataReader reader)
        {
            OrdersClass o = new OrdersClass
            {
                OrderID = (int)reader[0],
                PurchaseDate = (DateTime)reader[1],
                Quantity = (int)reader[2],
                TotalCost = (int)reader[3],
                CustomerID = (int)reader[4],
                ProductID = (int)reader[5],
                StoreID = (int)reader[6],
            };
            return o;
        }

        public OrderHistoryClass DboToOrderHistory(SqlDataReader reader)
        {
            OrderHistoryClass oh = new OrderHistoryClass
            {
                OrderHistoryId = (int)reader[0],
                TotalPrice = (int)reader[1],
                DateCreated = (DateTime)reader[2],
                OrderId = (int)reader[3],
            };
            return oh;
        }
    }   

}