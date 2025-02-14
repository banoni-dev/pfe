using back.Models;
using back.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace back.Repositories
{
    public class TierRepository : ITierRepository
    {
        private readonly Db _db;

        public TierRepository(Db db)
        {
            _db = db;
        }

        public TierModel GetTierById(int id)
        {
            return _db.Tiers.FirstOrDefault(t => t.Id == id);
        }

        public TierModel GetTierByName(string name)
        {
            return _db.Tiers.FirstOrDefault(t => t.Name == name);
        }

        public List<TierModel> GetTiersByProductId(int productId)
        {
            return _db.Tiers.Where(t => t.ProductId == productId).ToList();
        }

        public List<TierModel> GetAllTiers()
        {
            return _db.Tiers
                     .Include(t => t.Product)
                     .ToList();
        }

        public TierModel CreateTier(TierModel tier)
        {
          // Ensure the product exists
          var product = _db.Products.FirstOrDefault(p => p.Id == tier.ProductId);
          if (product == null)
            throw new Exception("Product not found");

          _db.Tiers.Add(tier);
          _db.SaveChanges();
          return tier;
        }

        public TierModel UpdateTier(int id, TierModel updatedTier)
        {
            var tier = _db.Tiers.FirstOrDefault(t => t.Id == id);
            if (tier == null)
                throw new Exception("Tier not found");

            tier.Name = updatedTier.Name;
            tier.Price = updatedTier.Price;
            tier.MaxDevices = updatedTier.MaxDevices;
            tier.Duration = updatedTier.Duration;
            tier.ProductId = updatedTier.ProductId;

            _db.SaveChanges();
            return tier;
        }

        public void DeleteTier(int id)
        {
            var tier = _db.Tiers.FirstOrDefault(t => t.Id == id);
            if (tier == null)
                throw new Exception("Tier not found");

            _db.Tiers.Remove(tier);
            _db.SaveChanges();
        }
    }
}
