using System;
using System.Collections.Generic;
using System.Drawing;
namespace FocusRandomGenerator.DataEntities
{
    using System.Text;

    /// <summary>
    /// ColorCoding
    /// </summary>
    public class ColorCoding
    {

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets for LowerLimit
        /// </summary>
        public int LowerLimit { get; set; }

        /// <summary>
        /// Gets or Sets for UpperLimit
        /// </summary>
        public int UpperLimit { get; set; }

        /// <summary>
        /// Gets or Sets for Color
        /// </summary>
        public string Color { get; set; }
    }
}
