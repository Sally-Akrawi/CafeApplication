using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
	public class ToppingMenu
	{
        public int Id { get; set; }
        public string? ToppingName { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal ToppingPrice { get; set; }

        public string? ToppingDescription { get; set; }


        public bool DisableData { get; set; }

    }
}
