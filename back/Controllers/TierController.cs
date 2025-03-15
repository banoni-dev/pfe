using Microsoft.AspNetCore.Mvc;
using back.Models;
using back.Services;
using System;

namespace back.Controllers
{
    [ApiController]
    [Route("api/tier")]
    public class TierController : ControllerBase
    {
        private readonly ITierService _tierService;

        public TierController(ITierService tierService)
        {
            _tierService = tierService;
        }

        // GET: api/tier/id/{id}
        [HttpGet("id/{id}")]
        public IActionResult GetTierById(int id)
        {
            try
            {
                var tier = _tierService.GetTierById(id);
                return tier != null ? Ok(tier) : NotFound(new { message = "Tier not found" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET: api/tier/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetTierByName(string name)
        {
            try
            {
                var tier = _tierService.GetTierByName(name);
                return tier != null ? Ok(tier) : NotFound(new { message = "Tier not found" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET: api/tier/product/{productId}
        [HttpGet("product/{productId}")]
        public IActionResult GetTiersByProductId(int productId)
        {
            try
            {
                var tiers = _tierService.GetTiersByProductId(productId);
                return Ok(tiers);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // GET: api/tier/all
        [HttpGet("all")]
        public IActionResult GetAllTiers()
        {
            try
            {
                var tiers = _tierService.GetAllTiers();
                return Ok(tiers);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // POST: api/tier
        [HttpPost]
        public IActionResult CreateTier([FromBody] TierModel tier)
        {
            try
            {
                var createdTier = _tierService.CreateTier(tier);
                return CreatedAtAction(nameof(GetTierById), new { id = createdTier.Id }, createdTier);
            }
            catch (Exception ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }

        // PUT: api/tier/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTier(int id, [FromBody] TierModel updatedTier)
        {
            try
            {
                var tier = _tierService.UpdateTier(id, updatedTier);
                return Ok(tier);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        // DELETE: api/tier/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTier(int id)
        {
            try
            {
                _tierService.DeleteTier(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
