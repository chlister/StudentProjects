using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Test af hvad der sker med et program når vi ligger main thread til at sove
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hvad sker der når vi laver en handling imens tråden sover
            label1.Text = "Hello";
        }
    }
}
