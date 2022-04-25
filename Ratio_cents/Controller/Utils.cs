using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Ratio_cents.Controller
{
    internal class Utils
    {
        /// <summary>
        /// 输出结果用于展示
        /// </summary>
        /// <param name="ratio_Result">推测的结果列表</param>
        /// <param name="isSimplify_Result">是否简化显示结果</param>
        /// <returns></returns>
        internal static string Trans_Result_To_Text(List<Models.Ratio_Result> ratio_Result, bool isSimplify_Result)
        {
            if (isSimplify_Result)
                return Trans_Result_To_Text_With_Simplify_Result(ratio_Result);
            else
                return Trans_Result_To_Text_Without_Simplify_Result(ratio_Result);
        }

        private static string Trans_Result_To_Text_Without_Simplify_Result(List<Models.Ratio_Result> ratio_Result)
        {
            if (ratio_Result.Count > 0)
            {
                StringBuilder sb = new StringBuilder(100);
                sb.Append("搜索到结果数目：");
                sb.AppendLine(ratio_Result.Count.ToString());
                foreach (var item in ratio_Result)
                {
                    sb.Append(item.i);
                    sb.Append(':');
                    sb.Append(item.j);
                    sb.Append(", cents = ");
                    sb.Append(item.cents);
                    sb.Append(", error = ");
                    sb.Append(item.error);
                    sb.Append(", octave = ");
                    sb.AppendLine(item.octave.ToString());
                }
                return sb.ToString();
            }
            else
            {
                return "无满足条件的结果";
            }
        }
        private static string Trans_Result_To_Text_With_Simplify_Result(List<Models.Ratio_Result> ratio_Result)
        {
            if (ratio_Result.Count > 0)
            {
                StringBuilder sb = new StringBuilder(100);
                sb.Append("搜索到结果数目：");
                sb.AppendLine(ratio_Result.Count.ToString());
                foreach (var item in ratio_Result)
                {
                    sb.Append(item.i);
                    sb.Append(':');
                    sb.Append(item.j);
                    if (Math.Abs(item.error) > 0.000001f)
                    { 
                        sb.Append(item.error > 0 ? " + " : " - ");
                        sb.Append(Math.Abs(item.error).ToString("#.##"));
                        sb.AppendLine(" cents");
                    }
                    else
                    {
                        sb.AppendLine();
                    }
                }
                return sb.ToString();
            }
            else
            {
                return "无满足条件的结果";
            }
        }

        /// <summary>
        /// 读取限数据库
        /// </summary>
        internal static void Load_Limit_Db()
        {
            try
            {
                using (StreamReader sr = new StreamReader("limit.db"))
                {
                    for (int i = 0; i <= Models.Ratio.max_ij; i++)
                    {
                        string? s = sr.ReadLine();
                        string[] words = s.Split(',');
                        Models.Limit.limit_odd[i] = Convert.ToInt32(words[1]);
                        Models.Limit.limit_prime[i] = Convert.ToInt32(words[2]);
                    }
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("数据文件缺失");
                System.Environment.Exit(0);
            }
        }
        /// <summary>
        /// 计算限数据库
        /// </summary>
        /// <param name="max_ij"></param>

        internal static void Limit_To_Db(int max_ij)
        {
            int[] limit_odd = new int[max_ij + 1]; // 奇数限
            int[] limit_prime= new int[max_ij + 1];  // 质数限
            limit_odd[0] = 0;
            limit_prime[0] = 0;
            limit_odd[1] = 1;
            limit_prime[1] = 1;
            limit_odd[2] = 2;
            limit_prime[2] = 2;
            //接下来生成限
            for (int i = 3; i <= max_ij; i++)
            {
                int t = i; 
                while (t % 2 == 0) t /= 2; // 去除2的幂
                if (t == 1) t = 2; // 如果遇到1/2这种情况就将奇数限设为2
                // t就是奇数限
                limit_odd[i] = t;
                
                var temp_limit_prime = 2; // 临时的质数限
                t = i;
                for (int j = 2; j <= i; j++)   
                {
                    while (t % j == 0) // 发现了质因子
                    {
                        t /= j;
                        if (temp_limit_prime < j)
                            temp_limit_prime = j;  //设置成质数限
                    }
                }
                limit_prime[i] = temp_limit_prime;
            }
            using (StreamWriter sw = new StreamWriter("limit.db"))
            {
                for (int i = 0; i <= max_ij; i++)
                    sw.WriteLine("{0},{1},{2}", i, limit_odd[i], limit_prime[i]);
            }
        }

        /// <summary>
        /// 输出推测结果到csv文件
        /// </summary>
        /// <param name="ratio_Result">推测结果列表</param>

        internal static void Trans_Result_To_Csv(List<Models.Ratio_Result> ratio_Result)
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "Csv文件（*.csv）|*.csv";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            string fileNameExt = "";
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

                //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

                ////fs输出带文字或图片的文件，就看需求了 
            }

            if (localFilePath != "")
            { 
                using (StreamWriter sw = new StreamWriter(localFilePath))
                {
                    sw.WriteLine("freq_A,freq_B,cents,error,octave");
                    foreach (var item in ratio_Result)
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4}", item.i, item.j, item.cents, item.error, item.octave);
                    }
                }
            }
        }


        internal static void Trans_Result_To_Excel(List<Models.Ratio_Result> ratio_Result)
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "Excel文件|*.xlsx";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            string fileNameExt = "";
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

                //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

                ////fs输出带文字或图片的文件，就看需求了 
            }
            if (localFilePath != "")
            {

                //创建 Excel对象
                Microsoft.Office.Interop.Excel.Application? excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    MessageBox.Show("Excel is not properly installed!");
                    return;
                }
                //set visible the Excel will run in background
                excel.Visible = false;
                //set false the alerts will not display
                excel.DisplayAlerts = false;

                //添加新工作簿
                Workbook? workbook = excel.Workbooks.Add(true);
                //new a worksheet
                Microsoft.Office.Interop.Excel.Worksheet? workSheet = workbook.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                // write data
                //workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);//获得第i个sheet，准备写入
                //workSheet.Cells[1, 3] = "(1,3)Content";
                workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);//获得第i个sheet，准备写入
                workSheet.Cells[1, 1] = "Freq_A";
                workSheet.Cells[1, 2] = "Freq_B";
                workSheet.Cells[1, 3] = "Cents";
                workSheet.Cells[1, 4] = "Error";
                workSheet.Cells[1, 5] = "Octave";

                int i = 1; //行序号
                foreach (var item in ratio_Result)
                {
                    i++;
                    workSheet.Cells[i, 1] = item.i;
                    workSheet.Cells[i, 2] = item.j;
                    workSheet.Cells[i, 3] = item.cents;
                    workSheet.Cells[i, 4] = item.error;
                    workSheet.Cells[i, 5] = item.octave;
                }

                try 
                { 
                    workbook.SaveAs(localFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    //quit and clean up objects
                    excel.Quit();
                    workSheet = null;
                    workbook = null;
                    excel = null;
                    GC.Collect();
                }
            }
        }

        /// <summary>
        /// 计算平均律音阶的可能频率比
        /// </summary>
        /// <param name="edo_x">X平均律，如十九</param>
        /// <param name="edo_times">Y倍频率内被均等划分</param>
        /// <param name="scale_To_Ratio_Result_Edo">存放结果的位置</param>
        /// <param name="search_list">频率比中允许出现的频率</param>
        /// <param name="is_Drop_Reducible">是否丢弃重复比例</param>
        internal static Models.Scale_To_Ratio_Result_Edo Scale_Edo_Get_Result(int edo_x, int edo_times,
            List<int> search_list, bool is_Drop_Reducible, double allowed_error_cents, int limit_Oct)
        {
            if (true)
            {
                // 计算出scale
                List<double> scale = new List<double>();

                // edo_x = 12, edo_times = 2
                // pow(2,1/12) -> pow(1,2/12) -> ... -> pow(2, 12/12) 频率比
                // ----------------------------------------------------------
                // 实际上如果edo_times = 3，那么 math.log(3,2)*1200 = 1901.9550008653875
                // 只需要这么1901.955 * 1..12 就行
                double oct_altered = Math.Log(edo_times, 2) * 1200; // math.log(3, 2) * 1200 = 1901.9550008653875
                for (int i = 1; i <= edo_x; i++)
                {
                    double t = oct_altered * i / edo_x;
                    scale.Add(t);
                }
                // 填充结果
                Models.Scale_To_Ratio_Result_Edo scale_To_Ratio_Result_Edo;
                scale_To_Ratio_Result_Edo = Scale_Get_Result<Models.Scale_To_Ratio_Result_Edo> (scale, search_list, is_Drop_Reducible, allowed_error_cents, limit_Oct);
                
                scale_To_Ratio_Result_Edo.edo_times = edo_times;
                scale_To_Ratio_Result_Edo.edo_x = edo_x;

                return scale_To_Ratio_Result_Edo;
            }
        }

        /// <summary>
        /// 计算给定音阶的频率比
        /// </summary>
        /// <param name="scale">音阶，里面存放着每一个音高的音分值</param>
        /// <param name="scale_To_Ratio_Result_Edo"></param>
        /// <param name="search_list">频率比中允许出现的频率</param>
        /// <param name="is_Drop_Reducible">是否丢弃重复比例</param>
        internal static T Scale_Get_Result<T>(List<double> scale,
             List<int> search_list, bool is_Drop_Reducible, double allowed_error_cents, int limit_Oct) where T : Models.Scale_To_Ratio_Result, new()
        {
            //新建一个可以存放结果的东西
            T scale_To_Ratio_Result = new T();
            scale_To_Ratio_Result.Single_Results = new List<Models.Single_Result>();

            for(int k = 0; k < scale.Count; k++)
            {             
                double original_cents = scale[k]; // 需要搜索的音分值
                Models.Single_Result single_Result = new Models.Single_Result(); //新建对于特定音分的结果
                single_Result.original_cents = original_cents;
                single_Result.Possibilities = new List<Models.Possibility>();
                scale_To_Ratio_Result.Single_Results.Add(single_Result);

                for (int i = 0; i < search_list.Count(); i++)
                {
                    for (int j = i; j < search_list.Count(); j++)
                    {
                        bool isRepeat_or_OverLimit = false; //是否重复，如9:6 = 3:2 或约分后发现不对劲！
                        // 顺序保证了 x < y 
                        int x = search_list[j];
                        int y = search_list[i];
                        // 探索是否是重复的组合，比如2:3 , 4: 6
                        if (is_Drop_Reducible == true) //显示最简比例的情况
                        {
                            // 计算最大公因数 以便删除重复值
                            var m = y;
                            var n = x;
                            int t;
                            while (n != 0)
                            {
                                t = m % n;
                                m = n;
                                n = t;
                            }
                            // M是最大公因子, 求出最简xy频率比与已有结果比较
                            if (m != 1) //可以约分
                            {
                                int sample_x = x / m;
                                int sample_y = y / m;

                                // 判断x约分后是否超出限制, 这个地方应该用HASH更快
                                if (!search_list.Contains(sample_x) || !search_list.Contains(sample_x))
                                {
                                    continue;
                                }

                                // 判断约分是否重复
                                foreach (var item in single_Result.Possibilities)
                                {
                                    if (item.i == sample_x && item.j == sample_y) //约分后重复
                                    {
                                        isRepeat_or_OverLimit = true;
                                        break;
                                    }
                                }
                            }
                        }
                        // 计算对应的音分值
                        if (!isRepeat_or_OverLimit)
                        {
                            int oct = Models.Ratio.Ratio_To_Octave(x, y);
                            double cents_xy = Models.Ratio.Ratio_To_Cents_1200(x, y);
                            double error = original_cents - cents_xy;
                            // 搜索到一个可能解, 则存放起来
                            if (Math.Abs(error) < allowed_error_cents && oct <= limit_Oct)
                            {
                                //存起来
                                Models.Possibility result = new Models.Possibility();
                                result.i = x; //循环的ij是下标,xy才是频率比
                                result.j = y;
                                result.octave = oct;
                                result.error = error;
                                result.cents = cents_xy;
                                single_Result.Possibilities.Add(result);
                            }
                        }
                    }
                }
            }
            return scale_To_Ratio_Result;
        }

        internal static void Scale_Result_To_Excel<T>(T result, string localFilePath) where T : Models.Scale_To_Ratio_Result, new()
        {
            if (localFilePath != "")
            {

                //创建 Excel对象
                Microsoft.Office.Interop.Excel.Application? excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    MessageBox.Show("Excel is not properly installed!");
                    return;
                }
                //set visible the Excel will run in background
                excel.Visible = false;
                //set false the alerts will not display
                excel.DisplayAlerts = false;

                //添加新工作簿
                Workbook? workbook = excel.Workbooks.Add(true);
                //new a worksheet
                Microsoft.Office.Interop.Excel.Worksheet? workSheet = workbook.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                // write data
                //workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);//获得第i个sheet，准备写入
                //workSheet.Cells[1, 3] = "(1,3)Content";
                workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);//获得第i个sheet，准备写入
                workSheet.Cells[1, 1] = "Origin_cent";
                workSheet.Cells[1, 2] = "Freq_A";
                workSheet.Cells[1, 3] = "Freq_B";
                workSheet.Cells[1, 4] = "Cents";
                workSheet.Cells[1, 5] = "Error";
                workSheet.Cells[1, 6] = "Octave";

                int i = 1; //行序号
                if (result.Single_Results is not null)
                {
                    foreach (var item in result.Single_Results)
                    {
                        if (item.Possibilities is not null)
                        {
                            foreach (var item2 in item.Possibilities)
                            {
                                i++;
                                workSheet.Cells[i, 1] = item.original_cents;
                                workSheet.Cells[i, 2] = item2.i;
                                workSheet.Cells[i, 3] = item2.j;
                                workSheet.Cells[i, 4] = item2.cents;
                                workSheet.Cells[i, 5] = item2.error;
                                workSheet.Cells[i, 6] = item2.octave;
                            }
                        }
                    }
                }               

                try
                {
                    workbook.SaveAs(localFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    //quit and clean up objects
                    excel.Quit();
                    workSheet = null;
                    workbook = null;
                    excel = null;
                    GC.Collect();
                }
            }
        }

        internal static List<double> Split_Scale(string text)
        {
            List<double> scale = new List<double>();
            string[] subs = text.Split(',');
            foreach (string s in subs)
            {
                scale.Add(double.Parse(s));
            }
            return scale;
        }
    }
}
