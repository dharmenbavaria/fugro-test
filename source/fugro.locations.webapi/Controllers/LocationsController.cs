using Fugro.Locations.Dto;
using Fugro.Locations.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Fugro.Locations.Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class LocationsController : ControllerBase
    {
        private static readonly InMemoryLocationRepository m_LocationRepository = new();

        public LocationsController()
        {
        }

        [HttpGet]
        public ActionResult<Location> Get()
        {
            Location storedLocation = m_LocationRepository.GetLocation();
            ActionResult<Location> result = Ok(storedLocation);

            return result;
        }

        [HttpPost]
        public ActionResult<Location> Post(Location location)
        {
            m_LocationRepository.SetLocation(location);
            ActionResult<Location> result = CreatedAtAction(nameof(Get), location);

            return result;
        }
    }
}
