using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
    public class TeaMenu
    {
        
        public int Id { get; set; }
        public string? TeaName { get; set; }

        [Column(TypeName="decimal(5,2)")]
        public decimal TeaPrice { get; set; }

        public string? TeaDescription { get; set; }


        public bool DisableData { get; set; }
    }
}
