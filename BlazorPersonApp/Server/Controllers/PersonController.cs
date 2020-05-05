using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPersonApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPersonApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople() 
        {
            return new List<PersonModel>()
            {
                new PersonModel{ FirstName = "Joku", LastName = "Binudl", AccountBalance = 19.45M },
                new PersonModel{ FirstName = "Oioa", LastName = "Twkjs", AccountBalance = 9.23M },
                new PersonModel{ FirstName = "Binqua", LastName = "Luuas", AccountBalance = 17.2M },
                new PersonModel{ FirstName = "Laosw", LastName = "Quias", AccountBalance = 10.56M },
            };
        }

        [HttpPost]
        public void Post (PersonModel person)
        {

        }
    }
}