using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseOperations.Models
{
	public class DrinkMenu
	{
        public int Id { get; set; }
        public string? DrinkName { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal DrinkPrice { get; set; }

        public string? DrinkDescription { get; set; }


        public bool DisableData { get; set; }
    }
}
