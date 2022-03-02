using System.ComponentModel.DataAnnotations;

namespace SmartSales.Models
{
    public class Campany
    {
        [Key]
        public int Campany_Id { get; set; }
        public string Campany_Name { get; set; }
        public string Campany_Owner { get; set; }
        public string Campany_Phone { get; set; }
        public string Campany_Address { get; set; }
        public DateTime Campany_Date { get; set; }
        public string Campany_Description { get; set; }


    }
}
