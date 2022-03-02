using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string? Category_Name { get; set; }
    }
}
