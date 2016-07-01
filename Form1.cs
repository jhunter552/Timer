using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Timer by Durgul
/// </summary>

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sets the minutes hours seconds varibles
        int hour, min, sec, ms=0;

        //if button 2 is clicked stop the program 
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
        }

        //is button3 is clicked reset all the text
        private void button3_Click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0; 
            label1.Text=0+":"+0+":" + 0 + ":" + "0";
        }

        //when the timer ticks, 
        //perform using if else to increment seconds minutes then hours 
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            ms++;
                if(ms>10)
            {
                sec++;
                ms = 0;
            }
                else
            {
                ms++;
            }
                if (min>60)
            {
                hour++;
                min = 0;
            }
        }

        //when button 1 is clicked start the program 
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
