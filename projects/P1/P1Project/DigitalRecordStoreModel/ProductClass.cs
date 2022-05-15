using System.Data.SqlClient;

namespace DigitalRecordStoreModel
{
    public class ProductClass
    {
        public int? ProductID { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Price { get; set; } = 0;
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public int StoreID { get; set; } = 0;
        public string Artist { get; set; } = "";
    }
}