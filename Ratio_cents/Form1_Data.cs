using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratio_cents
{
    public partial class Form1 : Form
    {
        //存放搜索的结果
        List<Models.Ratio_Result> ratio_Result = new List<Models.Ratio_Result>();
        Models.Scale_To_Ratio_Result_Edo scale_To_Ratio_Result_Edo = new Models.Scale_To_Ratio_Result_Edo();
        Models.Scale_To_Ratio_Result Scale_To_Ratio_Result = new();
    }
}
