using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChineseTrainer
{
    public partial class ChineseTrainer : Form
    {

        private bool up;
        private bool run;
        private bool timer1_merker;
        private bool timer2_merker;
        private Rectangle rect;

        public ChineseTrainer()
        {
            InitializeComponent();
        }

        private void ChineseTrainer_Load(object sender, EventArgs e)
        {
            //dataSet11.ReadXml("VokabDB.xml");
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Hey, cooool";
            //notifyIcon1.Icon = new Icon(GetType(), "Icon.ico");

            rect = Screen.GetWorkingArea(this);
            int diff = Screen.PrimaryScreen.Bounds.Height - rect.Height;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, Screen.PrimaryScreen.Bounds.Height - this.Size.Height - diff);

            this.Opacity = 0;
            up = true;
            run = true;
            timer1.Enabled = true;
            timer2.Enabled = false;
            Debug.Write("Load\n");

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((this.Opacity > 0.0f) && (up == false))
            {
                this.Opacity -= 0.1f;
                Debug.Write("runter: timer2.enabled: " + timer2.Enabled + "\n");
            } else            
            if ((this.Opacity < 1.0f) && (up == true))
            {
                this.Opacity += 0.1f;
                Debug.Write("rauf: timer2.enabled: " + timer2.Enabled + "\n");
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                if (up == true) 
                    up = false;
                else 
                    up = true;
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void ChineseTrainer_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = timer1_merker;
            timer2.Enabled = timer2_merker;
        }

        private void ChineseTrainer_MouseHover(object sender, EventArgs e)
        {
            timer1_merker = timer1.Enabled;
            timer2_merker = timer2.Enabled;
            timer1.Enabled = false;
            timer2.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mExit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            this.Dispose();
        }

        private void mStartStop_Click(object sender, EventArgs e)
        {
            if (run == true)
            {
                timer1_merker = timer1.Enabled;
                timer2_merker = timer2.Enabled;
                timer1.Enabled = false;
                timer2.Enabled = false;
                mStartStop.Text = "Start";
                run = false;
                this.Visible = false;
            }
            else
            {
                timer1.Enabled = timer1_merker;
                timer2.Enabled = timer2_merker;
                mStartStop.Text = "Stop";
                run = true;
                this.Visible = true;
            }


        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2(ref dataSet1);
            f.Activate();
            f.Show();
        }

        
    }
}