using Fugro.Locations.Dto;
using Fugro.Locations.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fugro.Locations.Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class LocationsController : ControllerBase
    {
        private readonly LocationRepository m_LocationRepository;

        public LocationsController()
        {
            m_LocationRepository = new LocationRepository();
        }

        [HttpGet]
        public ActionResult<Location> Get()
        {
            return m_LocationRepository.GetLocation();
        }

        [HttpPost]
        public ActionResult<Location> Post(Location location)
        {
            m_LocationRepository.SetLocation(location);

            return CreatedAtAction(nameof(Get), location);
        }
    }
}
