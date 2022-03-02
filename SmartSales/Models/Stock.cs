using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Stock
    {
        [Key]
        public int Stock_ID { get; set; }
        public string? Stock_Name { get; set; }
        public string? Stock_Address { get; set; }
        public string? Stock_Official { get; set; }
        public string? Stock_Phone { get; set; }
        public string? Stock_Description { get; set; }
    }
}
