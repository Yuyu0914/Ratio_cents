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
            //�����ޱ����ڱ���������һ��
            Controller.Utils.Limit_To_Db(Models.Ratio.max_ij);

            //��ȡ�ޱ�����ȥ����Ƿ���ȷ
            Controller.Utils.Load_Limit_Db();

            //����Ĭ��ֵ
            comboBox_Allowed_Octave.SelectedIndex = 1;

            comboBox_sort_mode.SelectedIndex = 0;

        }

        private void textBox_Ratio_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Ratio_j_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            if (textBox_Ratio_i.Text == "" || textBox_Ratio_j.Text == "")
            {
                MessageBox.Show("��������Ϊ��");
                return;
            }
            int i = Convert.ToInt32(textBox_Ratio_i.Text);
            int j = Convert.ToInt32(textBox_Ratio_j.Text);
            if (i >= Models.Ratio.max_ij || j >= Models.Ratio.max_ij)
            {
                MessageBox.Show("��ֵ̫����");
            }
            else if (i == 0 || j == 0)
            {
                MessageBox.Show("��������Ϊ0");
            }
            else
            {
                textBox_Cents.Text = Convert.ToString(Models.Ratio.Ratio_To_Cents(i, j));
            }
        }

        private void textBox_Cents_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�жϰ����ǲ���Ҫ��������͡�
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //С����Ĵ���
            if ((int)e.KeyChar == 46)                           //С����
            {
                if (textBox_Cents.Text.Length <= 0)
                    e.Handled = true;   //С���㲻���ڵ�һλ
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
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Max_Limit_Prime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Max_Limit_Odd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox_Max_Limit_Odd_TextChanged(object sender, EventArgs e)
        {
            //����������ֵ���趨Ϊ���ֵ
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Max_Limit_Prime_TextChanged(object sender, EventArgs e)
        {
            //����������ֵ���趨Ϊ���ֵ
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Max_FreqRatio_TextChanged(object sender, EventArgs e)
        {
            //����������ֵ���趨Ϊ���ֵ
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
                    textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
        }

        private void textBox_Limit_Prime_TextChanged(object sender, EventArgs e)
        {
            //����������ֵ���趨Ϊ���ֵ
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
            //������Ҫ�����б�
            Models.FormStatus.isNeedUpdataLimitList = true;
        }

        private void textBox_Limit_Odd_TextChanged(object sender, EventArgs e)
        {
            //����������ֵ���趨Ϊ���ֵ
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "" && Convert.ToInt32(textBox.Text) > Models.Ratio.max_ij)
            {
                textBox.Text = Convert.ToString(Models.Ratio.max_ij);
            }
            //������Ҫ�����б�
            Models.FormStatus.isNeedUpdataLimitList = true;
        }

        private void textBox_Limit_Prime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_Limit_Odd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            //һ�����
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
            //�жϰ����ǲ���Ҫ��������͡�
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //С����Ĵ���
            if ((int)e.KeyChar == 46)                           //С����
            {
                if (textBox.Text.Length <= 0)
                    e.Handled = true;   //С���㲻���ڵ�һλ
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
        /// �������ܵ�Ƶ�ʱ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button_Trans_Click(object sender, EventArgs e)
        {
            // �޸������б���Ҫ�Զ�����һ��
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
            }
            if (textBox_Cents.Text == "")
            {
                MessageBox.Show("����Ϊ��", "����");
            }
            else if (Math.Abs(Convert.ToDouble(textBox_Cents.Text)) < 0.00001f)
            {
                MessageBox.Show("����Ϊ0", "����");
            }
            else
            {
                double cents_search = Convert.ToDouble(textBox_Cents.Text);

                //������������,�յ�������30
                if (textBox_Allowed_Error_Cents.Text == "")
                {
                    textBox_Allowed_Error_Cents.Text = "30";
                }

                double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);

                // ȷ��������Χ��ȱʡ����������Ƶ����ֵ
                int max_FreqRatio = Models.Ratio.max_ij;
                int max_limit_Odd = Models.Ratio.max_ij;
                int max_limit_Prime = Models.Ratio.max_ij;


                // ���Ƶİ˶�����
                int limit_Oct = 999; //�����Ƶ��������Ϊ999���˶ȶ�����
                if (comboBox_Allowed_Octave.SelectedIndex != 0) //ѡ�������0�������ƣ�1��1���˶��ڣ���Ӧoct = 0
                    limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //���Լ�ȥ1���Ƚ�ʱ1���˶� oct <= oct'

                // �����Ϊ�������ó��û��Զ����ֵ���յ���������
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

                // �û����õ��б�
                List<int>? allowlist_limit_prime = new List<int>();
                List<int>? allowlist_limit_odd = new List<int>();

                // ÿ�θ��¶������¼���banlist��Ҳ��ֹ�˳���
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
                 * չʾ���������б��Ǵ�3��ʼ�ģ���Ϊ1��2��������û������
                 * ����2��4��8����������2��������������ͻ��������
                 * ����ʱ��Ҫע�⣬�ֶ���������������б������1��2
                 */
                allowlist_limit_odd.Add(1);
                allowlist_limit_odd.Add(2);

                // ��ʼ��������, 
                List<int>? search_list_without_banlist = new List<int>();
                for (int i = 1; i <= max_FreqRatio; i++) //���Ƶ�ʱ�ȷ���˷�Χ
                    search_list_without_banlist.Add(i);

                /* ��1-888��ѡ��x�ж���888�����Ƶ�ʱȡ�������б�17�����б�88
                 * ���û�ѡ���б��ڷ��� ���߳��� 17               
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

                // ��Ž����List���
                ratio_Result.Clear();
                // ��ʼ����,�Ȱѽ���ı������
                textBox_Result.Text = "";
                // ����Ƶ�ʷֱ���xy, ����i, j�������б���±�
                for (int i = 0; i < search_list.Count(); i++)
                {
                    for (int j = i; j < search_list.Count(); j++)
                    {
                        bool isRepeat_or_OverLimit = false; //�Ƿ��ظ�����9:6 = 3:2 ��Լ�ֺ��ֲ��Ծ���
                        // ˳��֤�� x < y 
                        int x = search_list[j];
                        int y = search_list[i];
                        // ̽���Ƿ����ظ�����ϣ�����2:3 , 4: 6
                        if (checkBox_drop_reducible.Checked == true) //��ʾ�����������
                        {
                            // ����������� �Ա�ɾ���ظ�ֵ
                            var m = y;
                            var n = x;
                            int t;
                            while (n != 0)
                            {
                                t = m % n;
                                m = n;
                                n = t;
                            }
                            // M���������, ������xyƵ�ʱ������н���Ƚ�
                            if (m != 1) //����Լ��
                            {
                                int sample_x = x / m;
                                int sample_y = y / m;

                                // �ж�xԼ�ֺ��Ƿ񳬳�����, ����ط�Ӧ����HASH����
                                if (!search_list.Contains(sample_x) || !search_list.Contains(sample_x))
                                {
                                    continue;
                                }

                                // �ж�Լ���Ƿ��ظ�
                                foreach (var item in ratio_Result)
                                {
                                    if (item.i == sample_x && item.j == sample_y) //Լ�ֺ��ظ�
                                    {
                                        isRepeat_or_OverLimit = true;
                                        break;
                                    }
                                }
                            }
                        }
                        // �����Ӧ������ֵ
                        if (!isRepeat_or_OverLimit)
                        {
                            int oct = Models.Ratio.Ratio_To_Octave(x, y);
                            double cents_xy = Models.Ratio.Ratio_To_Cents_1200(x, y);
                            double error = cents_search - cents_xy;
                            // ������һ�����ܽ�, ��������
                            if (Math.Abs(error) < allowed_error_cents && oct <= limit_Oct)
                            {
#if DEBUG
                                //Debugģʽ��������������
                                //Debug.WriteLine($"x = {x}, y = {y}, oct = {oct}, error ={error}");
#endif
                                //������
                                Models.Ratio_Result result = new Models.Ratio_Result();
                                result.i = x; //ѭ����ij���±�,xy����Ƶ�ʱ�
                                result.j = y;
                                result.octave = oct;
                                result.error = error;
                                result.cents = cents_xy;
                                ratio_Result.Add(result);
                            }
                        }
                    }
                }
                // ���½���б�
                textBox_Result.Text = Controller.Utils.Trans_Result_To_Text(ratio_Result, checkBox_simplify_result.Checked);
            }
        }

        internal void Update_Limit_List()
        {
            int max_FreqRatio = Models.Ratio.max_ij;
            int limit_Odd = Models.Ratio.max_ij;
            int limit_Prime = Models.Ratio.max_ij;

            // ��������д�ˣ����б�ûд����ô�Ͱ����б�ĳ�����޵�ֵ
            if (textBox_Max_Limit_Prime.Text != "" && textBox_Limit_Prime.Text == "")
            {
                textBox_Limit_Prime.Text = textBox_Max_Limit_Prime.Text;
            }
            if (textBox_Max_Limit_Odd.Text != "" && textBox_Limit_Odd.Text == "")
                textBox_Limit_Odd.Text = textBox_Max_Limit_Odd.Text;

            // ���չʾ�����б�ռ䳬�����û��趨��������Χ����ô����չ������Χ
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

            // �����Ϊ�������ó��û��Զ����ֵ���յ���������
            if (textBox_Limit_Odd.Text != "")
                limit_Odd = Convert.ToInt32(textBox_Limit_Odd.Text);
            if (textBox_Limit_Prime.Text != "")
                limit_Prime = Convert.ToInt32(textBox_Limit_Prime.Text);

            // �������ֵ
            checkedListBox_Prime.Items.Clear();
            checkedListBox_Odd.Items.Clear();

            // ���¿���ѡ������б�
            var i = 0;
            /*
             * �����Ͽ���Debug.Write(Models.Limit.limit_odd.Max());
             * ��û��Ҫ����������ʡʱ�䣬��Ϊ999�������999                   
            */
            while (i < Models.Ratio.Prime_table.Length && Models.Ratio.Prime_table[i] <= limit_Prime) // С�ڵ�������ӣ����ö�·�뱣֤��Խ��
            {
                checkedListBox_Prime.Items.Add(Models.Ratio.Prime_table[i]);
                checkedListBox_Prime.SetItemChecked(i, true);
                i++;
            }
            int k = 0;
            /*
             * չʾ���������б��Ǵ�3��ʼ�ģ���Ϊ1��2��������û������
             * ����2��4��8����������2��������������ͻ��������
             * ����ʱ��Ҫע�⣬�ֶ���������������б������1��2
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
            // ֻ���������ֺ�Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_edo_oct_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button_edo_result_Click(object sender, EventArgs e)
        {
            //���Ը��½��
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // ��ȡ������������ & �˶�
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // ��ȡ�����б�
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                if (true) //��bug����ǿ�������
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //���㲢����
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }

                // ��������Ա㵯��
                StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                {
                    Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                    sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                MessageBox.Show(sb.ToString(), $"{edo_x} ƽ���ɣ���{edo_times}���л���");

            }
            else
            {
                scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                MessageBox.Show("û�б����п��õ����֣�������ѡ��");
            }
        }

        private double Get_allowed_error_cents()
        {
            //������������,�յ�������30
            if (textBox_Allowed_Error_Cents.Text == "")
            {
                textBox_Allowed_Error_Cents.Text = "30";
            }
            double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);
            return allowed_error_cents;
        }

        private int Get_limit_Oct()
        {
            // ��ȡ���Ƶİ˶�����������
            int limit_Oct = 999; //�����Ƶ��������Ϊ999���˶ȶ�����
            if (comboBox_Allowed_Octave.SelectedIndex != 0) //ѡ�������0�������ƣ�1��1���˶��ڣ���Ӧoct = 0
                limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //���Լ�ȥ1���Ƚ�ʱ1���˶� oct <= oct'
            return limit_Oct;
        }

        private List<int> Get_Search_List()
        {
            List<int> search_list = new List<int>();
            if (textBox_Cents.Text == "")
            {
                MessageBox.Show("����Ϊ��", "����");
            }
            else if (Math.Abs(Convert.ToDouble(textBox_Cents.Text)) < 0.00001f)
            {
                MessageBox.Show("����Ϊ0", "����");
            }
            else
            {
                double cents_search = Convert.ToDouble(textBox_Cents.Text);

                //������������,�յ�������30
                if (textBox_Allowed_Error_Cents.Text == "")
                {
                    textBox_Allowed_Error_Cents.Text = "30";
                }

                double allowed_error_cents = Convert.ToDouble(textBox_Allowed_Error_Cents.Text);

                // ȷ��������Χ��ȱʡ����������Ƶ����ֵ
                int max_FreqRatio = Models.Ratio.max_ij;
                int max_limit_Odd = Models.Ratio.max_ij;
                int max_limit_Prime = Models.Ratio.max_ij;


                // ���Ƶİ˶�����
                int limit_Oct = 999; //�����Ƶ��������Ϊ999���˶ȶ�����
                if (comboBox_Allowed_Octave.SelectedIndex != 0) //ѡ�������0�������ƣ�1��1���˶��ڣ���Ӧoct = 0
                    limit_Oct = comboBox_Allowed_Octave.SelectedIndex - 1; //���Լ�ȥ1���Ƚ�ʱ1���˶� oct <= oct'

                // �����Ϊ�������ó��û��Զ����ֵ���յ���������
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

                // �û����õ��б�
                List<int>? allowlist_limit_prime = new List<int>();
                List<int>? allowlist_limit_odd = new List<int>();

                // ÿ�θ��¶������¼���banlist��Ҳ��ֹ�˳���
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
                 * չʾ���������б��Ǵ�3��ʼ�ģ���Ϊ1��2��������û������
                 * ����2��4��8����������2��������������ͻ��������
                 * ����ʱ��Ҫע�⣬�ֶ���������������б������1��2
                 */
                allowlist_limit_odd.Add(1);
                allowlist_limit_odd.Add(2);

                // ��ʼ��������, 
                List<int>? search_list_without_banlist = new List<int>();
                for (int i = 1; i <= max_FreqRatio; i++) //���Ƶ�ʱ�ȷ���˷�Χ
                    search_list_without_banlist.Add(i);

                /* ��1-888��ѡ��x�ж���888�����Ƶ�ʱȡ�������б�17�����б�88
                 * ���û�ѡ���б��ڷ��� ���߳��� 17               
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
            //�ж���û�����ɹ����
            if (scale_To_Ratio_Result_Edo.edo_x is not null && scale_To_Ratio_Result_Edo.edo_times is not null)
            {
                edo_x = (int)scale_To_Ratio_Result_Edo.edo_x;
                edo_times = (int)scale_To_Ratio_Result_Edo.edo_times;
            }
            else
            {
                MessageBox.Show("������ʾ��������������ٽ��������", "�㻹û�в鿴���");
                return;
            }

            // ��������Ա㵯��
            StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
            for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
            {
                Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                MessageBox.Show("���Ƴɹ���", "��Ϣ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�����������⣬����ʧ�ܣ�");
            }

        }

        private void button_edo_result_txt_Click(object sender, EventArgs e)
        {

            //���Ը��½��
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // ��ȡ������������ & �˶�
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // ��ȡ�����б�
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                if (true) //��ǿ�ƣ� bug
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //���㲢����
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }

                // ��������Ա㵯��
                StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                for (int i = 0; i < scale_To_Ratio_Result_Edo.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                {
                    Models.Single_Result? key = scale_To_Ratio_Result_Edo.Single_Results[i];
                    sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                //�����ļ����� 
                sfd.Filter = "�ı��ļ���*.txt��|*.txt";

                //����Ĭ���ļ�������ʾ˳�� 
                sfd.FilterIndex = 1;

                //����Ի����Ƿ�����ϴδ򿪵�Ŀ¼ 
                sfd.RestoreDirectory = true;

                string fileNameExt = "";
                //���˱��水ť���� 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    localFilePath = sfd.FileName.ToString(); //����ļ�·�� 
                    fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //��ȡ�ļ���������·��

                    //��ȡ�ļ�·���������ļ��� 
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                    //���ļ���ǰ����ʱ�� 
                    //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                    //���ļ�������ַ� 
                    //saveFileDialog1.FileName.Insert(1,"dameng"); 

                    //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//����ļ� 

                    ////fs��������ֻ�ͼƬ���ļ����Ϳ������� 
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
                scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                MessageBox.Show("û�б����п��õ����֣�������ѡ��");
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
            // �Խ����������
            scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
        }

        private void button_edo_result_excel_Click(object sender, EventArgs e)
        {

            //���Ը��½��
            if (textBox_edo_x.Text == "" || textBox_edo_x.Text == "0" || textBox_edo_x.Text == "1")
                textBox_edo_x.Text = "12";
            if (textBox_edo_times.Text == "" || textBox_edo_times.Text == "0" || textBox_edo_times.Text == "1")
                textBox_edo_times.Text = "2";
            int edo_x = Convert.ToInt32(textBox_edo_x.Text);
            int edo_times = Convert.ToInt32(textBox_edo_times.Text);

            // ��ȡ������������ & �˶�
            int limit_Oct = Get_limit_Oct();
            double allowed_error_cents = Get_allowed_error_cents();

            // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
            bool isNeed_UpData_Scale_Result = false;
            if (Models.FormStatus.isNeedUpdataLimitList)
            {
                Update_Limit_List();
                Models.FormStatus.isNeedUpdataLimitList = false;
                isNeed_UpData_Scale_Result = true;
            }

            // ��ȡ�����б�
            List<int> search_list = Get_Search_List();
            if (search_list.Count != 0)
            {
                if (scale_To_Ratio_Result_Edo.edo_x != edo_x || scale_To_Ratio_Result_Edo.edo_times != edo_times)
                    isNeed_UpData_Scale_Result = true;
                // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                if (true) // ��ǿ�����㣬bug
                {
                    bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                    //���㲢����
                    scale_To_Ratio_Result_Edo = Controller.Utils.Scale_Edo_Get_Result(edo_x, edo_times, search_list, is_Drop_Reducible
                        , allowed_error_cents, limit_Oct);
                    scale_To_Ratio_Result_Edo.Sort(comboBox_sort_mode.SelectedIndex);
                }
                string localFilePath = "";
                //string localFilePath, fileNameExt, newFileName, FilePath; 
                SaveFileDialog sfd = new SaveFileDialog();
                //�����ļ����� 
                sfd.Filter = "Excel�ļ�|*.xlsx";

                //����Ĭ���ļ�������ʾ˳�� 
                sfd.FilterIndex = 1;

                //����Ի����Ƿ�����ϴδ򿪵�Ŀ¼ 
                sfd.RestoreDirectory = true;

                string fileNameExt = "";
                //���˱��水ť���� 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    localFilePath = sfd.FileName.ToString(); //����ļ�·�� 
                    fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //��ȡ�ļ���������·��
                }

                //д��csv
                Controller.Utils.Scale_Result_To_Excel<Models.Scale_To_Ratio_Result_Edo>(scale_To_Ratio_Result_Edo, localFilePath);
            }
        }

        private void button_scale_result_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // ��ȡ������������ & �˶�
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // ��ȡ�����б�
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                    if (true) //��bug����ǿ�������
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //���㲢����
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // ��������Ա㵯��
                    StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                        sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    MessageBox.Show("û�б����п��õ����֣�������ѡ��");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("�������ݸ�ʽ����ȷ");
            }
        }

        private void button_scale_copy_result_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // ��ȡ������������ & �˶�
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // ��ȡ�����б�
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                    if (true) //��bug����ǿ�������
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //���㲢����
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // ��������Ա㵯��
                    StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                        sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                        MessageBox.Show("���Ƴɹ���", "��Ϣ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "�����������⣬����ʧ�ܣ�");
                    }
                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    MessageBox.Show("û�б����п��õ����֣�������ѡ��");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("�������ݸ�ʽ����ȷ");
            }
        }

        private void button_scale_result_excel_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // ��ȡ������������ & �˶�
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // ��ȡ�����б�
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                    if (true) //��bug����ǿ�������
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //���㲢����
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    string localFilePath = "";
                    //string localFilePath, fileNameExt, newFileName, FilePath; 
                    SaveFileDialog sfd = new SaveFileDialog();
                    //�����ļ����� 
                    sfd.Filter = "Excel�ļ���*.xlsx��|*.xlsx";

                    //����Ĭ���ļ�������ʾ˳�� 
                    sfd.FilterIndex = 1;

                    //����Ի����Ƿ�����ϴδ򿪵�Ŀ¼ 
                    sfd.RestoreDirectory = true;

                    string fileNameExt = "";
                    //���˱��水ť���� 
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        localFilePath = sfd.FileName.ToString(); //����ļ�·�� 
                        fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //��ȡ�ļ���������·��

                        //��ȡ�ļ�·���������ļ��� 
                        //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                        //���ļ���ǰ����ʱ�� 
                        //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                        //���ļ�������ַ� 
                        //saveFileDialog1.FileName.Insert(1,"dameng"); 

                        //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//����ļ� 

                        ////fs��������ֻ�ͼƬ���ļ����Ϳ������� 
                    }

                    if (localFilePath != "")
                    {
                        Controller.Utils.Scale_Result_To_Excel<Models.Scale_To_Ratio_Result>(Scale_To_Ratio_Result, localFilePath);
                    }                       
                }
                else
                {
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    MessageBox.Show("û�б����п��õ����֣�������ѡ��");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("�������ݸ�ʽ����ȷ");
            }
        }

        private void button_scale_result_txt_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> scale = Controller.Utils.Split_Scale(textBox_custom_scale.Text);
                // ��ȡ������������ & �˶�
                int limit_Oct = Get_limit_Oct();
                double allowed_error_cents = Get_allowed_error_cents();

                // ������б��Ƿ����, ������б�����ˣ���ôҲ�ø��¼�����
                bool isNeed_UpData_Scale_Result = false;
                if (Models.FormStatus.isNeedUpdataLimitList)
                {
                    Update_Limit_List();
                    Models.FormStatus.isNeedUpdataLimitList = false;
                    isNeed_UpData_Scale_Result = true;
                }

                // ��ȡ�����б�
                List<int> search_list = Get_Search_List();
                if (search_list.Count != 0)
                {
                    // ����Ƿ���Ҫ���¼�����, ��Ҫ�����¼���һ��
                    if (true) //��bug����ǿ�������
                    {
                        bool is_Drop_Reducible = checkBox_drop_reducible.Checked;
                        //���㲢����
                        Scale_To_Ratio_Result = Controller.Utils.Scale_Get_Result<Models.Scale_To_Ratio_Result>(scale, search_list, is_Drop_Reducible
                            , allowed_error_cents, limit_Oct);
                        Scale_To_Ratio_Result.Sort(comboBox_sort_mode.SelectedIndex);
                    }

                    // ��������Ա㵯��
                    StringBuilder sb = new();
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    for (int i = 0; i < Scale_To_Ratio_Result.Single_Results.Count; i++)
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                    {
                        Models.Single_Result? key = Scale_To_Ratio_Result.Single_Results[i];
                        sb.Append("��"); sb.Append(i + 1); sb.Append("����"); sb.Append(key.original_cents.ToString());
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                        sb.Append(" cents���������Ŀ�����Ŀ��"); sb.AppendLine(key.Possibilities.Count.ToString());
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
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
                    //�����ļ����� 
                    sfd.Filter = "�ı��ļ���*.txt��|*.txt";

                    //����Ĭ���ļ�������ʾ˳�� 
                    sfd.FilterIndex = 1;

                    //����Ի����Ƿ�����ϴδ򿪵�Ŀ¼ 
                    sfd.RestoreDirectory = true;

                    string fileNameExt = "";
                    //���˱��水ť���� 
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        localFilePath = sfd.FileName.ToString(); //����ļ�·�� 
                        fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //��ȡ�ļ���������·��

                        //��ȡ�ļ�·���������ļ��� 
                        //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                        //���ļ���ǰ����ʱ�� 
                        //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                        //���ļ�������ַ� 
                        //saveFileDialog1.FileName.Insert(1,"dameng"); 

                        //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//����ļ� 

                        ////fs��������ֻ�ͼƬ���ļ����Ϳ������� 
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
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    scale_To_Ratio_Result_Edo.edo_x = null; //Ϊnull��ʾû����
                    MessageBox.Show("û�б����п��õ����֣�������ѡ��");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("�������ݸ�ʽ����ȷ");
            }
        }

        private void button_BRSO_Key_Click(object sender, EventArgs e)
        {
            if (textBox_BRSO_Map.Text != "")
            { 
                string[] ss = textBox_BRSO_Map.Text.Split(Environment.NewLine.ToCharArray());
                string localFilePath = "";
                //s = s.Where(s => !string.IsNullOrEmpty(s)).ToArray(); //ȥ�����ַ���
                string[] s = new string[ss.Length/2 + 1];
                for (int i = 0; i < ss.Length/2 + 1; i++)
                {
                    s[i] = ss[i * 2];
                }

                //string localFilePath, fileNameExt, newFileName, FilePath; 
                SaveFileDialog sfd = new SaveFileDialog();
                //�����ļ����� 
                sfd.Filter = "�ı��ļ���*.txt��|*.txt";

                //����Ĭ���ļ�������ʾ˳�� 
                sfd.FilterIndex = 1;

                //����Ի����Ƿ�����ϴδ򿪵�Ŀ¼ 
                sfd.RestoreDirectory = true;

                string fileNameExt = "";
                //���˱��水ť���� 
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    localFilePath = sfd.FileName.ToString(); //����ļ�·�� 
                    fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //��ȡ�ļ���������·��

                    //��ȡ�ļ�·���������ļ��� 
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                    //���ļ���ǰ����ʱ�� 
                    //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                    //���ļ�������ַ� 
                    //saveFileDialog1.FileName.Insert(1,"dameng"); 

                    //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//����ļ� 

                    ////fs��������ֻ�ͼƬ���ļ����Ϳ������� 
                }
                if (localFilePath!="")
                {
                    // �ջ�̫������ó�Ĭ��ֵ
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

                    // ��������
                    string[] s_out = new string[128];
                    if (textBox_center_number.Text == "")
                        textBox_center_number.Text = "5";
                    int center_number = Convert.ToInt32(textBox_center_number.Text);
                    if (center_number > 10 || center_number < 0)
                    {
                        textBox_center_number.Text = "5";
                        center_number = 5;
                    }

                    // �������ɱ�
                    int t = s.Length - 1;
                    int c = center_number; //����Ϊ����
                    for (int i = center_key; i<=127; i++)
                    {
                        //��Ϊ������׷������
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
                        //��Ϊ������׷������
                        s_out[i] = checkBox_append_pitch_number.Checked && s[t] != "" ? s[t] + c.ToString() : s[t] ;
                        t = t + 1;
                        if (t >= s.Length)
                        {
                            c--;
                            t = t - s.Length;
                        }
                    }

                    // д
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
                MessageBox.Show("�㻹û����������б�");
            }

        }

        private void textBox_center_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_center_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ֻ���������ֺ�Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }
    }
}