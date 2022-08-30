using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
    public class SyrupMenu
    {
        
            public int Id { get; set; }
            public string? SyrupName { get; set; }

            [Column(TypeName = "decimal(5,2)")]
            public decimal SyrupPrice { get; set; }

            public string? SyrupDescription { get; set; }

        public bool DisableData { get; set; }

    }
}
