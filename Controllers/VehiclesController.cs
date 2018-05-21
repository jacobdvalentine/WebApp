using Microsoft.AspNetCore.Mvc;
using vega.Models;

namespace vega.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {

        // Create action for creating a vehicle
        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(vehicle);
        }
    }
}