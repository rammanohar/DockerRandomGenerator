namespace FocusRandomGenerator.Interface
{
    using FocusRandomGenerator.DataEntities;

    /// <summary>
    /// IRandomNumberService
    /// </summary>
    public interface IRandomNumberService
    {
        /// <summary>
        /// RandomGenerator
        /// </summary>
        /// <param name="noOfNumbers"></param>
        /// <returns></returns>
        int[] RandomGenerator(int noOfNumbers);

        /// <summary>
        /// RandomGeneratorwithColorCodes
        /// </summary>
        /// <param name="noOfNumbers"></param>
        /// <returns></returns>
        GeneratedRandonNumber RandomGeneratorwithColorCodes(int noOfNumbers);

        /// <summary>
        /// GetColorCoding
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        string GetColorCoding(int value);


    }
}
