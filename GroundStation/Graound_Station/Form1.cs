using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;
/*
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.WindowsForms.ToolTips;
*/

namespace Graound_Station
{
    public partial class Form1 : Form

    {
    
        public Form1()
        {
            InitializeComponent();
        }

       
        //Datagrid 
        int line = 0;

       //IO Ports Define
        string[] ports = SerialPort.GetPortNames();

        //Time Define 
        int split_second = 0, second = 0, minute = 0, hour = 0;
        string time = DateTime.Now.ToLongTimeString();
        DateTime date= DateTime.Now;



        private void Form1_Load(object sender, EventArgs e)
        {
            
            tempetureChart.Titles.Add("Temperature");
            humidityChart.Titles.Add("Humidity");
            altitudeChart.Titles.Add("Altitude");
            pressureChart.Titles.Add("Pressure");
            dofChart.Titles.Add("Pitch Yaw Roll");

            tempetureChart.ChartAreas[0].AxisY.Minimum= 0;
            tempetureChart.ChartAreas[0].AxisY.Maximum= 500;
            humidityChart.ChartAreas[0].AxisY.Minimum= 0;
            humidityChart.ChartAreas[0].AxisY.Maximum = 500;


            pressureChart.ChartAreas[0].AxisY.Minimum = 0;
            dofChart.ChartAreas[0].AxisY.Maximum = 500;
            altitudeChart.ChartAreas[0].AxisY.Minimum = 0;



            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 115200;


        }
        private void timer2_Tick(object sender, EventArgs e)
            
        {
            split_second++;
            
            //mission time
            
            if (split_second == 60)
            {
                split_second= 0;
                second++;
            }

            if (second == 60)
            {
                split_second= 0;
                second = 0;
                minute++;
                
            }

            if(minute == 60)
            {
                split_second = 0;
                second = 0;
                minute=0;
                hour++;
            }
              missionTimer.Text= string.Format("{0:D2}", hour) + 
                ":" + string.Format("{0:D2}", minute) + 
                ":" + string.Format("{0:D2}", second) +
                ":" + string.Format("{0:D2}", split_second);
             

        }

        //Disconnect Buton 
        private void disconnetBtn_Click(object sender, EventArgs e)
        {
            
            disconnectedpicture.Visible=true;
            connectedpicture.Visible=false;

            timer2.Stop();
           
            connectBTN.Enabled = true;
            if (connectBTN.Enabled = true)
            {
                disconnetBtn.Visible = false;
                disconnetBtn.Enabled = false;
            }
            disconnetBtn.Visible= false;
            if (serialPort1.IsOpen == true)
            {
                statuslbl.Text = "Disconnect";
                serialPort1.Close();
                timer1.Enabled= false;
            }
        }

  

        //Excel Transfer 
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            excel.Application exceldosya = new excel.Application();
            exceldosya.Visible = true;
            object missing = Type.Missing;
            excel.Workbook çalışmakitabı = exceldosya.Workbooks.Add(missing);
            excel.Worksheet sheet1 = (excel.Worksheet)çalışmakitabı.Sheets[1];
            int sutun = 1;
            int satır = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                excel.Range myrange = (excel.Range)sheet1.Cells[satır, sutun + j];
                myrange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            satır++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excel.Range myrange = (excel.Range)sheet1.Cells[satır + i, sutun + j];
                    myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myrange.Select();
                }
            }
        }

    

      

        private void emergenyBTN_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            emergencyStatusLabel.Text = "LED and Buzzer ON";
        }

        private void emergency_off_BTN_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            emergencyStatusLabel.Text = "LED and Buzzer OFF";

        }

        private void closedAPPBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        private void shrinkAppBtn_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Width= 800;
            form.Height = 600;
            form.ShowDialog();

        }
        */
     

        private void connectBTN_Click(object sender, EventArgs e)
        {

            disconnectedpicture.Visible =false;
            connectedpicture.Visible = true;
            timer1.Start();
            timer2.Start();
            serialPort1.Open();
            serialPort1.DataBits = 8; // try write code 

            serialPort1.Handshake = Handshake.None;
            serialPort1.RtsEnable = true;
            serialPort1.DtrEnable=true;
            disconnetBtn.Visible= true;
            disconnetBtn.Enabled = true;
            connectBTN.Enabled=false;

            statuslbl.Text = "Connection";

            try
            {
                if(serialPort1.IsOpen==false) 
                {
                    serialPort1.Open();
                }
            }
            catch(Exception) 
            {

                MessageBox.Show("Disconnected");
            }
            connectBTN.Enabled=false;
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (split_second>1&&split_second<60) {

                string arduino = serialPort1.ReadLine().ToString();
                string[] data = arduino.Split('/');
                temperatureLbl.Text = data[0] + "°C";
                humidityLbl.Text = data[1] + "%";


                line = dataGridView1.Rows.Add();

                for (int satır = 0; satır < dataGridView1.Rows.Count; satır++)

                {
                    dataGridView1.Rows[line].Cells[1].Value = DateTime.Now.ToLongTimeString();
                    dataGridView1.Rows[line].Cells[0].Value = DateTime.Now.ToLongDateString();
                    dataGridView1.Rows[line].Cells[2].Value = data[0];
                    dataGridView1.Rows[line].Cells[3].Value = data[1];

                    dataGridView1.Rows[line].Cells[4].Value = data[2];
                    dataGridView1.Rows[line].Cells[5].Value = data[3];

                    dataGridView1.Rows[line].Cells[6].Value = data[4];
                    dataGridView1.Rows[line].Cells[7].Value = data[5];
                    dataGridView1.Rows[line].Cells[8].Value = data[6];

                    //dataGridView1.Rows[line].Cells[9].Value = data[7];
                   // dataGridView1.Rows[line].Cells[10].Value = data[8];

                }

                if (data != null)
                {
                   
                
                    string dataspeed = data[2];
                    int speed = Convert.ToInt32(dataspeed);

                    string databattery = data[3];
                    int battery = Convert.ToInt32(databattery);

                    circularProgressBar1.Value = speed;
                    circularProgressBar1.Text = circularProgressBar1.Value.ToString() + " KM";
                    circularProgressBar2.Value = battery;
                    circularProgressBar2.Text = circularProgressBar2.Value.ToString() + " %";
              

                    this.tempetureChart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), data[0]);
                    this.pressureChart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), data[1]);
                 
                    this.altitudeChart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), data[5]);
                    this.humidityChart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), data[6]);
                    
                    this.dofChart.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), data[4]);
                    this.dofChart.Series[1].Points.AddXY(DateTime.Now.ToLongTimeString(), data[7]);
                    this.dofChart.Series[2].Points.AddXY(DateTime.Now.ToLongTimeString(), data[8]);
                }

                else {

                    MessageBox.Show("Data cannot be retrieved!"+"Try Again");

                   
                }
              
            }
          


        }

      
    }
}
