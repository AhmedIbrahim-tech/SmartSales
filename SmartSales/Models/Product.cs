using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }
        public string? Product_Barcode { get; set; }
        public string? Product_Name { get; set; }
        public int Category_ID { get; set; }
        public int Stock_ID { get; set; }
        public string? Product_BuyPrice { get; set; }
        public string? Product_SellPrice { get; set; }
        public int Product_Quantity { get; set; }
        public int Limited_Number { get; set; }
        public DateTime Product_Date { get; set; }
        public string? Product_Description { get; set; }
    }
}
