using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace PostMachine
{
    public partial class Form1 : Form
    {

        public static Int32 ThreadCount { get; private set; }
        private static List<Thread> Threads = new List<Thread>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { ThreadCount = Convert.ToInt32(textBox1.Text); } 
            catch { ThreadCount = 1; }

            for(int i = 0; i < ThreadCount; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Driver.Start));
                Threads.Add(thread);
                thread.Start(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
