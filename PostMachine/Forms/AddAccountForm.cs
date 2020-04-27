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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            VkAccount.AddAccount(login, password);
            this.Close();
        }

        private void AddAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.mainForm.Enabled = true;
        }
    }
}
