using Microsoft.AspNetCore.Mvc;
using SumPI.Model;
using SumPI.Services;
using System;

namespace SumPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculateController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        /// <summary>
        /// Calculates the Pi number with the predefined function.
        /// </summary>
        /// <param name="calculateModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Pi(CalculateModel calculateModel)
        {

            if (calculateModel != null && calculateModel.IterationCount >= 0)
            {
                try
                {
                    decimal result = _calculatorService.CalculatePi(calculateModel);

                    return Ok(result);
                }
                catch (ArgumentException argumentException)
                {
                    return BadRequest(argumentException.Message);
                }
                catch (Exception exception)
                {
                    return StatusCode(500, "An error occurred!");
                }
            }
            else
            {
                return StatusCode(400, "The Model is not valid!");

            }
        }

    }
}
