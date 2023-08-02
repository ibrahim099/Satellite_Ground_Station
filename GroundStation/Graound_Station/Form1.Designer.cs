namespace Graound_Station
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.disconnectedpicture = new System.Windows.Forms.PictureBox();
            this.connectedpicture = new System.Windows.Forms.PictureBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.missionTimer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.disconnetBtn = new System.Windows.Forms.Button();
            this.connectBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.dofChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.altitudeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.humidityLbl = new System.Windows.Forms.Label();
            this.temperatureLbl = new System.Windows.Forms.Label();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempetureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.emergenyBTN = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.emergencyStatusLabel = new System.Windows.Forms.Label();
            this.emergency_off_BTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.closedAPPBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectedpicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dofChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitudeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempetureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closedAPPBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 212);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Graound_Station.Properties.Resources.img_icons8;
            this.pictureBox1.Location = new System.Drawing.Point(584, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(584, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(107, 92);
            this.panel6.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Graound_Station.Properties.Resources.png_transparent_excel_logo_logos_logos_and_brands_icon_thumbnail;
            this.pictureBox4.Location = new System.Drawing.Point(26, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(113)))), ((int)(((byte)(245)))));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Excel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(17)))));
            this.panel4.Controls.Add(this.disconnectedpicture);
            this.panel4.Controls.Add(this.connectedpicture);
            this.panel4.Controls.Add(this.statuslbl);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(377, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 108);
            this.panel4.TabIndex = 1;
            // 
            // disconnectedpicture
            // 
            this.disconnectedpicture.Image = global::Graound_Station.Properties.Resources.img3;
            this.disconnectedpicture.Location = new System.Drawing.Point(49, 53);
            this.disconnectedpicture.Name = "disconnectedpicture";
            this.disconnectedpicture.Size = new System.Drawing.Size(100, 50);
            this.disconnectedpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disconnectedpicture.TabIndex = 9;
            this.disconnectedpicture.TabStop = false;
            // 
            // connectedpicture
            // 
            this.connectedpicture.Image = global::Graound_Station.Properties.Resources.img2;
            this.connectedpicture.Location = new System.Drawing.Point(49, 53);
            this.connectedpicture.Name = "connectedpicture";
            this.connectedpicture.Size = new System.Drawing.Size(100, 50);
            this.connectedpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectedpicture.TabIndex = 8;
            this.connectedpicture.TabStop = false;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.BackColor = System.Drawing.Color.Transparent;
            this.statuslbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.ForeColor = System.Drawing.Color.MintCream;
            this.statuslbl.Location = new System.Drawing.Point(3, 18);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(66, 21);
            this.statuslbl.TabIndex = 7;
            this.statuslbl.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Connection Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.missionTimer);
            this.panel3.Location = new System.Drawing.Point(377, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 92);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mission Timer";
            // 
            // missionTimer
            // 
            this.missionTimer.AutoSize = true;
            this.missionTimer.BackColor = System.Drawing.Color.Transparent;
            this.missionTimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missionTimer.ForeColor = System.Drawing.Color.MintCream;
            this.missionTimer.Location = new System.Drawing.Point(27, 32);
            this.missionTimer.Name = "missionTimer";
            this.missionTimer.Size = new System.Drawing.Size(145, 27);
            this.missionTimer.TabIndex = 6;
            this.missionTimer.Text = "00:00:00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.disconnetBtn);
            this.panel2.Controls.Add(this.connectBTN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 206);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Graound_Station.Properties.Resources.img1;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // disconnetBtn
            // 
            this.disconnetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.disconnetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disconnetBtn.ForeColor = System.Drawing.Color.MintCream;
            this.disconnetBtn.Location = new System.Drawing.Point(17, 135);
            this.disconnetBtn.Name = "disconnetBtn";
            this.disconnetBtn.Size = new System.Drawing.Size(326, 48);
            this.disconnetBtn.TabIndex = 6;
            this.disconnetBtn.Text = "DISCONNECT";
            this.disconnetBtn.UseVisualStyleBackColor = false;
            this.disconnetBtn.Visible = false;
            this.disconnetBtn.Click += new System.EventHandler(this.disconnetBtn_Click);
            // 
            // connectBTN
            // 
            this.connectBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(198)))));
            this.connectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectBTN.ForeColor = System.Drawing.Color.MintCream;
            this.connectBTN.Location = new System.Drawing.Point(28, 135);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(315, 48);
            this.connectBTN.TabIndex = 4;
            this.connectBTN.Text = "CONNECT";
            this.connectBTN.UseVisualStyleBackColor = false;
            this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUD RATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(119, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM3 ",
            "COM5",
            "COM4",
            "COM8"});
            this.comboBox1.Location = new System.Drawing.Point(119, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(454, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "0,0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dofChart);
            this.panel5.Controls.Add(this.pressureChart);
            this.panel5.Controls.Add(this.altitudeChart);
            this.panel5.Controls.Add(this.humidityLbl);
            this.panel5.Controls.Add(this.temperatureLbl);
            this.panel5.Controls.Add(this.humidityChart);
            this.panel5.Controls.Add(this.tempetureChart);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(6, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 824);
            this.panel5.TabIndex = 1;
            // 
            // dofChart
            // 
            this.dofChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.MidnightBlue;
            chartArea1.Name = "ChartArea1";
            this.dofChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dofChart.Legends.Add(legend1);
            this.dofChart.Location = new System.Drawing.Point(3, 518);
            this.dofChart.Name = "dofChart";
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "PİTCH";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "ROLL";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "YAW";
            this.dofChart.Series.Add(series1);
            this.dofChart.Series.Add(series2);
            this.dofChart.Series.Add(series3);
            this.dofChart.Size = new System.Drawing.Size(1230, 295);
            this.dofChart.TabIndex = 31;
            this.dofChart.Text = "chart1";
            title1.Name = "Sıcaklık";
            this.dofChart.Titles.Add(title1);
            // 
            // pressureChart
            // 
            this.pressureChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.MidnightBlue;
            chartArea2.Name = "ChartArea1";
            this.pressureChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pressureChart.Legends.Add(legend2);
            this.pressureChart.Location = new System.Drawing.Point(675, 260);
            this.pressureChart.Name = "pressureChart";
            series4.BackSecondaryColor = System.Drawing.Color.Transparent;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Pressure";
            this.pressureChart.Series.Add(series4);
            this.pressureChart.Size = new System.Drawing.Size(558, 252);
            this.pressureChart.TabIndex = 30;
            this.pressureChart.Text = "chart1";
            title2.Name = "Sıcaklık";
            this.pressureChart.Titles.Add(title2);
            // 
            // altitudeChart
            // 
            this.altitudeChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.MidnightBlue;
            chartArea3.Name = "ChartArea1";
            this.altitudeChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.altitudeChart.Legends.Add(legend3);
            this.altitudeChart.Location = new System.Drawing.Point(675, 12);
            this.altitudeChart.Name = "altitudeChart";
            this.altitudeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.BackSecondaryColor = System.Drawing.Color.Transparent;
            series5.BorderColor = System.Drawing.Color.Transparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            series5.Legend = "Legend1";
            series5.Name = "Altitude";
            this.altitudeChart.Series.Add(series5);
            this.altitudeChart.Size = new System.Drawing.Size(558, 242);
            this.altitudeChart.TabIndex = 29;
            this.altitudeChart.Text = "chart3";
            title3.Name = "Sıcaklık";
            this.altitudeChart.Titles.Add(title3);
            // 
            // humidityLbl
            // 
            this.humidityLbl.AutoSize = true;
            this.humidityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.humidityLbl.Location = new System.Drawing.Point(567, 359);
            this.humidityLbl.Name = "humidityLbl";
            this.humidityLbl.Size = new System.Drawing.Size(39, 32);
            this.humidityLbl.TabIndex = 28;
            this.humidityLbl.Text = "%";
            // 
            // temperatureLbl
            // 
            this.temperatureLbl.AutoSize = true;
            this.temperatureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temperatureLbl.Location = new System.Drawing.Point(567, 80);
            this.temperatureLbl.Name = "temperatureLbl";
            this.temperatureLbl.Size = new System.Drawing.Size(45, 32);
            this.temperatureLbl.TabIndex = 26;
            this.temperatureLbl.Text = "°C";
            // 
            // humidityChart
            // 
            this.humidityChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.MidnightBlue;
            chartArea4.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.humidityChart.Legends.Add(legend4);
            this.humidityChart.Location = new System.Drawing.Point(3, 260);
            this.humidityChart.Name = "humidityChart";
            series6.BackSecondaryColor = System.Drawing.Color.Transparent;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "Humidity";
            this.humidityChart.Series.Add(series6);
            this.humidityChart.Size = new System.Drawing.Size(558, 252);
            this.humidityChart.TabIndex = 25;
            this.humidityChart.Text = "chart1";
            title4.Name = "Sıcaklık";
            this.humidityChart.Titles.Add(title4);
            // 
            // tempetureChart
            // 
            this.tempetureChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.MidnightBlue;
            chartArea5.Name = "ChartArea1";
            this.tempetureChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.tempetureChart.Legends.Add(legend5);
            this.tempetureChart.Location = new System.Drawing.Point(3, 12);
            this.tempetureChart.Name = "tempetureChart";
            this.tempetureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.BackSecondaryColor = System.Drawing.Color.Transparent;
            series7.BorderColor = System.Drawing.Color.Transparent;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            series7.Legend = "Legend1";
            series7.Name = "Temperature";
            this.tempetureChart.Series.Add(series7);
            this.tempetureChart.Size = new System.Drawing.Size(558, 242);
            this.tempetureChart.TabIndex = 24;
            this.tempetureChart.Text = "chart3";
            title5.Name = "Sıcaklık";
            this.tempetureChart.Titles.Add(title5);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Altitude,
            this.Pressure,
            this.Pitch,
            this.Roll,
            this.Yaw});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1330, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 553);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Time";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Temperature";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Humidity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.MinimumWidth = 6;
            this.Altitude.Name = "Altitude";
            this.Altitude.Width = 125;
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Pressure";
            this.Pressure.MinimumWidth = 6;
            this.Pressure.Name = "Pressure";
            this.Pressure.Width = 125;
            // 
            // Pitch
            // 
            this.Pitch.HeaderText = "Pitch";
            this.Pitch.MinimumWidth = 6;
            this.Pitch.Name = "Pitch";
            this.Pitch.Width = 125;
            // 
            // Roll
            // 
            this.Roll.HeaderText = "Roll";
            this.Roll.MinimumWidth = 6;
            this.Roll.Name = "Roll";
            this.Roll.Width = 125;
            // 
            // Yaw
            // 
            this.Yaw.HeaderText = "Yaw";
            this.Yaw.MinimumWidth = 6;
            this.Yaw.Name = "Yaw";
            this.Yaw.Width = 125;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(1330, 230);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Honeydew;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(5)))), ((int)(((byte)(230)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(268, 227);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 27;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // emergenyBTN
            // 
            this.emergenyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.emergenyBTN.Location = new System.Drawing.Point(38, 119);
            this.emergenyBTN.Name = "emergenyBTN";
            this.emergenyBTN.Size = new System.Drawing.Size(95, 40);
            this.emergenyBTN.TabIndex = 28;
            this.emergenyBTN.Text = "ON";
            this.emergenyBTN.UseVisualStyleBackColor = false;
            this.emergenyBTN.Click += new System.EventHandler(this.emergenyBTN_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.emergencyStatusLabel);
            this.panel7.Controls.Add(this.emergency_off_BTN);
            this.panel7.Controls.Add(this.emergenyBTN);
            this.panel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(710, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 212);
            this.panel7.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.MintCream;
            this.label9.Location = new System.Drawing.Point(34, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "EMERGENCY BUTTON";
            // 
            // emergencyStatusLabel
            // 
            this.emergencyStatusLabel.AutoSize = true;
            this.emergencyStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.emergencyStatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyStatusLabel.ForeColor = System.Drawing.Color.MintCream;
            this.emergencyStatusLabel.Location = new System.Drawing.Point(34, 79);
            this.emergencyStatusLabel.Name = "emergencyStatusLabel";
            this.emergencyStatusLabel.Size = new System.Drawing.Size(73, 20);
            this.emergencyStatusLabel.TabIndex = 30;
            this.emergencyStatusLabel.Text = "ON/OFF";
            // 
            // emergency_off_BTN
            // 
            this.emergency_off_BTN.BackColor = System.Drawing.Color.Red;
            this.emergency_off_BTN.Location = new System.Drawing.Point(175, 119);
            this.emergency_off_BTN.Name = "emergency_off_BTN";
            this.emergency_off_BTN.Size = new System.Drawing.Size(90, 39);
            this.emergency_off_BTN.TabIndex = 29;
            this.emergency_off_BTN.Text = "OFF";
            this.emergency_off_BTN.UseVisualStyleBackColor = false;
            this.emergency_off_BTN.Click += new System.EventHandler(this.emergency_off_BTN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1714, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "BATTERY";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(1633, 221);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Honeydew;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(268, 227);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 33;
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(5)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(1425, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "SPEED";
            // 
            // closedAPPBtn
            // 
            this.closedAPPBtn.Image = global::Graound_Station.Properties.Resources.icons8_exit_64;
            this.closedAPPBtn.Location = new System.Drawing.Point(1942, 12);
            this.closedAPPBtn.Name = "closedAPPBtn";
            this.closedAPPBtn.Size = new System.Drawing.Size(45, 43);
            this.closedAPPBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closedAPPBtn.TabIndex = 28;
            this.closedAPPBtn.TabStop = false;
            this.closedAPPBtn.Click += new System.EventHandler(this.closedAPPBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1265, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "m";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1265, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 32);
            this.label11.TabIndex = 34;
            this.label11.Text = "Pa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.closedAPPBtn);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Satellite ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectedpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectedpicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dofChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitudeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempetureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closedAPPBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label missionTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button disconnetBtn;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempetureChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button emergenyBTN;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label emergencyStatusLabel;
        private System.Windows.Forms.Button emergency_off_BTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.PictureBox closedAPPBtn;
        private System.Windows.Forms.Label humidityLbl;
        private System.Windows.Forms.Label temperatureLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox connectedpicture;
        private System.Windows.Forms.PictureBox disconnectedpicture;
        private System.Windows.Forms.DataVisualization.Charting.Chart dofChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart altitudeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}

