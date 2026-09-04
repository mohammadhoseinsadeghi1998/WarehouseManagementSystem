using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Models
{
    internal class Supplier
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        public string CompanyName { get; set; }

        [MaxLength(100)]
        public string ContactPerson { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
