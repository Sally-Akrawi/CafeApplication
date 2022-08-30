using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
	public class SweetenerMenu
	{
        public int Id { get; set; }
        public string? SweetenerName { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal SweetenerPrice { get; set; }

        public string? SweetenerDescription { get; set; }

        public bool DisableData { get; set; }
    }
}
