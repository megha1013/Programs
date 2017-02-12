using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public delegate void del();
    public class Class1
    {
        del obj;
        Class2 oo = new Class2();
        public void init()
        {
            obj += new del(xx);
            obj += new del(yy);
            obj += new del(oo.zz);

        }
        public void invok()
        {
            obj();
        }
        public void xx()
        {
            MessageBox.Show("xx method");
        }
        public void yy()
        {
            MessageBox.Show("yy method");
        }
    }
    public class Class2
    {
        public void zz()
        {
            MessageBox.Show("zz method");
        }
    }
}
