﻿using Microsoft.AspNetCore.Mvc;
using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore; 

namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly RideDbContext _context;
        public LocationController(RideDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _context.Locations.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return Ok(location);
        }
    }

}
