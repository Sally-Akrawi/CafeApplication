using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
    public class MilkType
    {
        
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        [Required]
        public string? Description { get; set; }

        public bool DisableData { get; set; }    
    }
}
