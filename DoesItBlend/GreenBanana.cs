using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing a bananna
    /// </summary>
    public class GreenBanana : Banana
    {
        /// Blends the banana
        /// </summary>
        /// <returns>The result of blending the banana</returns>
        public override string Blend()
        {
            return "lumps";
        }
    }
}
