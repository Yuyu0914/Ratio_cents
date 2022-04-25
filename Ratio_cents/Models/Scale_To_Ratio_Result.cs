using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratio_cents.Models
{
    enum Sort_Mode { None, Ratio, Cent };
    internal class Scale_To_Ratio_Result
    {
        public List<Single_Result>? Single_Results;

        public void Sort(int mode)
        {
            if (mode == (int)Sort_Mode.None || Single_Results is null)
            {
                return;
            }
            if (mode == (int)Sort_Mode.Ratio)
            {
                for (int i = 0; i < Single_Results.Count; i++)
                {
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    this.Single_Results[i].Possibilities.Sort(Possibility.CompareWithRatio);
#pragma warning restore CS8602 // 解引用可能出现空引用。
                }
            }
            else
            {
                for (int i = 0; i < Single_Results.Count; i++)
                {
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    this.Single_Results[i].Possibilities.Sort(Possibility.CompareWithCents);
#pragma warning restore CS8602 // 解引用可能出现空引用。
                }
            }
        }

    }

    internal class Possibility
    {
        internal static int CompareWithRatio(Possibility x, Possibility y)
        {
            if (x.i > y.i)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        internal static int CompareWithCents(Possibility x, Possibility y)
        {
            if (x.cents > y.cents)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int i;
        public int j;
        public double cents;
        public double error;
        public int octave;
    }

    internal class Single_Result
    {
        public double original_cents;
        public List<Possibility>? Possibilities;
    }

    internal class Scale_To_Ratio_Result_Edo : Scale_To_Ratio_Result
    {
        public int? edo_x = null;  //为null表示没计算
        public int? edo_times = null; //为null表示没计算
    }
}
