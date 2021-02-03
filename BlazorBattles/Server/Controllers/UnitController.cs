using System.Collections.Generic;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {

        public IList<Unit> Units { get; } = new List<Unit>
        {
            new Unit {Id = 1, Title = "Warrior", Attack = 10, Defense = 10, FoodCost = 100},
            new Unit {Id = 2, Title = "Ranger", Attack = 15, Defense = 5, FoodCost = 150},
            new Unit {Id = 3, Title = "Wizard", Attack = 30, Defense = 0, FoodCost = 200}
        };
        
        [HttpGet]
        public IActionResult GetUnits()
        {
            return Ok(Units);
        }
    }
}