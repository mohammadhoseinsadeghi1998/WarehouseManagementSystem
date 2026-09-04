using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Models
{
    internal class Category
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}
