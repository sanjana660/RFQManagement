using PlantMicroservice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlantMicroservice.Repository
{
    public interface IPlantRepo
    {
        Task<List<PlantReorderDetails>> ViewPartsReOrder();
        Task<Part> ViewStockInHand(int partId);
        Task<string> UpdateMinMax(int min, int max, int id);
    }
}
