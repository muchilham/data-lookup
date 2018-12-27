using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lookup
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new DataLookUp().ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = session.primary;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
