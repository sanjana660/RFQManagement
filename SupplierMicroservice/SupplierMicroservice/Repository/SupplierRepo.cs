using Microsoft.EntityFrameworkCore;
using SupplierMicroservice.DbaseContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierMicroservice.Repository
{
    public class SupplierRepo : ISupplierRepo
    {
        private readonly SupplierContext _context;
        public SupplierRepo(SupplierContext con)
        {
            _context = con;
        }
        public async Task<List<Supplier>> AddSupplier(Supplier sup)
        {
            _context.Suppliers.Add(sup);
            await _context.SaveChangesAsync();

            return (await _context.Suppliers.ToListAsync());
        }
        public Task<List<Supplier>> GetSupplierOfPart(int id)
        {
            List<Supplier> lsupplier = _context.Suppliers.ToList();
            List<Supplier_Part> lsupplier_part = _context.Supplier_Parts.ToList();
            var query = from s in lsupplier
                        join sp in lsupplier_part on s.supplier_id equals sp.sid
                        where sp.partid == id
                        select new { s.supplier_id, s.name, s.location, sp.quantity, sp.timeperiod };
            return ((Task<List<Supplier>>)query);
        }

        public async Task<List<Supplier>> UpdateFeedback(Supplier request)
        {
            var dbSup = await _context.Suppliers.FindAsync(request.supplier_id);
            //if (dbSup == null)
            //    return BadRequest("Hero not found.");

            dbSup.feedback = request.feedback;

            await _context.SaveChangesAsync();

            return (await _context.Suppliers.ToListAsync());
        }

        public async Task<List<Supplier>> UpdateSupplier(Supplier request)
        {
            var dbSup = await _context.Suppliers.FindAsync(request.supplier_id);
            if (dbSup != null)
            {
                //return NotFound("Hero not found.");
                dbSup.name = request.name;
                dbSup.location = request.location;
                dbSup.feedback = request.feedback;
                dbSup.email = request.email;
                dbSup.phone = request.phone;

                await _context.SaveChangesAsync();

                return (await _context.Suppliers.ToListAsync());
            }
            return new List<Supplier>();
        }
    }
}