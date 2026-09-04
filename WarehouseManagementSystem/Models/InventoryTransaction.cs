
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagementSystem.Models
{
    public enum TransactionType
    {
        In = 1, // ورود کالا
        Out = 2 // خروج کالا
    }

    internal class InventoryTransaction
    {
        [Key]
        public int ID { get; set; }

        public TransactionType Type { get; set; }

        public int Quantity { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [MaxLength(250)]
        public string Description { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }

        public int? SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
    }
}
