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
        public string Post([FromBody] int idMovie, int idCustomer)
        { return _locationServices.Add(idMovie,idCustomer); }

        [HttpPost()]
        public string Devolution([FromBody] int idMovie, int idCustomer)
        {
            return _locationServices.Devolution(idMovie, idCustomer);
        }
    }

    public interface ILocationController
    {
         string Post(int idMovie, int idCustomer);
        string Devolution(int idMovie, int idCustomer);
        

    }
}
