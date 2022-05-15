using System.Data.SqlClient;
namespace DigitalRecordStoreModel
{
    public class InventoryClass
    {
        public int InventoryID { get; set; } = 0;
        public int InventoryNumber { get; set; } = 0;
        public int ProductID { get; set; } = 0;
        public int StoreID { get; set; }  = 0;

    }
}