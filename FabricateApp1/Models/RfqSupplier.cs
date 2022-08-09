using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FabricateApp1.Models
{
    public class RfqSupplier
    {
        [Key]
        public int Part_id { get; set; }
        public int Supplier_id { get; set; }
        public string Supplier_Name { get; set; }
        public string Location { get; set; }
        public int Feedback { get; set; }

        public RfqSupplier()
        {
            var rfq = new HashSet<Rfq>();
        }
    }
}
