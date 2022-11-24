using System.Collections.Generic;
using Fugro.Locations.Dto;
using Fugro.Locations.Services;
using Fugro.Locations.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Fugro.Locations.Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        [Route("device/{id}")]
        public ActionResult<IReadOnlyList<Location>> Get(int id)
        {
            var locationsOfDevice = _locationService.GetLocationsOfDevice(id);
            return Ok(locationsOfDevice); ;
        }

        [HttpPost]
        public ActionResult<Location> Post(Location location)
        {
            //m_LocationRepository.SetLocation(location);
            ActionResult<Location> result = CreatedAtAction(nameof(Get), location);

            return result;
        }
    }
}
