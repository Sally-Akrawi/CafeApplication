using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
    public class FoodMenu
    {
        public int Id { get; set; }
        [Required]
        public string FoodName { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal FoodPrice { get; set; }

        public bool DisableData { get; set; }
    }
}
