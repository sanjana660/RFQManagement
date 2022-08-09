using Microsoft.EntityFrameworkCore;
using RFQManagement.DbaseContext;
using RFQManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFQManagement.Repository
{
    public class rfqRepo : IrfqRepo
    {
        private readonly RFQDbContext _context;
        public rfqRepo(RFQDbContext context)
        {
            _context = context;

        }
        public async Task<List<Rfq>> Get(int Id)
        {
            var rec = await _context.Rfq.Where(x => x.Part_Id == Id).Select(x => new Rfq()
            {
                rfqId = x.rfqId,
                demandid = x.demandid,
                Part_Id = x.Part_Id,
                partName = x.partName,
                Quantity = x.Quantity,
                timetoSupply = x.timetoSupply,
                Specification = x.Specification
            }).ToListAsync();
            return rec;
        }

        public Task<Rfq> GetFeedback(int rId)
        {
            List<Rfq> rfq = _context.Rfq.ToList();
            List<Supplier> supplier = _context.SUPPLIER.ToList();
            {

                var rfqViewModel = from s in supplier
                                   join r in rfq on s.Part_id equals r.Part_Id
                                   where r.rfqId == rId && s.Feedback > 7
                                   select new { s.Part_id, r.rfqId, s.Supplier_Name, s.Feedback };


                return (Task<Rfq>)rfqViewModel;
            }
        }
    }
}
