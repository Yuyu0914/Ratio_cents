using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratio_cents.Models
{
    internal static class Limit
    {
        public static int[] limit_odd = new int[Models.Ratio.max_ij + 1]; // 奇数限
        public static int[] limit_prime = new int[Models.Ratio.max_ij + 1];  // 质数限
    }
}
