using System.Data.SqlClient;
namespace DigitalRecordStoreModel
{
    public class StoreClass
    {
        public int StoreID { get; set; } = 0;
        public string? StoreName { get; set; } = "";
        public string? Location { get; set; } = "";
        public int Inventory { get; set; } = 0;
    }
}