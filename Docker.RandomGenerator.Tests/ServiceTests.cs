namespace Focus.RandomGenerator.Tests
{
    using Focus.RandomGenerator.Service;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    /// <summary>
    /// ServiceTests 
    /// </summary>
    [TestClass]
    public class ServiceTests
    {
        [TestInitialize]
        public void Setup()
        {

        }

        /// <summary>
        /// Test for Generate correct number of numbers
        /// </summary>
        [TestMethod]
        public void TestNoofRandomNumbers()
        {
            int NoofRandomNumbers = 8;
            RandomNumberService testService = new RandomNumberService();
            var result = testService.RandomGeneratorwithColorCodes(NoofRandomNumbers);
            Assert.AreEqual(result.RandonNumbers.Count, NoofRandomNumbers);
        }


        /// <summary>
        /// Test for Generate correct number of numbers
        /// </summary>
        [TestMethod]
        public void TestDistinctRandomNumbers()
        {
            int NoofRandomNumners = 6;
            RandomNumberService testService = new RandomNumberService();
            var result = testService.RandomGeneratorwithColorCodes(NoofRandomNumners);
            int distinctCount = result.RandonNumbers.Distinct().Count();
            Assert.AreEqual(distinctCount, NoofRandomNumners);
        }
    }
}
