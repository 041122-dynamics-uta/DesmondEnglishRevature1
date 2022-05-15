using System.Data.SqlClient;
namespace DigitalRecordStoreModel
{
    public class OrdersClass
    {
        public int OrderID { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public int TotalCost { get; set; } = 0;
        public int CustomerID { get; set; } = 0;
        public int ProductID { get; set; } = 0;
        public int StoreID { get; set; } = 0;
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}