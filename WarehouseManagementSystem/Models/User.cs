using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Models
{
    internal class User
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        public string Password { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        public bool IsActive { get; set; } = true;

        [MaxLength(20)]
        public string Role { get; set; }
    }
}
