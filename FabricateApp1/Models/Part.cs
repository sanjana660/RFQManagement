using System.ComponentModel.DataAnnotations;

namespace FabricateApp1.Models
{
    public class Part
    {
        [Key]
        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public string PartSpecification { get; set; }
        public int StockInHand { get; set; }
    }
}
