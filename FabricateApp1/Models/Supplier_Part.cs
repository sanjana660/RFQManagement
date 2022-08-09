using System.ComponentModel.DataAnnotations.Schema;

namespace FabricateApp1.Models
{
    public class Supplier_Part
    {
        public int id { get; set; }
        public int partid { get; set; }
        public string partname { get; set; }
        public int quantity { get; set; }
        public int timeperiod { get; set; }

        [ForeignKey("Supplier")]
        public int sid { get; set; }

    }
}
