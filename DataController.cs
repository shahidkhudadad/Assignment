using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController:Controller
    {
        private IDataRepository _dataRepository;
        public DataController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //api/data
        [HttpGet]
        public IActionResult GetData()
        {
            var data = _dataRepository.GetAllData();
            return OK(data);
        }

        //api/data
        [HttpPost]
        public IActionResult Createdata([FromBody] Data dataToCreate)
        {
            if (dataToCreate == null)
                return BadRequest(ModelState);
            if (!_dataRepository.CreateData(dataToCreate))
                return StatusCode(500);

        }
    }

    
}
