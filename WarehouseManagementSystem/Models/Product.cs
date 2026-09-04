using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagementSystem.Models
{
    internal class Product
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public String Code { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        public int MinStockLevel { get; set; }

        //روابط
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
