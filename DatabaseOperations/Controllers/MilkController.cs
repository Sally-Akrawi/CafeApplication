using DatabaseOperations.Models;
using DatabaseOperations.Services;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseOperations.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MilkController : ControllerBase
    {
        private readonly IDataService _dataService;

        public MilkController(IDataService dataService)
        {
            _dataService = dataService;
        }
        /// <summary>
        /// To call the ReadMilkTable method from the Dataservices and get the list
        /// </summary>
        /// <returns list></returns>
        [HttpGet]
        public async Task<List<MilkType>> Get()
        {
            return await _dataService.ReadMilkTable();
        }

        /// <summary>
        /// To call the CreateMilk method from the Dataservices and add new milk item
        /// </summary>
        /// <param name="milk"></param>
        /// <returns int></returns>
        [HttpPost]
        public async Task<int> PostMilk(MilkType milk)
        {
            return await _dataService.CreateMilk(milk);
        }

        /// <summary>
        /// To call the DeleteMilk method from the Dataservices and delete milk item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public async Task Delete([FromBody] int id)
        {
            await _dataService.DeleteMilk(id);
        }

      

        /// <summary>
        /// To call UpdateMilk function to update the milk item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        [HttpPost ("doupdate")]
        public async Task<ActionResult<MilkType>> Update(MilkType milk)
        {
            var res =  await _dataService.UpdateMilk_New(milk);
            if (res > 0)
            {
                return Ok(res);
            }
            return NotFound();
            

        }


        /// <summary>
        /// To get milk by id by calling MilkCustomerDetails function
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("getmilk/{id}")]
        public async Task<ActionResult<MilkType>> GetById(int id)
        {
           var obj =  await _dataService.MilkCustomerDetails(id);
            return Ok(obj);
           
        }
    }  
    
}
