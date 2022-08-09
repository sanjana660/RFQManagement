﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupplierMicroservice.Repository
{
    public interface ISupplierRepo
    {
        Task<List<Supplier>> GetSupplierOfPart(int id);
        Task<List<Supplier>> AddSupplier(Supplier sup);
        Task<List<Supplier>> UpdateSupplier(Supplier request);
        Task<List<Supplier>> UpdateFeedback(Supplier request);
    }
}
