using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Services;
using Application.ViewModel;

namespace MenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodServices _foodServices;

        public FoodController(IFoodServices foodServices)
        {
            _foodServices = foodServices;
        }

        // GET: api/Food
        [HttpGet]
        public async Task<IEnumerable<FoodViewModel>> GetDishes()
        {
            return _foodServices.GetAll().OrderBy(_ => _.Name);
        }

        // GET: api/Food/5
        [HttpGet("{id}")]
        public async Task<FoodViewModel> GetById(Guid id)
        {
            return _foodServices.GetById(id);
        }

        // PUT: api/Food/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] FoodViewModel vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var dish = _foodServices.Update(vm);
            return Ok(dish);
        }

        // POST: api/Food
        [HttpPost]
        public async Task<ActionResult<FoodViewModel>> Add([FromBody] FoodViewModel vm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var cia =  _foodServices.Add(vm);
            return Ok(cia);
        }

        // DELETE: api/Food/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {   
            if (!ModelState.IsValid) return BadRequest();
            var status = _foodServices.Remove(id);
            return Ok(status);
        }
    }
}
