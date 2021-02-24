namespace Focus.RandomGenerator.Service
{
    using FocusRandomGenerator.DataEntities;
    using FocusRandomGenerator.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    /// <summary>
    /// RandomNumberService
    /// </summary>
    public class RandomNumberService : IRandomNumberService
    {
        /// <summary>
        /// RandonNumberLimit
        /// </summary>
        private readonly int RandonNumberLimit = 49;

        /// <summary>
        /// Business Rules
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetColorCoding(int value)
        {
            if (value < 10)
                return Color.Gray.Name;
            else if (value < 20)
                return Color.Blue.Name;
            else if (value < 30)
                return Color.Pink.Name;
            else if (value < 40)
                return Color.Green.Name;
            else if (value < 50)
                return Color.Yellow.Name;
            else
                return Color.Black.Name;
        }

        /// <summary>
        /// RandomGenerator
        /// </summary>
        /// <param name="noOfNumbers"></param>
        /// <returns></returns>
        public int[] RandomGenerator(int noOfNumbers)
        {
            var generatedRandonNumber = RandomGeneratorwithColorCodes(noOfNumbers);
            var onlylist = generatedRandonNumber.RandonNumbers.OrderBy(n => n.Number).Select(s => s.Number).ToArray();

            return onlylist;
        }

        /// <summary>
        /// RandomGeneratorwithColorCodes
        /// </summary>
        /// <param name="noOfNumbers"></param>
        /// <returns></returns>
        public GeneratedRandonNumber RandomGeneratorwithColorCodes(int noOfNumbers)
        {
            //Init the GeneratedRandonNumber
            GeneratedRandonNumber generatedRandonNumber = new GeneratedRandonNumber();
            generatedRandonNumber.GeneratorDateTime = DateTime.Now;
            List<NumberInfo> listofNumbers = new List<NumberInfo>();

            //Generates the Random number
            Random RandomClass = new Random();
            int randomNumber;

            for (int i = 0; i < noOfNumbers; i++)
            {
                do
                {
                    randomNumber = RandomClass.Next(1, RandonNumberLimit);
                }
                    while (listofNumbers.Any(n => n.Number == randomNumber));

                listofNumbers.Add(new NumberInfo
                {
                    Number = randomNumber,
                    ColorName = generatedRandonNumber.ColorCodingRange.FindLast(c => randomNumber >= c.LowerLimit).Color
                });
            }

            // orders the random numbers
            generatedRandonNumber.RandonNumbers = listofNumbers.OrderBy(n => n.Number).Select(n => new NumberInfo
            {
                Number = n.Number,
                ColorName = n.ColorName
            }).ToList();

            return generatedRandonNumber;
        }
    }
}
