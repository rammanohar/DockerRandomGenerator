namespace FocusRandomGenerator.DataEntities
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// GeneratedRandonNumber
    /// </summary>
    public class GeneratedRandonNumber
    {
        /// <summary>
        /// Contructor
        /// </summary>
        public GeneratedRandonNumber() => this.ColorCodingRange = new List<ColorCoding>
                                        {
                                            new ColorCoding { Id = 1,  Color=Color.Gray.Name, LowerLimit= 1, UpperLimit =9 },
                                            new ColorCoding { Id = 2,  Color=Color.Blue.Name, LowerLimit= 10, UpperLimit =19 },
                                            new ColorCoding { Id = 3,  Color=Color.Gray.Name, LowerLimit= 20, UpperLimit =29 },
                                            new ColorCoding { Id = 4,  Color=Color.Green.Name, LowerLimit= 30, UpperLimit =39 },
                                            new ColorCoding { Id = 5,  Color=Color.Yellow.Name, LowerLimit= 40, UpperLimit =49 },
                                        };
           


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Gets or Sets RandonNumbers
        /// </summary>
        public List<NumberInfo> RandonNumbers { get; set; }

        /// <summary>
        /// Gets or Sets colorCodingRange
        /// </summary>
        public List<ColorCoding> ColorCodingRange { get; set; }

        /// <summary>
        /// Gets or Sets GeneratorDateTime
        /// </summary>
        public DateTime GeneratorDateTime { get; set; }

    }
}
