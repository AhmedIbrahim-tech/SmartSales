using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }
        public string? Supplier_Name { get; set; }
        public string? Supplier_Phone { get; set; }
        public string? Company_ID { get; set; }
    }
}
