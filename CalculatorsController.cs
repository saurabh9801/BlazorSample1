using CalculatorWebAPI.Models;
using CalculatorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorsController : ControllerBase
    {
        private readonly ICalculatorService calculatorService;

        public CalculatorsController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }
        // GET: api/<CalculatorsController>
        [HttpGet]
        public ActionResult<List<Calculator>> Get()
        {
            return calculatorService.GetCalculators();
        }

        // GET api/<CalculatorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Calculator> Get(int id)
        {
            var cal = calculatorService.GetCalculator(id);
            if(cal == null)
            {
                return NotFound($"Calculator with Id ={id} not found");
            }
            return cal;
        }

        // POST api/<CalculatorsController>
        [HttpPost]
        public ActionResult<Calculator> Post([FromBody] Calculator calculator)
        {
            calculatorService.Create(calculator);
            return CreatedAtAction(nameof(Get), new { id = calculator.Id }, calculator);

        }

        // PUT api/<CalculatorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculatorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
