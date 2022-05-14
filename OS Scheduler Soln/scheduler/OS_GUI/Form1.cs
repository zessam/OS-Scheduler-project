using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Scheduler;

namespace OS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
        }

        private void lo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile;


        }

        private void chrload_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Algo_03_CheckedChanged(object sender, EventArgs e)
        {
            if (Algo_03.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void Selectionalgo_Click(object sender, EventArgs e)
        {
            Parser P = new Parser();
            List<Process> procs = P.ParseFile(openFileDialog1.FileName);
            MessageBox.Show("Done");
            int noofprocs = int.Parse(richTextBox1.Lines[0]);
            if(Algo_01.Checked)
            {
                MessageBox.Show("Non preemptive hpf");
                CScheduler sched = new CScheduler();
                sched.ReadyQueue = procs;
                MessageBox.Show("Loadded");
                List<Process> procsfinal = sched.HighestPriority();
                MessageBox.Show(Convert.ToString(procsfinal[0].TurnAround));
                foreach (var proc in procsfinal)
                {
                    chart1.Series["FinalTime"].Points.AddXY("Proccess", proc.FinalTime);
                }
            }
            else if(Algo_02.Checked)
            {
                MessageBox.Show("FCFS");
                CScheduler sched = new CScheduler();
                sched.ReadyQueue = procs;
                MessageBox.Show("Loadded");
                List<Process> procsfinal= sched.FCFS();
                MessageBox.Show(Convert.ToString(procsfinal[0].TurnAround));
                foreach(var proc in procsfinal)
                {
                    chart1.Series["FinalTime"].Points.AddXY("Proccess", proc.FinalTime);
                }
                
            }
            else if (Algo_03.Checked)
            {
                
                int quantum = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Robin with quanta " + quantum);
                CScheduler sched = new CScheduler();
                sched.ReadyQueue = procs;
                MessageBox.Show("Loadded");
                List<Process> procsfinal = sched.RoundRobin(quantum);
                MessageBox.Show(Convert.ToString(procsfinal[0].TurnAround));
                foreach (var proc in procsfinal)
                {
                    chart1.Series["FinalTime"].Points.AddXY("Proccess", proc.FinalTime);
                }

            }
            else if(Algo_04.Checked)
            {
                MessageBox.Show("preemptive sjf");
                CScheduler sched = new CScheduler();
                sched.ReadyQueue = procs;
                MessageBox.Show("Loadded");
                sched.PreemptiveSRTF();
            }



        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
