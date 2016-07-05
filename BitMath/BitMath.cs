using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BitMath
{
    public class BitAlghoritm
    {
        /// <summary>
        /// Get a sign
        /// </summary>
        /// <param name="a">number</param>
        /// <returns>0 if positive, 1 if negative</returns>
        public static int ComputeSign(int a)
        {
            var x = Int32.MaxValue;
            var b = Int32.MinValue;
            var t = -2;
            return (a>>31) & 1;
        }
        /// <summary>
        /// Compute a and b;
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">SeCond nubmer</param>
        /// <returns>1 if equals, a if a>b , b if b>a </returns>
        public static int ComputeValue(int a,int b)
        {
            int i = 31;
            while(i!=0)
            {
                if ( (a & (1 << i)) > (b & (1 << i)) )
                {
                    return a;
                }
                if ((a & (1 << i)) < (b & (1 << i)))
                {
                    return b;
                }
                i--;
            }
            return 1;
        }
    }
}
