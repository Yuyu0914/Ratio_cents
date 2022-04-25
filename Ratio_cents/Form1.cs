using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Ratio_cents
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            //生成限表，仅在编译期运行一次
            Controller.Utils.Limit_To_Db(Models.Ratio.max_ij);

            //读取限表，并不去检测是否正确
            Controller.Utils.Load_Limit_Db();

            //设置默认值
            comboBox_Allowed_Octave.SelectedIndex = 1;

            comboBox_sort_mode.SelectedIndex = 0;

        }

        private void textBox_Ratio_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Ratio_j_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            if (textBox_Ratio_i.Text == "" || textBox_Ratio_j.Text == "")
            {
                MessageBox.Show("比例不能为空");
                return;
            }
            int i = Convert.ToInt32(textBox_Ratio_i.Text);
            int j = Convert.ToInt32(textBox_Ratio_j.Text);
            if (i >= Models.Ratio.max_ij || j >= Models.Ratio.max_ij)
            {
                MessageBox.Show("数值太大了");
            }
            else if (i == 0 || j == 0)
            {
                MessageBox.Show("比例不能为0");
            }
            else
            {
                textBox_Cents.Text = Convert.ToString(Models.Ratio.Ratio_To_Cents(i, j));
            }
        }

        private void textBox_Cents_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (textBox_Cents.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox_Cents.Text, out oldf);
                    b2 = float.TryParse(textBox_Cents.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Max_Limit_Prime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Max_Limit_Odd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox_Max_Limit_Odd_TextChanged(object sender, EventArgs e)
        {
            //输出超过最大值就设定为最大值
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Max_Limit_Prime_TextChanged(object sender, EventArgs e)
        {
            //输出超过最大值就设定为最大值
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Max_FreqRatio_TextChanged(object sender, EventArgs e)
        {
            //输出超过最大值就设定为最大值
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
                    textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Limit_Prime_TextChanged(object sender, EventArgs e)
        {
            //输出超过最大值就设定为最大值
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
            //设置需要更新列表
            Models.FormStatus.isNeedUpdataLimitList = true;
        }

        private void textBox_Limit_Odd_TextChanged(object sender, EventArgs e)
        {
            //输出超过最大值就设定为最大值
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
            //设置需要更新列表
            Models.FormStatus.isNeedUpdataLimitList = true;
        }

        private void textBox_Limit_Prime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Limit_Odd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            //一键清空
            textBox_Max_FreqRatio.Text = "";
            textBox_Limit_Odd.Text = "";
            textBox_Limit_Prime.Text = "";
            textBox_Max_Limit_Odd.Text = "";
            textBox_Max_Limit_Prime.Text = "";
        }

        private void button_Updata_Click(object sender, EventArgs e)
        {
            Update_Limit_List();
        }

        private void textBox_Allowed_Error_Cents_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (textBox.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox.Text, out oldf);
                    b2 = float.TryParse(textBox.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        /// <summary>
        /// 搜索可能的频率比
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button_Trans_Click(object sender, EventArgs e)
        {
            // 修改了限列表需要自动更新一次
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
            }
            if (textBox_Cents.Text == "")
            {
                MessageBox.Show("不能为空", "错误");
            }
            else if (Math.Abs(Convert.ToDouble(textBox_Cents.Text)) < 0.00001f)
            {
                MessageBox.Show("不能为0", "错误");
            }
            else
            {
                double cents_search = Convert.ToDouble(textBox_Cents.Text);

                //允许的音分误差,空等于限制30
                if (textBox_Allowed_Error_Cents.Text == "")
                {
                    textBox_Allowed_Error_Cents.Text = "30";
                }

                double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);

                // 确定搜索范围，缺省情况是无限制的最大值
                int max_FreqRatio = Models.Ratio.max_ij;
                int max_limit_Odd = Models.Ratio.max_ij;
                int max_limit_Prime = Models.Ratio.max_ij;


                // 限制的八度区域，
                int limit_Oct = 999; //不限制的情况设置为999个八度都可以
                if (comboBox_Allowed_Octave.SelectedIndex != 0) //选择框的序号0是无限制，1是1个八度内，对应oct = 0
                    limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //所以减去1，比较时1个八度 oct <= oct'

                // 如果不为空则设置成用户自定义的值，空等于无限制
                if (textBox_Max_FreqRatio.Text != "")
                    max_FreqRatio = Convert.ToInt32(textBox_Max_FreqRatio.Text);
                if (textBox_Max_Limit_Odd.Text != "")
                    max_limit_Odd = Convert.ToInt32(textBox_Max_Limit_Odd.Text);
                if (textBox_Max_Limit_Prime.Text != "")
                    max_limit_Prime = Convert.ToInt32(textBox_Max_Limit_Prime.Text);

                int limit_Odd = max_limit_Odd;
                int limit_Prime = max_limit_Prime;
                if (textBox_Limit_Odd.Text != "")
                    limit_Odd = Convert.ToInt32(textBox_Limit_Odd.Text);
                if (textBox_Limit_Prime.Text != "")
                    limit_Prime = Convert.ToInt32(textBox_Limit_Prime.Text);

                // 用户禁用的列表
                List<int>? allowlist_limit_prime = new List<int>();
                List<int>? allowlist_limit_odd = new List<int>();

                // 每次更新都会重新加载banlist，也防止了出错
                for (int i = 0; i < checkedListBox_Prime.Items.Count; i++)
                {
                    if (checkedListBox_Prime.GetItemChecked(i))
                    {
                        allowlist_limit_prime.Add((int)checkedListBox_Prime.Items[i]);
                    }
                }

                for (int i = 0; i < checkedListBox_Odd.Items.Count; i++)
                {
                    if (checkedListBox_Odd.GetItemChecked(i))
                    {
                        allowlist_limit_odd.Add((int)checkedListBox_Odd.Items[i]);
                    }
                }

                /*
                 * 展示的奇数限列表是从3开始的，因为1，2的奇数限没有意义
                 * 比如2，4，8的奇数限是2，如果不添加允许就会出大问题
                 * 搜索时需要注意，手动在允许的奇数限列表内添加1和2
                 */
                allowlist_limit_odd.Add(1);
                allowlist_limit_odd.Add(2);

                // 初始化搜索表, 
                List<int>? search_list_without_banlist = new List<int>();
                for (int i = 1; i <= max_FreqRatio; i++) //最大频率比确定了范围
                    search_list_without_banlist.Add(i);

                /* 从1-888中选出x判定，888是最大频率比。如果限列表17，大列表88
                 * 在用户选择列表内符合 或者超过 17               
                 */
                var search_list = (from x in search_list_without_banlist
                                   let o = Models.Limit.limit_odd[x]
                                   let p = Models.Limit.limit_prime[x]
                                   where (allowlist_limit_odd.Contains(o) || o > limit_Odd)
                                       && (allowlist_limit_prime.Contains(p) || p > limit_Prime)
                                       && o <= max_limit_Odd
                                       && p <= max_limit_Prime
                                   select x).ToList();
#if DEBUG
                /*
                Debug.WriteLine("max_limit_Odd = {0}", max_limit_Odd);
                Debug.WriteLine("max_limit_Prime = {0}", max_limit_Prime);
                Debug.WriteLine("limit_Odd = {0}", limit_Odd);
                Debug.WriteLine("limit_Prime = {0}", limit_Prime);
                Debug.WriteLine("\nsearch_list_without_banlist:");
                foreach (var item in search_list_without_banlist)
                {
                    Debug.Write(item.ToString() + ",");
                }
                Debug.WriteLine("allowlist_limit_prime:");
                foreach (var item in allowlist_limit_prime)
                {
                    Debug.Write(item.ToString() + ",");
                }
                Debug.WriteLine("\nallowlist_limit_odd:");
                foreach (var item in allowlist_limit_odd)
                {
                    Debug.Write(item.ToString() + ",");
                }
                Debug.WriteLine("\nsearch_list:");
                foreach (var item in search_list)
                {
                    Debug.Write(item.ToString() + ",");
                }
                Debug.WriteLine("");
                */

#endif

                // 存放结果的List清空
                ratio_Result.Clear();
                // 开始计算,先把结果文本框清空
                textBox_Result.Text = "";
                // 搜索频率分别是xy, 其中i, j是允许列表的下表
                for (int i = 0; i < search_list.Count(); i++)
                {
                    for (int j = i; j < search_list.Count(); j++)
                    {
                        bool isRepeat_or_OverLimit = false; //是否重复，如9:6 = 3:2 或约分后发现不对劲！
                        // 顺序保证了 x < y 
                        int x = search_list[j];
                        int y = search_list[i];
                        // 探索是否是重复的组合，比如2:3 , 4: 6
                        if (checkBox_drop_reducible.Checked == true) //显示最简比例的情况
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
                                foreach (var item in ratio_Result)
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
                            double error = cents_search - cents_xy;
                            // 搜索到一个可能解, 则存放起来
                            if (Math.Abs(error) < allowed_error_cents && oct <= limit_Oct)
                            {
#if DEBUG
                                //Debug模式下输出搜索结果的
                                //Debug.WriteLine($"x = {x}, y = {y}, oct = {oct}, error ={error}");
#endif
                                //存起来
                                Models.Ratio_Result result = new Models.Ratio_Result();
                                result.i = x; //循环的ij是下标,xy才是频率比
                                result.j = y;
                                result.octave = oct;
                                result.error = error;
                                result.cents = cents_xy;
                                ratio_Result.Add(result);
                            }
                        }
                    }
                }
                // 更新结果列表
                textBox_Result.Text = Controller.Utils.Trans_Result_To_Text(ratio_Result, checkBox_simplify_result.Checked);
            }
        }

        internal void Update_Limit_List()
        {
            int max_FreqRatio = Models.Ratio.max_ij;
            int limit_Odd = Models.Ratio.max_ij;
            int limit_Prime = Models.Ratio.max_ij;

            // 如果最大限写了，限列表没写，那么就把限列表改成最大限的值
            if (textBox_Max_Limit_Prime.Text != "" && textBox_Limit_Prime.Text == "")
            {
                textBox_Limit_Prime.Text = textBox_Max_Limit_Prime.Text;
            }
            if (textBox_Max_Limit_Odd.Text != "" && textBox_Limit_Odd.Text == "")
                textBox_Limit_Odd.Text = textBox_Max_Limit_Odd.Text;

            // 如果展示的限列表空间超过了用户设定的搜索范围，那么就拓展搜索范围
            if (textBox_Max_Limit_Prime.Text != "" && textBox_Limit_Prime.Text != "")
            {
                if (Convert.ToInt32(textBox_Limit_Prime.Text) > Convert.ToInt32(textBox_Max_Limit_Prime.Text))
                    textBox_Max_Limit_Prime.Text = textBox_Limit_Prime.Text;
            }
            if (textBox_Max_Limit_Odd.Text != "" && textBox_Limit_Odd.Text != "")
            {
                if (Convert.ToInt32(textBox_Limit_Odd.Text) > Convert.ToInt32(textBox_Max_Limit_Odd.Text))
                    textBox_Max_Limit_Odd.Text = textBox_Limit_Odd.Text;
            }

            // 如果不为空则设置成用户自定义的值，空等于无限制
            if (textBox_Limit_Odd.Text != "")
                limit_Odd = Convert.ToInt32(textBox_Limit_Odd.Text);
            if (textBox_Limit_Prime.Text != "")
                limit_Prime = Convert.ToInt32(textBox_Limit_Prime.Text);

            // 清除已有值
            checkedListBox_Prime.Items.Clear();
            checkedListBox_Odd.Items.Clear();

            // 更新可以选择的限列表
            var i = 0;
            /*
             * 理论上可以Debug.Write(Models.Limit.limit_odd.Max());
             * 但没必要，几乎不节省时间，因为999最大限是999                   
            */
            while (i < Models.Ratio.Prime_table.Length && Models.Ratio.Prime_table[i] <= limit_Prime) // 小于等于则添加，采用短路与保证不越界
            {
                checkedListBox_Prime.Items.Add(Models.Ratio.Prime_table[i]);
                checkedListBox_Prime.SetItemChecked(i, true);
                i++;
            }
            int k = 0;
            /*
             * 展示的奇数限列表是从3开始的，因为1，2的奇数限没有意义
             * 比如2，4，8的奇数限是2，如果不添加允许就会出大问题
             * 搜索时需要注意，手动在允许的奇数限列表内添加1和2
            */
            for (int j = 3; j <= limit_Odd; j += 2)
            {
                checkedListBox_Odd.Items.Add(j);
                checkedListBox_Odd.SetItemChecked(k, true);
                k++;
            }
        }

        private void textBox_Allowed_Error_Cents_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                if (Convert.ToDouble(textBox.Text) > 200.0f)
                    textBox.Text = "200";
            }
        }

        private void checkBox_simplify_result_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Result.Text = Controller.Utils.Trans_Result_To_Text(ratio_Result, checkBox_simplify_result.Checked);
        }

        private void button_export_to_csv_Click(object sender, EventArgs e)
        {
            Controller.Utils.Trans_Result_To_Csv(ratio_Result);
        }

        private void button_export_to_excel_Click(object sender, EventArgs e)
        {
            Controller.Utils.Trans_Result_To_Excel(ratio_Result);
        }

        private void textBox_edo_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_edo_oct_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_edo_result_Click(object sender, EventArgs e)
        {
            //尝试更新结果
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // 获取允许的音分误差 & 八度
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // 获取搜索列表
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // 检查是否需要更新计算结果, 需要就重新计算一次
                if (true) //有bug，先强制重算吧
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //计算并排序
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }

                // 构建结果以便弹出
                StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
                for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
                {
                    Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                    sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                    foreach (var item in key.Possibilities)
                    {
                        sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                        sb.Append(Math.Abs(item.error).ToString("#.##"));
                        sb.Append(" cents");
                        if (item.octave > 0)
                            sb.Append(" ( Octave = )");
                        sb.AppendLine();
                    }
                }
                MessageBox.Show(sb.ToString(), $"{edo_x} 平均律，在{edo_times}倍中划分");

            }
            else
            {
                scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                MessageBox.Show("没有比例中可用的数字！请重新选择！");
            }
        }

        private double Get_allowed_error_cents()
        {
            //允许的音分误差,空等于限制30
            if (textBox_Allowed_Error_Cents.Text == "")
            {
                textBox_Allowed_Error_Cents.Text = "30";
            }
            double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);
            return allowed_error_cents;
        }

        private int Get_limit_Oct()
        {
            // 获取限制的八度区域与音分
            int limit_Oct = 999; //不限制的情况设置为999个八度都可以
            if (comboBox_Allowed_Octave.SelectedIndex != 0) //选择框的序号0是无限制，1是1个八度内，对应oct = 0
                limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //所以减去1，比较时1个八度 oct <= oct'
            return limit_Oct;
        }

        private List<int> Get_Search_List()
        {
            List<int> search_list = new List<int>();
            if (textBox_Cents.Text == "")
            {
                MessageBox.Show("不能为空", "错误");
            }
            else if (Math.Abs(Convert.ToDouble(textBox_Cents.Text)) < 0.00001f)
            {
                MessageBox.Show("不能为0", "错误");
            }
            else
            {
                double cents_search = Convert.ToDouble(textBox_Cents.Text);

                //允许的音分误差,空等于限制30
                if (textBox_Allowed_Error_Cents.Text == "")
                {
                    textBox_Allowed_Error_Cents.Text = "30";
                }

                double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);

                // 确定搜索范围，缺省情况是无限制的最大值
                int max_FreqRatio = Models.Ratio.max_ij;
                int max_limit_Odd = Models.Ratio.max_ij;
                int max_limit_Prime = Models.Ratio.max_ij;


                // 限制的八度区域，
                int limit_Oct = 999; //不限制的情况设置为999个八度都可以
                if (comboBox_Allowed_Octave.SelectedIndex != 0) //选择框的序号0是无限制，1是1个八度内，对应oct = 0
                    limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //所以减去1，比较时1个八度 oct <= oct'

                // 如果不为空则设置成用户自定义的值，空等于无限制
                if (textBox_Max_FreqRatio.Text != "")
                    max_FreqRatio = Convert.ToInt32(textBox_Max_FreqRatio.Text);
                if (textBox_Max_Limit_Odd.Text != "")
                    max_limit_Odd = Convert.ToInt32(textBox_Max_Limit_Odd.Text);
                if (textBox_Max_Limit_Prime.Text != "")
                    max_limit_Prime = Convert.ToInt32(textBox_Max_Limit_Prime.Text);

                int limit_Odd = max_limit_Odd;
                int limit_Prime = max_limit_Prime;
                if (textBox_Limit_Odd.Text != "")
                    limit_Odd = Convert.ToInt32(textBox_Limit_Odd.Text);
                if (textBox_Limit_Prime.Text != "")
                    limit_Prime = Convert.ToInt32(textBox_Limit_Prime.Text);

                // 用户禁用的列表
                List<int>? allowlist_limit_prime = new List<int>();
                List<int>? allowlist_limit_odd = new List<int>();

                // 每次更新都会重新加载banlist，也防止了出错
                for (int i = 0; i < checkedListBox_Prime.Items.Count; i++)
                {
                    if (checkedListBox_Prime.GetItemChecked(i))
                    {
                        allowlist_limit_prime.Add((int)checkedListBox_Prime.Items[i]);
                    }
                }

                for (int i = 0; i < checkedListBox_Odd.Items.Count; i++)
                {
                    if (checkedListBox_Odd.GetItemChecked(i))
                    {
                        allowlist_limit_odd.Add((int)checkedListBox_Odd.Items[i]);
                    }
                }

                /*
                 * 展示的奇数限列表是从3开始的，因为1，2的奇数限没有意义
                 * 比如2，4，8的奇数限是2，如果不添加允许就会出大问题
                 * 搜索时需要注意，手动在允许的奇数限列表内添加1和2
                 */
                allowlist_limit_odd.Add(1);
                allowlist_limit_odd.Add(2);

                // 初始化搜索表, 
                List<int>? search_list_without_banlist = new List<int>();
                for (int i = 1; i <= max_FreqRatio; i++) //最大频率比确定了范围
                    search_list_without_banlist.Add(i);

                /* 从1-888中选出x判定，888是最大频率比。如果限列表17，大列表88
                 * 在用户选择列表内符合 或者超过 17               
                 */
                search_list = (from x in search_list_without_banlist
                               let o = Models.Limit.limit_odd[x]
                               let p = Models.Limit.limit_prime[x]
                               where (allowlist_limit_odd.Contains(o) || o > limit_Odd)
                                   && (allowlist_limit_prime.Contains(p) || p > limit_Prime)
                                   && o <= max_limit_Odd
                                   && p <= max_limit_Prime
                               select x).ToList();
            }
            return search_list;
        }

        private void button_edo_copy_result_Click(object sender, EventArgs e)
        {
            int edo_x;
            int edo_times;
            //判断有没有生成过结果
            if (scale_To_Ratio_Result_Edo.edo_x is not null && scale_To_Ratio_Result_Edo.edo_times is not null)
            {
                edo_x = (int)scale_To_Ratio_Result_Edo.edo_x;
                edo_times = (int)scale_To_Ratio_Result_Edo.edo_times;
            }
            else
            {
                MessageBox.Show("请点击显示结果或输出结果后再将结果复制", "你还没有查看结果");
                return;
            }

            // 构建结果以便弹出
            StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
            for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
            {
                Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                foreach (var item in key.Possibilities)
                {
                    sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                    sb.Append(Math.Abs(item.error).ToString("#.##"));
                    sb.Append(" cents");
                    if (item.octave > 0)
                        sb.Append(" ( Octave = )");
                    sb.AppendLine();
                }
            }
            try
            {
                Clipboard.SetDataObject(sb.ToString());
                MessageBox.Show("复制成功！", "消息");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "复制遇到问题，复制失败！");
            }

        }

        private void button_edo_result_txt_Click(object sender, EventArgs e)
        {

            //尝试更新结果
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // 获取允许的音分误差 & 八度
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // 获取搜索列表
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // 检查是否需要更新计算结果, 需要就重新计算一次
                if (true) //先强制， bug
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //计算并排序
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }

                // 构建结果以便弹出
                StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
                for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
                {
                    Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                    sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                    foreach (var item in key.Possibilities)
                    {
                        sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                        sb.Append(Math.Abs(item.error).ToString("#.##"));
                        sb.Append(" cents");
                        if (item.octave > 0)
                            sb.Append(" ( Octave = )");
                        sb.AppendLine();
                    }
                }

                string localFilePath = "";
                //string localFilePath, fileNameExt, newFileName, FilePath; 
                SaveFileDialog sfd = new SaveFileDialog();
                //设置文件类型 
                sfd.Filter = "文本文件（*.txt）|*.txt";

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
                        sw.Write(sb.ToString());
                    }
                }

            }
            else
            {
                scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                MessageBox.Show("没有比例中可用的数字！请重新选择！");
            }
        }

        private void button_use_default_setting_Click(object sender, EventArgs e)
        {
            textBox_Max_FreqRatio.Text = "81";
            textBox_Limit_Prime.Text = "17";
            textBox_Limit_Odd.Text = "11";
            textBox_Max_Limit_Prime.Text = "17";
            textBox_Max_Limit_Odd.Text = "63";
            textBox_Allowed_Error_Cents.Text = "30";
        }

        private void comboBox_sort_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 对结果进行排序
            scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
        }

        private void button_edo_result_excel_Click(object sender, EventArgs e)
        {

            //尝试更新结果
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // 获取允许的音分误差 & 八度
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // 获取搜索列表
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // 检查是否需要更新计算结果, 需要就重新计算一次
                if (true) // 先强制重算，bug
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //计算并排序
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }
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
                }

                //写入csv
                Controller.Utils.Scale_Result_To_Excel<Models.Scale_To_Ratio_Result_Edo>(scale_To_Ratio_Result_Edo, localFilePath);
            }
        }

        private void button_scale_result_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // 获取允许的音分误差 & 八度
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // 获取搜索列表
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // 检查是否需要更新计算结果, 需要就重新计算一次
                    if (true) //有bug，先强制重算吧
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //计算并排序
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // 构建结果以便弹出
                    StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                        sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                        foreach (var item in key.Possibilities)
                        {
                            sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                            sb.Append(Math.Abs(item.error).ToString("#.##"));
                            sb.Append(" cents");
                            if (item.octave > 0)
                                sb.Append(" ( Octave = )");
                            sb.AppendLine();
                        }
                    }
                    MessageBox.Show(sb.ToString());

                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    MessageBox.Show("没有比例中可用的数字！请重新选择！");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入数据格式不正确");
            }
        }

        private void button_scale_copy_result_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // 获取允许的音分误差 & 八度
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // 获取搜索列表
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // 检查是否需要更新计算结果, 需要就重新计算一次
                    if (true) //有bug，先强制重算吧
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //计算并排序
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // 构建结果以便弹出
                    StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                        sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                        foreach (var item in key.Possibilities)
                        {
                            sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                            sb.Append(Math.Abs(item.error).ToString("#.##"));
                            sb.Append(" cents");
                            if (item.octave > 0)
                                sb.Append(" ( Octave = )");
                            sb.AppendLine();
                        }
                    }
                    try
                    {
                        Clipboard.SetDataObject(sb.ToString());
                        MessageBox.Show("复制成功！", "消息");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "复制遇到问题，复制失败！");
                    }
                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    MessageBox.Show("没有比例中可用的数字！请重新选择！");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入数据格式不正确");
            }
        }

        private void button_scale_result_excel_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // 获取允许的音分误差 & 八度
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // 获取搜索列表
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // 检查是否需要更新计算结果, 需要就重新计算一次
                    if (true) //有bug，先强制重算吧
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //计算并排序
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    string localFilePath = "";
                    //string localFilePath, fileNameExt, newFileName, FilePath; 
                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型 
                    sfd.Filter = "Excel文件（*.xlsx）|*.xlsx";

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
                        Controller.Utils.Scale_Result_To_Excel<Models.Scale_To_Ratio_Result>(Scale_To_Ratio_Result, localFilePath);
                    }                       
                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    MessageBox.Show("没有比例中可用的数字！请重新选择！");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入数据格式不正确");
            }
        }

        private void button_scale_result_txt_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // 获取允许的音分误差 & 八度
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // 检查限列表是否更新, 如果限列表更新了，那么也得更新计算结果
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // 获取搜索列表
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // 检查是否需要更新计算结果, 需要就重新计算一次
                    if (true) //有bug，先强制重算吧
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //计算并排序
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // 构建结果以便弹出
                    StringBuilder sb = new();
#pragma warning disable CS8602 // 解引用可能出现空引用。
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // 解引用可能出现空引用。
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("第"); sb.Append(i + 1); sb.Append("步："); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // 解引用可能出现空引用。
                        sb.Append(" cents，搜索到的可能数目："); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // 解引用可能出现空引用。
                        foreach (var item in key.Possibilities)
                        {
                            sb.Append(item.i); sb.Append(':'); sb.Append(item.j); sb.Append(item.error > 0 ? " + " : " - ");
                            sb.Append(Math.Abs(item.error).ToString("#.##"));
                            sb.Append(" cents");
                            if (item.octave > 0)
                                sb.Append(" ( Octave = )");
                            sb.AppendLine();
                        }
                    }

                    string localFilePath = "";
                    //string localFilePath, fileNameExt, newFileName, FilePath; 
                    SaveFileDialog sfd = new SaveFileDialog();
                    //设置文件类型 
                    sfd.Filter = "文本文件（*.txt）|*.txt";

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
                            sw.Write(sb.ToString());
                        }
                    }


                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    scale_To_Ratio_Result_Edo.edo_x = null; //为null表示没计算
                    MessageBox.Show("没有比例中可用的数字！请重新选择！");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入数据格式不正确");
            }
        }

        private void button_BRSO_Key_Click(object sender, EventArgs e)
        {
            if (textBox_BRSO_Map.Text != "")
            { 
                string[] ss = textBox_BRSO_Map.Text.Split(Environment.NewLine.ToCharArray());
                string localFilePath = "";
                //s = s.Where(s => !string.IsNullOrEmpty(s)).ToArray(); //去掉空字符串
                string[] s = new string[ss.Length/2 + 1];
                for (int i = 0; i < ss.Length/2 + 1; i++)
                {
                    s[i] = ss[i * 2];
                }

                //string localFilePath, fileNameExt, newFileName, FilePath; 
                SaveFileDialog sfd = new SaveFileDialog();
                //设置文件类型 
                sfd.Filter = "文本文件（*.txt）|*.txt";

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
                if (localFilePath!="")
                {
                    // 空或太大就设置成默认值
                    if (textBox_center_key.Text == "")
                    {
                        textBox_center_key.Text = "48";
                    }
                    int center_key = Convert.ToInt32(textBox_center_key.Text);
                    if (center_key>127 || center_key<0)
                    {
                        textBox_center_key.Text = "48";
                        center_key = 48;
                    }

                    // 中心音高
                    string[] s_out = new string[128];
                    if (textBox_center_number.Text == "")
                        textBox_center_number.Text = "5";
                    int center_number = Convert.ToInt32(textBox_center_number.Text);
                    if (center_number > 10 || center_number < 0)
                    {
                        textBox_center_number.Text = "5";
                        center_number = 5;
                    }

                    // 计算生成表
                    int t = s.Length - 1;
                    int c = center_number; //设置为中心
                    for (int i = center_key; i<=127; i++)
                    {
                        //不为空行则追加数字
                        s_out[i] = checkBox_append_pitch_number.Checked && s[t]!="" ? s[t] + c.ToString() : s[t] ;
                        t = t - 1;
                        if (t < 0)
                        {
                            c++;
                            t = t + s.Length;
                        }
                    }

                    t = 0;
                    c = center_number - 1;
                    for (int i = center_key - 1; i >= 0; i--)
                    {
                        //不为空行则追加数字
                        s_out[i] = checkBox_append_pitch_number.Checked && s[t] != "" ? s[t] + c.ToString() : s[t] ;
                        t = t + 1;
                        if (t >= s.Length)
                        {
                            c--;
                            t = t - s.Length;
                        }
                    }

                    // 写
                    using (StreamWriter sw = File.CreateText(localFilePath))
                    {
                        for (int i = 127; i >= 0; i--)
                        {
                            sw.WriteLine(s_out[i]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("你还没有输入键盘列表！");
            }

        }

        private void textBox_center_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_center_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }
    }
}