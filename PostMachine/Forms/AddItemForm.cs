using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PostMachine
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.mainForm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var photos = new List<string>();
            var tempPhotos = textBox4.Text.Split(';');

            for ( int i = 0; i < tempPhotos.Length; i++)
                photos.Add(tempPhotos[i].Trim());

            Item item = new Item(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), photos);
            this.Close();
        }
    }
}
