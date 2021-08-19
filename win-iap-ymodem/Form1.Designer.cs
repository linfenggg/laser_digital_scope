namespace win_iap_ymodem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Port = new System.Windows.Forms.Button();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Bps = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.cbx_Port = new System.Windows.Forms.ComboBox();
            this.cbx_Baud = new System.Windows.Forms.ComboBox();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbx_PageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SCOPE = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbx_show = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SCOPE.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Port
            // 
            this.btn_Port.Location = new System.Drawing.Point(305, 32);
            this.btn_Port.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(181, 40);
            this.btn_Port.TabIndex = 0;
            this.btn_Port.Text = "Connect";
            this.btn_Port.UseVisualStyleBackColor = true;
            this.btn_Port.Click += new System.EventHandler(this.btn_Port_Click);
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(41, 29);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(103, 15);
            this.lbl_Port.TabIndex = 1;
            this.lbl_Port.Text = "Serial_Port:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "bin文件(*.bin)|*.bin|hex文件(*.hex)|*.hex";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lbl_Bps
            // 
            this.lbl_Bps.AutoSize = true;
            this.lbl_Bps.Location = new System.Drawing.Point(41, 61);
            this.lbl_Bps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bps.Name = "lbl_Bps";
            this.lbl_Bps.Size = new System.Drawing.Size(79, 15);
            this.lbl_Bps.TabIndex = 3;
            this.lbl_Bps.Text = "Baudrate:";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(10, 35);
            this.lbl_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(39, 15);
            this.lbl_Pass.TabIndex = 4;
            this.lbl_Pass.Text = "path";
            // 
            // cbx_Port
            // 
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Location = new System.Drawing.Point(153, 26);
            this.cbx_Port.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Port.Name = "cbx_Port";
            this.cbx_Port.Size = new System.Drawing.Size(105, 23);
            this.cbx_Port.TabIndex = 5;
            this.cbx_Port.DropDown += new System.EventHandler(this.cbx_Port_DropDown);
            // 
            // cbx_Baud
            // 
            this.cbx_Baud.FormattingEnabled = true;
            this.cbx_Baud.Items.AddRange(new object[] {
            "Custom",
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbx_Baud.Location = new System.Drawing.Point(153, 58);
            this.cbx_Baud.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Baud.Name = "cbx_Baud";
            this.cbx_Baud.Size = new System.Drawing.Size(105, 23);
            this.cbx_Baud.TabIndex = 6;
            // 
            // txb_FilePath
            // 
            this.txb_FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txb_FilePath.Location = new System.Drawing.Point(57, 33);
            this.txb_FilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txb_FilePath.Name = "txb_FilePath";
            this.txb_FilePath.Size = new System.Drawing.Size(156, 25);
            this.txb_FilePath.TabIndex = 7;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(242, 29);
            this.btn_SelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(85, 29);
            this.btn_SelectFile.TabIndex = 8;
            this.btn_SelectFile.Text = "file";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Port);
            this.groupBox1.Controls.Add(this.lbl_Bps);
            this.groupBox1.Controls.Add(this.lbl_Port);
            this.groupBox1.Controls.Add(this.cbx_Port);
            this.groupBox1.Controls.Add(this.cbx_Baud);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(536, 107);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "com";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Update.Location = new System.Drawing.Point(384, 23);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(131, 35);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "UpDate";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.cbx_PageSize);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_Pass);
            this.groupBox3.Controls.Add(this.btn_SelectFile);
            this.groupBox3.Controls.Add(this.txb_FilePath);
            this.groupBox3.Controls.Add(this.btn_Update);
            this.groupBox3.Location = new System.Drawing.Point(561, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(577, 107);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Firmware update";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(228, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 24);
            this.progressBar1.TabIndex = 16;
            // 
            // cbx_PageSize
            // 
            this.cbx_PageSize.FormattingEnabled = true;
            this.cbx_PageSize.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024"});
            this.cbx_PageSize.Location = new System.Drawing.Point(129, 76);
            this.cbx_PageSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_PageSize.Name = "cbx_PageSize";
            this.cbx_PageSize.Size = new System.Drawing.Size(84, 23);
            this.cbx_PageSize.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "packet lenght";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "time（s）";
            chartArea4.AxisY.Maximum = 300D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "I(mA)";
            chartArea4.AxisY2.Maximum = 40D;
            chartArea4.AxisY2.Minimum = 10D;
            chartArea4.AxisY2.Title = "temp";
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.IsDockedInsideChartArea = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(11, 103);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.IsXValueIndexed = true;
            series16.Legend = "Legend1";
            series16.Name = "LD_CURRENT";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "PUMP_CURRENT";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "LD_TEMP";
            series18.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "PUMP_TEMP";
            series19.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "BAORD_TEMP";
            series20.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Size = new System.Drawing.Size(709, 485);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "capture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SCOPE
            // 
            this.SCOPE.Controls.Add(this.button4);
            this.SCOPE.Controls.Add(this.button3);
            this.SCOPE.Controls.Add(this.checkBox4);
            this.SCOPE.Controls.Add(this.checkBox6);
            this.SCOPE.Controls.Add(this.checkBox5);
            this.SCOPE.Controls.Add(this.checkBox3);
            this.SCOPE.Controls.Add(this.checkBox2);
            this.SCOPE.Controls.Add(this.checkBox1);
            this.SCOPE.Controls.Add(this.chart1);
            this.SCOPE.Controls.Add(this.button2);
            this.SCOPE.Location = new System.Drawing.Point(12, 127);
            this.SCOPE.Name = "SCOPE";
            this.SCOPE.Size = new System.Drawing.Size(734, 678);
            this.SCOPE.TabIndex = 20;
            this.SCOPE.TabStop = false;
            this.SCOPE.Text = "CURVE";
            this.SCOPE.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 625);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 42);
            this.button4.TabIndex = 28;
            this.button4.Text = "SCREENSHOT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 42);
            this.button3.TabIndex = 27;
            this.button3.Text = "SAVE TO FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(388, 41);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(85, 19);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "OV_TEMP";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(265, 66);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(101, 19);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "PUMP_TEMP";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(388, 66);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(109, 19);
            this.checkBox5.TabIndex = 24;
            this.checkBox5.Text = "BOARD_TEMP";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(265, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 19);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "LD_TEMP";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(118, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 19);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "PUMP_CUR";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(118, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 19);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "LD_CUR";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.tbx_show);
            this.groupBox2.Location = new System.Drawing.Point(751, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 677);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "TEMP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "OV";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(237, 432);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 45);
            this.button6.TabIndex = 30;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 444);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 25);
            this.textBox5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "CURRENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "TEMP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "PUMP";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 34);
            this.button5.TabIndex = 24;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 25);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 25);
            this.textBox4.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "CURRENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "TEMP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "LD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "log_out";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 25);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 25);
            this.textBox1.TabIndex = 12;
            // 
            // tbx_show
            // 
            this.tbx_show.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbx_show.Location = new System.Drawing.Point(30, 566);
            this.tbx_show.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_show.Multiline = true;
            this.tbx_show.Name = "tbx_show";
            this.tbx_show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_show.Size = new System.Drawing.Size(304, 95);
            this.tbx_show.TabIndex = 10;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(240, 60);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(85, 19);
            this.checkBox7.TabIndex = 33;
            this.checkBox7.Text = "powe_on";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(237, 236);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(85, 19);
            this.checkBox8.TabIndex = 34;
            this.checkBox8.Text = "powe_on";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1151, 852);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SCOPE);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Digital_Scope ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.SCOPE.ResumeLayout(false);
            this.SCOPE.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.Label lbl_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_Bps;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.ComboBox cbx_Port;
        private System.Windows.Forms.ComboBox cbx_Baud;
        private System.Windows.Forms.TextBox txb_FilePath;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbx_PageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox SCOPE;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbx_show;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
    }
}

