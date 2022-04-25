using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratio_cents.Models
{
    static internal class Ratio
    {
        public static int max_ij = 1000;
        public static readonly double cent = Math.Pow(2,1.0f/1200); // 1 cent
        private static double[,] cents = new double[max_ij + 1, max_ij + 1];

        public static readonly int[] Prime_table =
        {
            2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,
            71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,
            167,173,179,181,191,193,197,199,211,223,227,229,233,239,241,251,257,263,269,
            271,277,281,283,293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,
            389,397,401,409,419,421,431,433,439,443,449,457,461,463,467,479,487,491,499,
            503,509,521,523,541,547,557,563,569,571,577,587,593,599,601,607,613,617,619,
            631,641,643,647,653,659,661,673,677,683,691,701,709,719,727,733,739,743,751,
            757,761,769,773,787,797,809,811,821,823,827,829,839,853,857,859,863,877,881,
            883,887,907,911,919,929,937,941,947,953,967,971,977,983,991,997
        };
        static Ratio()
        {
            for (int i = 1; i <= max_ij; i++)
                for (int j = 1; j <= max_ij; j++)
                {
                    // ratio,  2^(x/1200) = i / j                
                    cents[i, j] = Math.Log((double)i / j, 2) * 1200;
                }
        }

        /// <summary>
        /// 计算频率比对应的音分
        /// </summary>
        /// <param name="i">频率比的第一个参数</param>
        /// <param name="j">频率比的第二个参数</param>
        /// <returns>对应的音分数</returns>
        public static double Ratio_To_Cents(int i, int j)
        {
            return cents[i, j];
        }

        /// <summary>
        /// 计算频率比对应的音分，且缩放到 -1199 - 1199
        /// </summary>
        /// <param name="i">频率比的第一个参数</param>
        /// <param name="j">频率比的第二个参数</param>
        /// <returns>对应的音分数</returns>
        public static double Ratio_To_Cents_1200(int i, int j)
        {
            return cents[i, j] % 1200;
        }

        /// <summary>
        /// 计算频率比对应的八度数目
        /// </summary>
        /// <param name="i">频率比的第一个参数</param>
        /// <param name="j">频率比的第二个参数</param>
        /// <returns>对应的音八度数目，总是为正</returns>
        public static int Ratio_To_Octave(int i, int j)
        {
            return Math.Abs((int)cents[i, j]) / 1200;
        }
    }
}
