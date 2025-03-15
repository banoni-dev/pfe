using back.Models;
using back.Repositories;
using System;
using System.Collections.Generic;

namespace back.Services
{
    public class TierService : ITierService
    {
        private readonly ITierRepository _tierRepository;
        private readonly IProductRepository _productRepository; // Add this line

        public TierService(ITierRepository tierRepository, IProductRepository productRepository) // Update constructor
        {
            _tierRepository = tierRepository;
            _productRepository = productRepository; // Initialize _productRepository
        }

        public TierModel GetTierById(int id)
        {
            return _tierRepository.GetTierById(id);
        }

        public TierModel GetTierByName(string name)
        {
            return _tierRepository.GetTierByName(name);
        }

        public List<TierModel> GetTiersByProductId(int productId)
        {
            return _tierRepository.GetTiersByProductId(productId);
        }

        public List<TierModel> GetAllTiers()
        {
            return _tierRepository.GetAllTiers();
        }

        public TierModel CreateTier(TierModel tier)
        {
            // Check if a tier with the same name already exists
            if (_tierRepository.GetTierByName(tier.Name) != null)
                throw new Exception("Tier with the same name already exists");

            // Ensure the product exists
            var product = _productRepository.GetProductById(tier.ProductId);
            if (product == null)
                throw new Exception("Product not found");

            return _tierRepository.CreateTier(tier);
        }

        public TierModel UpdateTier(int id, TierModel updatedTier)
        {
            return _tierRepository.UpdateTier(id, updatedTier);
        }

        public void DeleteTier(int id)
        {
            _tierRepository.DeleteTier(id);
        }
    }
}
