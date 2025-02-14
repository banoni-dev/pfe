using back.Models;
using System.Collections.Generic;

namespace back.Repositories
{
    public interface ITierRepository
    {
        TierModel GetTierById(int id);
        TierModel GetTierByName(string name);
        List<TierModel> GetTiersByProductId(int productId);
        List<TierModel> GetAllTiers();
        TierModel CreateTier(TierModel tier);
        TierModel UpdateTier(int id, TierModel updatedTier);
        void DeleteTier(int id);
    }
}
