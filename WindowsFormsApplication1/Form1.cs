using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        emp obj = new emp();
        ArrayList arr = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            obj.Id = Convert.ToInt32(textBox1.Text);
            obj.Name = textBox2.Text;
            arr.Add(obj);
            textBox1.Text = "";
            textBox2.Text = "";
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

               textBox1.Text=obj.Id.ToString();
               textBox2.Text=obj.Name;


           

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = arr.ToString();
            MessageBox.Show(s);
        }

    }
}
