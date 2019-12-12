
using System.Collections.Generic;
using System.Threading.Tasks;
using CarsAPI.Database;
using Microsoft.AspNetCore.Mvc;


namespace CarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StolenCarsController : ControllerBase
   
    {
        private FakeCarsDatabase _fakeDatabase;
      
     
        public StolenCarsController()
        {
            _fakeDatabase = new FakeCarsDatabase();
        }
        


       



    }
}