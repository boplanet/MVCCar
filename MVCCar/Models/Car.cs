using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        //  [DataType(DataType.Date)]
        //   public DateTime ProductionYear { get; set; }
        public int ProductionYear { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(typeof(decimal), "0,00", "9999999999999999,99", ErrorMessage = "Cijena može biti do 18 i 2 decimalna mjesta.")]
        public decimal Price { get; set; }

    }
}
