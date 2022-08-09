using RFQManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RFQManagement.Repository
{
    public interface IrfqRepo
    {
        Task<List<Rfq>> Get(int Id);
        Task<Rfq> GetFeedback(int rId);
    }
}
