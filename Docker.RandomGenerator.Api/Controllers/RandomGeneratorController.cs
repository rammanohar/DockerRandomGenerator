namespace FocusRandonGenerator.Api.Controllers
{

    using FocusRandomGenerator.Interface;
    using Microsoft.AspNetCore.Mvc;
    /// <summary>
    /// RandomGeneratorController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RandomGeneratorController : ControllerBase
    {

        private readonly IRandomNumberService RandomNumberService;

        /// <summary>
        /// RandomGeneratorController constructor
        /// </summary>
        /// <param name="numberService"></param>
        public RandomGeneratorController(IRandomNumberService numberService)
        {
            this.RandomNumberService = numberService;
        }

        /// <summary>
        /// GetRandomNumber
        /// </summary>
        /// <returns></returns>
        [HttpGet("Numbers")]
        public IActionResult GetRandomNumber()
        {
            var result = RandomNumberService.RandomGenerator(6);

            return Ok(result);

        }

        /// <summary>
        /// CustomNumbers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("CustomNumbers")]
        public IActionResult GetRandomNumber(int id)
        {
            var result = RandomNumberService.RandomGenerator(id);

            return Ok(result);

        }

        /// <summary>
        /// GetNumberByColor
        /// </summary>
        /// <returns></returns>
        [HttpGet("NumbersByColor")]
        public IActionResult GetNumberByColor()
        {
            int randomNumbers = 6;
            var result = RandomNumberService.RandomGeneratorwithColorCodes(randomNumbers);
            return Ok(result);

        }

        /// <summary>
        /// CustomNumbersByColor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("CustomNumbersByColor")]
        public IActionResult GetNumberByColor(int id)
        {
            var result = RandomNumberService.RandomGeneratorwithColorCodes(id);
            return Ok(result);

        }
    }
}
