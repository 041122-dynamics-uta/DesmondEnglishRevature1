using System.Data.SqlClient;
namespace DigitalRecordStoreModel
{
    public class OrderHistoryClass
    {
        public int OrderHistoryId { get; set; } = 0;
        public int TotalPrice { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int OrderId { get; set; } = 0;
    }
}