using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController: Controller
    {
        private IDataRepository _DataRepository;
        public MyController(IDataRepository dataRepository)
        {
            _DataRepository = dataRepository;

        }
        //api/my
        [HttpPost]
            public IActionResult CreateData([FromBody] Data datatocreat)
            {
                if (datatocreat == null)
                    return BadRequest(modelState);
                if(!_DataRepository.CreateData(datatocreat))
            {
                ModelState.AddModelError("", $"Something went wrong");
                return StausCode(500, ModelState);

            }
            return Ok();


            }
        

    }
}
