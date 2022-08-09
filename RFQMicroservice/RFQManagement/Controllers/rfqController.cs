using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RFQManagement.DbaseContext;
using RFQManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFQManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rfqController : ControllerBase
    {
        private readonly RFQDbContext _context;
        public rfqController(RFQDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetRFQ")]
        public async Task<ActionResult<List<Rfq>>> GetRFQ()
        {
            List<Rfq> lrfq = _context.Rfq.ToList();
            var query = from r in lrfq
                        select new { r.rfqId, r.partName, r.demandid, r.Specification, r.Quantity, r.timetoSupply };
            return Ok(query);
        }
        [HttpGet("Id")]
        public async Task<ActionResult<Rfq>> Get(int Id)
        {
            var rec = await _context.Rfq.Where(x => x.Part_Id == Id).Select(x => new Rfq()
            {
                rfqId = x.rfqId,
                partName = x.partName,
                demandid = x.demandid,

                Specification = x.Specification,
                //Part_Id =x.Part_Id,
                Quantity = x.Quantity,
                timetoSupply = x.timetoSupply
            }).ToListAsync();

            return Ok(rec);
        }
        [HttpGet("GetFeedback")]
        public async Task<ActionResult<Supplier>> GetFeedback(int rId)
        {
            List<Rfq> rfq = _context.Rfq.ToList();
            List<Supplier> supplier = _context.SUPPLIER.ToList();
            {
                var rfqViewModel = from s in supplier
                                   join r in rfq on s.Part_id equals r.Part_Id
                                   where r.rfqId == rId && s.Feedback > 7
                                   select new { s.Part_id, r.rfqId, s.Supplier_Name, s.Feedback };
                return Ok(rfqViewModel);
            }

        }
    }
}
