using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graound_Station
{
    public partial class Form2 : Form
    {
        public Form2()


        {
           
            InitializeComponent();
        }
        Form1 mainform = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width+= 3;
            if (panel1.Width >= 796) {
                
                timer1.Stop(); 
                mainform.Show();
                this.Hide();
               // Form1 loadingForm = new Form1();
                //loadingForm.Close();
                




            }

            
        }
    }
}
