namespace FocusRandonGenerator.WebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FocusRandonGenerator.WebApp.Models;
    using FocusRandonGenerator.WebApp.Service.Interface;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// RandomNumberController
    /// </summary>
    public class RandomNumberController : Controller
    {
        private INumberService NumberService;

        /// <summary>
        /// RandomNumberController constructor
        /// </summary>
        /// <param name="numberService"></param>
        /// <param name="store"></param>
        public RandomNumberController(INumberService numberService)
        {
            this.NumberService = numberService;
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var generatedRandonNumber = NumberService.GetNumbersByColor();


            return View(generatedRandonNumber);
        }

        /// <summary>
        /// CustomRandomNumber
        /// </summary>
        /// <returns></returns>
        public IActionResult CustomRandomNumber()
        {
            GeneratedRandonNumber generatedRandonNumber = new GeneratedRandonNumber();

            return View(generatedRandonNumber);
           
        }

        /// <summary>
        /// CustomRandomNumber
        /// </summary>
        /// <param name="generatedRandonNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CustomRandomNumber(GeneratedRandonNumber generatedRandonNumber)
        {

            generatedRandonNumber = NumberService.GetCustomNumbersByColor(generatedRandonNumber.NoofRandomnumbers);

            return View(generatedRandonNumber);

        }
    }
}
