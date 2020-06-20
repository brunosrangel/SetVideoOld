using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using setVideo.Model;
using setVideo.Service;

namespace setVideo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class LocationController : Controller , ILocationController
    {
        private readonly ILocationServices _locationServices;
        public LocationController(ILocationServices locationService)
        {
            _locationServices = locationService;
        }
      

        [HttpPost()]
        public string Post([FromBody] Location location)
        { return _locationServices.Add(location); }

        [HttpPost()]
        public string Devolution([FromBody] Location location)
        {
            return _locationServices.Devolution(location);
        }
    }

    public interface ILocationController
    {
         string Post(Location location);
        

    }
}
