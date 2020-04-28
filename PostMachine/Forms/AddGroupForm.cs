using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostMachine
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VkCommunity vkCommunity = new VkCommunity(textBox1.Text);
            this.Close();
        }

        private void AddGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.mainForm.Enabled = true;
        }
    }
}
