namespace Ratio_cents
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Ratio_i = new System.Windows.Forms.TextBox();
            this.textBox_Ratio_j = new System.Windows.Forms.TextBox();
            this.label_Ratio = new System.Windows.Forms.Label();
            this.label_Introduction_1 = new System.Windows.Forms.Label();
            this.button_Go = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.checkedListBox_Prime = new System.Windows.Forms.CheckedListBox();
            this.label_Introduction_2 = new System.Windows.Forms.Label();
            this.textBox_Cents = new System.Windows.Forms.TextBox();
            this.button_Trans = new System.Windows.Forms.Button();
            this.label_Introduction_3 = new System.Windows.Forms.Label();
            this.label_Introduction_4 = new System.Windows.Forms.Label();
            this.textBox_Max_FreqRatio = new System.Windows.Forms.TextBox();
            this.label_Introduction_5 = new System.Windows.Forms.Label();
            this.textBox_Max_Limit_Prime = new System.Windows.Forms.TextBox();
            this.label_Introduction_6 = new System.Windows.Forms.Label();
            this.textBox_Max_Limit_Odd = new System.Windows.Forms.TextBox();
            this.textBox_Limit_Prime = new System.Windows.Forms.TextBox();
            this.label_Introduction_7 = new System.Windows.Forms.Label();
            this.textBox_Limit_Odd = new System.Windows.Forms.TextBox();
            this.button_Updata = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Introduction_8 = new System.Windows.Forms.Label();
            this.textBox_Allowed_Error_Cents = new System.Windows.Forms.TextBox();
            this.checkedListBox_Odd = new System.Windows.Forms.CheckedListBox();
            this.label_Introduction_9 = new System.Windows.Forms.Label();
            this.comboBox_Allowed_Octave = new System.Windows.Forms.ComboBox();
            this.checkBox_drop_reducible = new System.Windows.Forms.CheckBox();
            this.checkBox_simplify_result = new System.Windows.Forms.CheckBox();
            this.button_export_to_csv = new System.Windows.Forms.Button();
            this.button_export_to_excel = new System.Windows.Forms.Button();
            this.label_Advance = new System.Windows.Forms.Label();
            this.label_edo_x = new System.Windows.Forms.Label();
            this.textBox_edo_x = new System.Windows.Forms.TextBox();
            this.button_edo_result = new System.Windows.Forms.Button();
            this.label_edo_times = new System.Windows.Forms.Label();
            this.textBox_edo_times = new System.Windows.Forms.TextBox();
            this.button_edo_result_excel = new System.Windows.Forms.Button();
            this.button_edo_copy_result = new System.Windows.Forms.Button();
            this.button_edo_result_txt = new System.Windows.Forms.Button();
            this.button_use_default_setting = new System.Windows.Forms.Button();
            this.comboBox_sort_mode = new System.Windows.Forms.ComboBox();
            this.label_sort_mode = new System.Windows.Forms.Label();
            this.label_custom_scale = new System.Windows.Forms.Label();
            this.textBox_custom_scale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_scale_result_excel = new System.Windows.Forms.Button();
            this.button_scale_copy_result = new System.Windows.Forms.Button();
            this.button_scale_result_txt = new System.Windows.Forms.Button();
            this.button_scale_result = new System.Windows.Forms.Button();
            this.label_BRSO = new System.Windows.Forms.Label();
            this.textBox_BRSO_Map = new System.Windows.Forms.TextBox();
            this.checkBox_append_pitch_number = new System.Windows.Forms.CheckBox();
            this.label_center_key = new System.Windows.Forms.Label();
            this.textBox_center_key = new System.Windows.Forms.TextBox();
            this.button_BRSO_Key = new System.Windows.Forms.Button();
            this.label_center_number = new System.Windows.Forms.Label();
            this.textBox_center_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Ratio_i
            // 
            this.textBox_Ratio_i.Location = new System.Drawing.Point(90, 23);
            this.textBox_Ratio_i.Name = "textBox_Ratio_i";
            this.textBox_Ratio_i.Size = new System.Drawing.Size(38, 23);
            this.textBox_Ratio_i.TabIndex = 0;
            this.textBox_Ratio_i.Text = "3";
            this.textBox_Ratio_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ratio_i_KeyPress);
            // 
            // textBox_Ratio_j
            // 
            this.textBox_Ratio_j.Location = new System.Drawing.Point(151, 23);
            this.textBox_Ratio_j.Name = "textBox_Ratio_j";
            this.textBox_Ratio_j.Size = new System.Drawing.Size(38, 23);
            this.textBox_Ratio_j.TabIndex = 1;
            this.textBox_Ratio_j.Text = "2";
            this.textBox_Ratio_j.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ratio_j_KeyPress);
            // 
            // label_Ratio
            // 
            this.label_Ratio.AutoSize = true;
            this.label_Ratio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Ratio.Location = new System.Drawing.Point(134, 29);
            this.label_Ratio.Name = "label_Ratio";
            this.label_Ratio.Size = new System.Drawing.Size(11, 17);
            this.label_Ratio.TabIndex = 2;
            this.label_Ratio.Text = ":";
            this.label_Ratio.UseWaitCursor = true;
            // 
            // label_Introduction_1
            // 
            this.label_Introduction_1.AutoSize = true;
            this.label_Introduction_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_1.Location = new System.Drawing.Point(20, 22);
            this.label_Introduction_1.Name = "label_Introduction_1";
            this.label_Introduction_1.Size = new System.Drawing.Size(64, 24);
            this.label_Introduction_1.TabIndex = 3;
            this.label_Introduction_1.Text = "比例：";
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(195, 24);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(75, 23);
            this.button_Go.TabIndex = 4;
            this.button_Go.Text = "计算音分";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(20, 99);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(250, 302);
            this.textBox_Result.TabIndex = 5;
            // 
            // checkedListBox_Prime
            // 
            this.checkedListBox_Prime.CheckOnClick = true;
            this.checkedListBox_Prime.FormattingEnabled = true;
            this.checkedListBox_Prime.Location = new System.Drawing.Point(276, 235);
            this.checkedListBox_Prime.Name = "checkedListBox_Prime";
            this.checkedListBox_Prime.Size = new System.Drawing.Size(70, 166);
            this.checkedListBox_Prime.TabIndex = 6;
            // 
            // label_Introduction_2
            // 
            this.label_Introduction_2.AutoSize = true;
            this.label_Introduction_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_2.Location = new System.Drawing.Point(20, 60);
            this.label_Introduction_2.Name = "label_Introduction_2";
            this.label_Introduction_2.Size = new System.Drawing.Size(64, 24);
            this.label_Introduction_2.TabIndex = 7;
            this.label_Introduction_2.Text = "音分：";
            // 
            // textBox_Cents
            // 
            this.textBox_Cents.Location = new System.Drawing.Point(90, 62);
            this.textBox_Cents.Name = "textBox_Cents";
            this.textBox_Cents.Size = new System.Drawing.Size(99, 23);
            this.textBox_Cents.TabIndex = 8;
            this.textBox_Cents.Text = "701.9550008653874";
            this.textBox_Cents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cents_KeyPress);
            // 
            // button_Trans
            // 
            this.button_Trans.Location = new System.Drawing.Point(195, 62);
            this.button_Trans.Name = "button_Trans";
            this.button_Trans.Size = new System.Drawing.Size(75, 23);
            this.button_Trans.TabIndex = 9;
            this.button_Trans.Text = "推测纯律";
            this.button_Trans.UseVisualStyleBackColor = true;
            this.button_Trans.Click += new System.EventHandler(this.button_Trans_Click);
            // 
            // label_Introduction_3
            // 
            this.label_Introduction_3.AutoSize = true;
            this.label_Introduction_3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_3.Location = new System.Drawing.Point(276, 56);
            this.label_Introduction_3.Name = "label_Introduction_3";
            this.label_Introduction_3.Size = new System.Drawing.Size(118, 24);
            this.label_Introduction_3.TabIndex = 10;
            this.label_Introduction_3.Text = "质数限列表：";
            // 
            // label_Introduction_4
            // 
            this.label_Introduction_4.AutoSize = true;
            this.label_Introduction_4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_4.Location = new System.Drawing.Point(276, 21);
            this.label_Introduction_4.Name = "label_Introduction_4";
            this.label_Introduction_4.Size = new System.Drawing.Size(118, 24);
            this.label_Introduction_4.TabIndex = 11;
            this.label_Introduction_4.Text = "最大频率比：";
            // 
            // textBox_Max_FreqRatio
            // 
            this.textBox_Max_FreqRatio.Location = new System.Drawing.Point(391, 22);
            this.textBox_Max_FreqRatio.Name = "textBox_Max_FreqRatio";
            this.textBox_Max_FreqRatio.Size = new System.Drawing.Size(38, 23);
            this.textBox_Max_FreqRatio.TabIndex = 12;
            this.textBox_Max_FreqRatio.Text = "81";
            this.textBox_Max_FreqRatio.TextChanged += new System.EventHandler(this.textBox_Max_FreqRatio_TextChanged);
            this.textBox_Max_FreqRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label_Introduction_5
            // 
            this.label_Introduction_5.AutoSize = true;
            this.label_Introduction_5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_5.Location = new System.Drawing.Point(276, 125);
            this.label_Introduction_5.Name = "label_Introduction_5";
            this.label_Introduction_5.Size = new System.Drawing.Size(118, 24);
            this.label_Introduction_5.TabIndex = 13;
            this.label_Introduction_5.Text = "最大质数限：";
            // 
            // textBox_Max_Limit_Prime
            // 
            this.textBox_Max_Limit_Prime.Location = new System.Drawing.Point(391, 127);
            this.textBox_Max_Limit_Prime.Name = "textBox_Max_Limit_Prime";
            this.textBox_Max_Limit_Prime.Size = new System.Drawing.Size(38, 23);
            this.textBox_Max_Limit_Prime.TabIndex = 14;
            this.textBox_Max_Limit_Prime.Text = "17";
            this.textBox_Max_Limit_Prime.TextChanged += new System.EventHandler(this.textBox_Max_Limit_Prime_TextChanged);
            this.textBox_Max_Limit_Prime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Max_Limit_Prime_KeyPress);
            // 
            // label_Introduction_6
            // 
            this.label_Introduction_6.AutoSize = true;
            this.label_Introduction_6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_6.Location = new System.Drawing.Point(276, 159);
            this.label_Introduction_6.Name = "label_Introduction_6";
            this.label_Introduction_6.Size = new System.Drawing.Size(118, 24);
            this.label_Introduction_6.TabIndex = 15;
            this.label_Introduction_6.Text = "最大奇数限：";
            // 
            // textBox_Max_Limit_Odd
            // 
            this.textBox_Max_Limit_Odd.Location = new System.Drawing.Point(391, 159);
            this.textBox_Max_Limit_Odd.Name = "textBox_Max_Limit_Odd";
            this.textBox_Max_Limit_Odd.Size = new System.Drawing.Size(38, 23);
            this.textBox_Max_Limit_Odd.TabIndex = 16;
            this.textBox_Max_Limit_Odd.Text = "63";
            this.textBox_Max_Limit_Odd.TextChanged += new System.EventHandler(this.textBox_Max_Limit_Odd_TextChanged);
            this.textBox_Max_Limit_Odd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Max_Limit_Odd_KeyPress);
            // 
            // textBox_Limit_Prime
            // 
            this.textBox_Limit_Prime.Location = new System.Drawing.Point(391, 58);
            this.textBox_Limit_Prime.Name = "textBox_Limit_Prime";
            this.textBox_Limit_Prime.Size = new System.Drawing.Size(38, 23);
            this.textBox_Limit_Prime.TabIndex = 17;
            this.textBox_Limit_Prime.Text = "17";
            this.textBox_Limit_Prime.TextChanged += new System.EventHandler(this.textBox_Limit_Prime_TextChanged);
            this.textBox_Limit_Prime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Limit_Prime_KeyPress);
            // 
            // label_Introduction_7
            // 
            this.label_Introduction_7.AutoSize = true;
            this.label_Introduction_7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_7.Location = new System.Drawing.Point(276, 90);
            this.label_Introduction_7.Name = "label_Introduction_7";
            this.label_Introduction_7.Size = new System.Drawing.Size(118, 24);
            this.label_Introduction_7.TabIndex = 18;
            this.label_Introduction_7.Text = "奇数限列表：";
            // 
            // textBox_Limit_Odd
            // 
            this.textBox_Limit_Odd.Location = new System.Drawing.Point(391, 92);
            this.textBox_Limit_Odd.Name = "textBox_Limit_Odd";
            this.textBox_Limit_Odd.Size = new System.Drawing.Size(38, 23);
            this.textBox_Limit_Odd.TabIndex = 19;
            this.textBox_Limit_Odd.Text = "11";
            this.textBox_Limit_Odd.TextChanged += new System.EventHandler(this.textBox_Limit_Odd_TextChanged);
            this.textBox_Limit_Odd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Limit_Odd_KeyPress);
            // 
            // button_Updata
            // 
            this.button_Updata.Location = new System.Drawing.Point(448, 26);
            this.button_Updata.Name = "button_Updata";
            this.button_Updata.Size = new System.Drawing.Size(135, 23);
            this.button_Updata.TabIndex = 20;
            this.button_Updata.Text = "更新列表";
            this.button_Updata.UseVisualStyleBackColor = true;
            this.button_Updata.Click += new System.EventHandler(this.button_Updata_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(448, 58);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(136, 23);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "清除限制";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_Introduction_8
            // 
            this.label_Introduction_8.AutoSize = true;
            this.label_Introduction_8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_8.Location = new System.Drawing.Point(448, 90);
            this.label_Introduction_8.Name = "label_Introduction_8";
            this.label_Introduction_8.Size = new System.Drawing.Size(136, 24);
            this.label_Introduction_8.TabIndex = 22;
            this.label_Introduction_8.Text = "最大音分误差：";
            // 
            // textBox_Allowed_Error_Cents
            // 
            this.textBox_Allowed_Error_Cents.Location = new System.Drawing.Point(448, 127);
            this.textBox_Allowed_Error_Cents.Name = "textBox_Allowed_Error_Cents";
            this.textBox_Allowed_Error_Cents.Size = new System.Drawing.Size(133, 23);
            this.textBox_Allowed_Error_Cents.TabIndex = 23;
            this.textBox_Allowed_Error_Cents.Text = "30";
            this.textBox_Allowed_Error_Cents.TextChanged += new System.EventHandler(this.textBox_Allowed_Error_Cents_TextChanged);
            this.textBox_Allowed_Error_Cents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Allowed_Error_Cents_KeyPress);
            // 
            // checkedListBox_Odd
            // 
            this.checkedListBox_Odd.CheckOnClick = true;
            this.checkedListBox_Odd.FormattingEnabled = true;
            this.checkedListBox_Odd.Location = new System.Drawing.Point(359, 235);
            this.checkedListBox_Odd.Name = "checkedListBox_Odd";
            this.checkedListBox_Odd.Size = new System.Drawing.Size(70, 166);
            this.checkedListBox_Odd.TabIndex = 24;
            // 
            // label_Introduction_9
            // 
            this.label_Introduction_9.AutoSize = true;
            this.label_Introduction_9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Introduction_9.Location = new System.Drawing.Point(448, 160);
            this.label_Introduction_9.Name = "label_Introduction_9";
            this.label_Introduction_9.Size = new System.Drawing.Size(100, 24);
            this.label_Introduction_9.TabIndex = 25;
            this.label_Introduction_9.Text = "八度允许：";
            // 
            // comboBox_Allowed_Octave
            // 
            this.comboBox_Allowed_Octave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Allowed_Octave.FormattingEnabled = true;
            this.comboBox_Allowed_Octave.Items.AddRange(new object[] {
            "不限制",
            "一个八度以内",
            "两个八度以内",
            "三个八度以内",
            "四个八度以内",
            "五个八度以内"});
            this.comboBox_Allowed_Octave.Location = new System.Drawing.Point(449, 199);
            this.comboBox_Allowed_Octave.Name = "comboBox_Allowed_Octave";
            this.comboBox_Allowed_Octave.Size = new System.Drawing.Size(135, 25);
            this.comboBox_Allowed_Octave.TabIndex = 26;
            // 
            // checkBox_drop_reducible
            // 
            this.checkBox_drop_reducible.AutoSize = true;
            this.checkBox_drop_reducible.Checked = true;
            this.checkBox_drop_reducible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_drop_reducible.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_drop_reducible.Location = new System.Drawing.Point(449, 239);
            this.checkBox_drop_reducible.Name = "checkBox_drop_reducible";
            this.checkBox_drop_reducible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_drop_reducible.Size = new System.Drawing.Size(137, 28);
            this.checkBox_drop_reducible.TabIndex = 27;
            this.checkBox_drop_reducible.Text = "显示最简比例";
            this.checkBox_drop_reducible.UseVisualStyleBackColor = true;
            // 
            // checkBox_simplify_result
            // 
            this.checkBox_simplify_result.AutoSize = true;
            this.checkBox_simplify_result.Checked = true;
            this.checkBox_simplify_result.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_simplify_result.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_simplify_result.Location = new System.Drawing.Point(449, 275);
            this.checkBox_simplify_result.Name = "checkBox_simplify_result";
            this.checkBox_simplify_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_simplify_result.Size = new System.Drawing.Size(137, 28);
            this.checkBox_simplify_result.TabIndex = 28;
            this.checkBox_simplify_result.Text = "结果显示简化";
            this.checkBox_simplify_result.UseVisualStyleBackColor = true;
            this.checkBox_simplify_result.CheckedChanged += new System.EventHandler(this.checkBox_simplify_result_CheckedChanged);
            // 
            // button_export_to_csv
            // 
            this.button_export_to_csv.Location = new System.Drawing.Point(451, 320);
            this.button_export_to_csv.Name = "button_export_to_csv";
            this.button_export_to_csv.Size = new System.Drawing.Size(135, 23);
            this.button_export_to_csv.TabIndex = 29;
            this.button_export_to_csv.Text = "输出推测结果 CSV ";
            this.button_export_to_csv.UseVisualStyleBackColor = true;
            this.button_export_to_csv.Click += new System.EventHandler(this.button_export_to_csv_Click);
            // 
            // button_export_to_excel
            // 
            this.button_export_to_excel.Location = new System.Drawing.Point(451, 349);
            this.button_export_to_excel.Name = "button_export_to_excel";
            this.button_export_to_excel.Size = new System.Drawing.Size(135, 23);
            this.button_export_to_excel.TabIndex = 30;
            this.button_export_to_excel.Text = "输出推测结果 EXCEL";
            this.button_export_to_excel.UseVisualStyleBackColor = true;
            this.button_export_to_excel.Click += new System.EventHandler(this.button_export_to_excel_Click);
            // 
            // label_Advance
            // 
            this.label_Advance.AutoSize = true;
            this.label_Advance.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Advance.Location = new System.Drawing.Point(628, 26);
            this.label_Advance.Name = "label_Advance";
            this.label_Advance.Size = new System.Drawing.Size(64, 24);
            this.label_Advance.TabIndex = 31;
            this.label_Advance.Text = "高级：";
            // 
            // label_edo_x
            // 
            this.label_edo_x.AutoSize = true;
            this.label_edo_x.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_edo_x.Location = new System.Drawing.Point(628, 61);
            this.label_edo_x.Name = "label_edo_x";
            this.label_edo_x.Size = new System.Drawing.Size(154, 24);
            this.label_edo_x.TabIndex = 32;
            this.label_edo_x.Text = "平均律一键分析：";
            // 
            // textBox_edo_x
            // 
            this.textBox_edo_x.Location = new System.Drawing.Point(777, 63);
            this.textBox_edo_x.Name = "textBox_edo_x";
            this.textBox_edo_x.Size = new System.Drawing.Size(38, 23);
            this.textBox_edo_x.TabIndex = 33;
            this.textBox_edo_x.Text = "12";
            this.textBox_edo_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_edo_x_KeyPress);
            // 
            // button_edo_result
            // 
            this.button_edo_result.Location = new System.Drawing.Point(628, 142);
            this.button_edo_result.Name = "button_edo_result";
            this.button_edo_result.Size = new System.Drawing.Size(91, 23);
            this.button_edo_result.TabIndex = 34;
            this.button_edo_result.Text = "弹出结果";
            this.button_edo_result.UseVisualStyleBackColor = true;
            this.button_edo_result.Click += new System.EventHandler(this.button_edo_result_Click);
            // 
            // label_edo_times
            // 
            this.label_edo_times.AutoSize = true;
            this.label_edo_times.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_edo_times.Location = new System.Drawing.Point(628, 98);
            this.label_edo_times.Name = "label_edo_times";
            this.label_edo_times.Size = new System.Drawing.Size(154, 24);
            this.label_edo_times.TabIndex = 35;
            this.label_edo_times.Text = "平均律倍数划分：";
            // 
            // textBox_edo_times
            // 
            this.textBox_edo_times.Location = new System.Drawing.Point(777, 100);
            this.textBox_edo_times.Name = "textBox_edo_times";
            this.textBox_edo_times.Size = new System.Drawing.Size(38, 23);
            this.textBox_edo_times.TabIndex = 36;
            this.textBox_edo_times.Text = "2";
            this.textBox_edo_times.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_edo_oct_KeyPress);
            // 
            // button_edo_result_excel
            // 
            this.button_edo_result_excel.Location = new System.Drawing.Point(724, 142);
            this.button_edo_result_excel.Name = "button_edo_result_excel";
            this.button_edo_result_excel.Size = new System.Drawing.Size(91, 23);
            this.button_edo_result_excel.TabIndex = 37;
            this.button_edo_result_excel.Text = "输出表格";
            this.button_edo_result_excel.UseVisualStyleBackColor = true;
            this.button_edo_result_excel.Click += new System.EventHandler(this.button_edo_result_excel_Click);
            // 
            // button_edo_copy_result
            // 
            this.button_edo_copy_result.Location = new System.Drawing.Point(628, 176);
            this.button_edo_copy_result.Name = "button_edo_copy_result";
            this.button_edo_copy_result.Size = new System.Drawing.Size(91, 23);
            this.button_edo_copy_result.TabIndex = 38;
            this.button_edo_copy_result.Text = "复制结果";
            this.button_edo_copy_result.UseVisualStyleBackColor = true;
            this.button_edo_copy_result.Click += new System.EventHandler(this.button_edo_copy_result_Click);
            // 
            // button_edo_result_txt
            // 
            this.button_edo_result_txt.Location = new System.Drawing.Point(724, 176);
            this.button_edo_result_txt.Name = "button_edo_result_txt";
            this.button_edo_result_txt.Size = new System.Drawing.Size(91, 23);
            this.button_edo_result_txt.TabIndex = 39;
            this.button_edo_result_txt.Text = "输出文本";
            this.button_edo_result_txt.UseVisualStyleBackColor = true;
            this.button_edo_result_txt.Click += new System.EventHandler(this.button_edo_result_txt_Click);
            // 
            // button_use_default_setting
            // 
            this.button_use_default_setting.Location = new System.Drawing.Point(451, 378);
            this.button_use_default_setting.Name = "button_use_default_setting";
            this.button_use_default_setting.Size = new System.Drawing.Size(135, 23);
            this.button_use_default_setting.TabIndex = 40;
            this.button_use_default_setting.Text = "使用默认配置";
            this.button_use_default_setting.UseVisualStyleBackColor = true;
            this.button_use_default_setting.Click += new System.EventHandler(this.button_use_default_setting_Click);
            // 
            // comboBox_sort_mode
            // 
            this.comboBox_sort_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sort_mode.FormattingEnabled = true;
            this.comboBox_sort_mode.Items.AddRange(new object[] {
            "不对结果进行排序",
            "按照最小频率排序",
            "按照音分误差排序"});
            this.comboBox_sort_mode.Location = new System.Drawing.Point(629, 242);
            this.comboBox_sort_mode.Name = "comboBox_sort_mode";
            this.comboBox_sort_mode.Size = new System.Drawing.Size(187, 25);
            this.comboBox_sort_mode.TabIndex = 41;
            this.comboBox_sort_mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_sort_mode_SelectedIndexChanged);
            // 
            // label_sort_mode
            // 
            this.label_sort_mode.AutoSize = true;
            this.label_sort_mode.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sort_mode.Location = new System.Drawing.Point(628, 211);
            this.label_sort_mode.Name = "label_sort_mode";
            this.label_sort_mode.Size = new System.Drawing.Size(118, 24);
            this.label_sort_mode.TabIndex = 42;
            this.label_sort_mode.Text = "结果排序依据";
            // 
            // label_custom_scale
            // 
            this.label_custom_scale.AutoSize = true;
            this.label_custom_scale.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_custom_scale.Location = new System.Drawing.Point(628, 277);
            this.label_custom_scale.Name = "label_custom_scale";
            this.label_custom_scale.Size = new System.Drawing.Size(136, 24);
            this.label_custom_scale.TabIndex = 43;
            this.label_custom_scale.Text = "自定义序列输入";
            // 
            // textBox_custom_scale
            // 
            this.textBox_custom_scale.Location = new System.Drawing.Point(628, 320);
            this.textBox_custom_scale.Name = "textBox_custom_scale";
            this.textBox_custom_scale.Size = new System.Drawing.Size(187, 23);
            this.textBox_custom_scale.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "质数限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(359, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "奇数限";
            // 
            // button_scale_result_excel
            // 
            this.button_scale_result_excel.Location = new System.Drawing.Point(725, 349);
            this.button_scale_result_excel.Name = "button_scale_result_excel";
            this.button_scale_result_excel.Size = new System.Drawing.Size(91, 23);
            this.button_scale_result_excel.TabIndex = 48;
            this.button_scale_result_excel.Text = "输出表格";
            this.button_scale_result_excel.UseVisualStyleBackColor = true;
            this.button_scale_result_excel.Click += new System.EventHandler(this.button_scale_result_excel_Click);
            // 
            // button_scale_copy_result
            // 
            this.button_scale_copy_result.Location = new System.Drawing.Point(628, 378);
            this.button_scale_copy_result.Name = "button_scale_copy_result";
            this.button_scale_copy_result.Size = new System.Drawing.Size(91, 23);
            this.button_scale_copy_result.TabIndex = 49;
            this.button_scale_copy_result.Text = "复制结果";
            this.button_scale_copy_result.UseVisualStyleBackColor = true;
            this.button_scale_copy_result.Click += new System.EventHandler(this.button_scale_copy_result_Click);
            // 
            // button_scale_result_txt
            // 
            this.button_scale_result_txt.Location = new System.Drawing.Point(725, 378);
            this.button_scale_result_txt.Name = "button_scale_result_txt";
            this.button_scale_result_txt.Size = new System.Drawing.Size(91, 23);
            this.button_scale_result_txt.TabIndex = 50;
            this.button_scale_result_txt.Text = "输出文本";
            this.button_scale_result_txt.UseVisualStyleBackColor = true;
            this.button_scale_result_txt.Click += new System.EventHandler(this.button_scale_result_txt_Click);
            // 
            // button_scale_result
            // 
            this.button_scale_result.Location = new System.Drawing.Point(628, 349);
            this.button_scale_result.Name = "button_scale_result";
            this.button_scale_result.Size = new System.Drawing.Size(91, 23);
            this.button_scale_result.TabIndex = 51;
            this.button_scale_result.Text = "弹出结果";
            this.button_scale_result.UseVisualStyleBackColor = true;
            this.button_scale_result.Click += new System.EventHandler(this.button_scale_result_Click);
            // 
            // label_BRSO
            // 
            this.label_BRSO.AutoSize = true;
            this.label_BRSO.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BRSO.Location = new System.Drawing.Point(20, 414);
            this.label_BRSO.Name = "label_BRSO";
            this.label_BRSO.Size = new System.Drawing.Size(158, 31);
            this.label_BRSO.TabIndex = 52;
            this.label_BRSO.Text = "BRSO 辅助：";
            // 
            // textBox_BRSO_Map
            // 
            this.textBox_BRSO_Map.Location = new System.Drawing.Point(184, 418);
            this.textBox_BRSO_Map.Multiline = true;
            this.textBox_BRSO_Map.Name = "textBox_BRSO_Map";
            this.textBox_BRSO_Map.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_BRSO_Map.Size = new System.Drawing.Size(245, 85);
            this.textBox_BRSO_Map.TabIndex = 53;
            this.textBox_BRSO_Map.Text = "B\r\n\r\nA\r\n\r\nG\r\n\r\nF\r\nE\r\n\r\nD\r\n\r\nC";
            // 
            // checkBox_append_pitch_number
            // 
            this.checkBox_append_pitch_number.AutoSize = true;
            this.checkBox_append_pitch_number.Checked = true;
            this.checkBox_append_pitch_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_append_pitch_number.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_append_pitch_number.Location = new System.Drawing.Point(629, 419);
            this.checkBox_append_pitch_number.Name = "checkBox_append_pitch_number";
            this.checkBox_append_pitch_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_append_pitch_number.Size = new System.Drawing.Size(137, 28);
            this.checkBox_append_pitch_number.TabIndex = 54;
            this.checkBox_append_pitch_number.Text = "追加音高数字";
            this.checkBox_append_pitch_number.UseVisualStyleBackColor = true;
            // 
            // label_center_key
            // 
            this.label_center_key.AutoSize = true;
            this.label_center_key.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_center_key.Location = new System.Drawing.Point(451, 464);
            this.label_center_key.Name = "label_center_key";
            this.label_center_key.Size = new System.Drawing.Size(100, 24);
            this.label_center_key.TabIndex = 55;
            this.label_center_key.Text = "标准音高：";
            // 
            // textBox_center_key
            // 
            this.textBox_center_key.Location = new System.Drawing.Point(545, 466);
            this.textBox_center_key.Name = "textBox_center_key";
            this.textBox_center_key.Size = new System.Drawing.Size(41, 23);
            this.textBox_center_key.TabIndex = 57;
            this.textBox_center_key.Text = "48";
            this.textBox_center_key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_center_key_KeyPress);
            // 
            // button_BRSO_Key
            // 
            this.button_BRSO_Key.Location = new System.Drawing.Point(628, 464);
            this.button_BRSO_Key.Name = "button_BRSO_Key";
            this.button_BRSO_Key.Size = new System.Drawing.Size(186, 23);
            this.button_BRSO_Key.TabIndex = 58;
            this.button_BRSO_Key.Text = "生成 BRSO 键盘文件";
            this.button_BRSO_Key.UseVisualStyleBackColor = true;
            this.button_BRSO_Key.Click += new System.EventHandler(this.button_BRSO_Key_Click);
            // 
            // label_center_number
            // 
            this.label_center_number.AutoSize = true;
            this.label_center_number.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_center_number.Location = new System.Drawing.Point(451, 423);
            this.label_center_number.Name = "label_center_number";
            this.label_center_number.Size = new System.Drawing.Size(100, 24);
            this.label_center_number.TabIndex = 59;
            this.label_center_number.Text = "中央音号：";
            // 
            // textBox_center_number
            // 
            this.textBox_center_number.Location = new System.Drawing.Point(545, 423);
            this.textBox_center_number.Name = "textBox_center_number";
            this.textBox_center_number.Size = new System.Drawing.Size(41, 23);
            this.textBox_center_number.TabIndex = 60;
            this.textBox_center_number.Text = "5";
            this.textBox_center_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_center_number_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 520);
            this.Controls.Add(this.textBox_center_number);
            this.Controls.Add(this.label_center_number);
            this.Controls.Add(this.button_BRSO_Key);
            this.Controls.Add(this.textBox_center_key);
            this.Controls.Add(this.label_center_key);
            this.Controls.Add(this.checkBox_append_pitch_number);
            this.Controls.Add(this.textBox_BRSO_Map);
            this.Controls.Add(this.label_BRSO);
            this.Controls.Add(this.button_scale_result);
            this.Controls.Add(this.button_scale_result_txt);
            this.Controls.Add(this.button_scale_copy_result);
            this.Controls.Add(this.button_scale_result_excel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_custom_scale);
            this.Controls.Add(this.label_custom_scale);
            this.Controls.Add(this.label_sort_mode);
            this.Controls.Add(this.comboBox_sort_mode);
            this.Controls.Add(this.button_use_default_setting);
            this.Controls.Add(this.button_edo_result_txt);
            this.Controls.Add(this.button_edo_copy_result);
            this.Controls.Add(this.button_edo_result_excel);
            this.Controls.Add(this.textBox_edo_times);
            this.Controls.Add(this.label_edo_times);
            this.Controls.Add(this.button_edo_result);
            this.Controls.Add(this.textBox_edo_x);
            this.Controls.Add(this.label_edo_x);
            this.Controls.Add(this.label_Advance);
            this.Controls.Add(this.button_export_to_excel);
            this.Controls.Add(this.button_export_to_csv);
            this.Controls.Add(this.checkBox_simplify_result);
            this.Controls.Add(this.checkBox_drop_reducible);
            this.Controls.Add(this.comboBox_Allowed_Octave);
            this.Controls.Add(this.label_Introduction_9);
            this.Controls.Add(this.checkedListBox_Odd);
            this.Controls.Add(this.textBox_Allowed_Error_Cents);
            this.Controls.Add(this.label_Introduction_8);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Updata);
            this.Controls.Add(this.textBox_Limit_Odd);
            this.Controls.Add(this.label_Introduction_7);
            this.Controls.Add(this.textBox_Limit_Prime);
            this.Controls.Add(this.textBox_Max_Limit_Odd);
            this.Controls.Add(this.label_Introduction_6);
            this.Controls.Add(this.textBox_Max_Limit_Prime);
            this.Controls.Add(this.label_Introduction_5);
            this.Controls.Add(this.textBox_Max_FreqRatio);
            this.Controls.Add(this.label_Introduction_4);
            this.Controls.Add(this.label_Introduction_3);
            this.Controls.Add(this.button_Trans);
            this.Controls.Add(this.textBox_Cents);
            this.Controls.Add(this.label_Introduction_2);
            this.Controls.Add(this.checkedListBox_Prime);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.label_Introduction_1);
            this.Controls.Add(this.label_Ratio);
            this.Controls.Add(this.textBox_Ratio_j);
            this.Controls.Add(this.textBox_Ratio_i);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "微分音小工具 By Ariah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Ratio_i;
        private TextBox textBox_Ratio_j;
        private Label label_Ratio;
        private Label label_Introduction_1;
        private Button button_Go;
        private TextBox textBox_Result;
        private CheckedListBox checkedListBox_Prime;
        private Label label_Introduction_2;
        private TextBox textBox_Cents;
        private Button button_Trans;
        private Label label_Introduction_3;
        private Label label_Introduction_4;
        private TextBox textBox_Max_FreqRatio;
        private Label label_Introduction_5;
        private TextBox textBox_Max_Limit_Prime;
        private Label label_Introduction_6;
        private TextBox textBox_Max_Limit_Odd;
        private TextBox textBox_Limit_Prime;
        private Label label_Introduction_7;
        private TextBox textBox_Limit_Odd;
        private Button button_Updata;
        private Button button_Clear;
        private Label label_Introduction_8;
        private TextBox textBox_Allowed_Error_Cents;
        private CheckedListBox checkedListBox_Odd;
        private Label label_Introduction_9;
        private ComboBox comboBox_Allowed_Octave;
        private CheckBox checkBox_drop_reducible;
        private CheckBox checkBox_simplify_result;
        private Button button_export_to_csv;
        private Button button_export_to_excel;
        private Label label_Advance;
        private Label label_edo_x;
        private TextBox textBox_edo_x;
        private Button button_edo_result;
        private Label label_edo_times;
        private TextBox textBox_edo_times;
        private Button button_edo_result_excel;
        private Button button_edo_copy_result;
        private Button button_edo_result_txt;
        private Button button_use_default_setting;
        private ComboBox comboBox_sort_mode;
        private Label label_sort_mode;
        private Label label_custom_scale;
        private TextBox textBox_custom_scale;
        private Label label1;
        private Label label2;
        private Button button_scale_result_excel;
        private Button button_scale_copy_result;
        private Button button_scale_result_txt;
        private Button button_scale_result;
        private Label label_BRSO;
        private TextBox textBox_BRSO_Map;
        private CheckBox checkBox_append_pitch_number;
        private Label label_center_key;
        private CheckBox checkBox1;
        private TextBox textBox_center_key;
        private Button button_BRSO_Key;
        private Label label_center_number;
        private TextBox textBox_center_number;
    }
}