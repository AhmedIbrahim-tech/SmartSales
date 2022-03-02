using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }
        public string? Client_Name { get; set; }
        public string? Client_Phone { get; set; }
        public string? Client_IDCard { get; set; }
        public string? Client_Address { get; set; }
        public string? Client_Address_Work { get; set; }
    }
}
