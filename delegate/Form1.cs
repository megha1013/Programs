using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace @delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 obj = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            obj.init();
            MessageBox.Show("refernce");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.invok();
        }
    }
}
