using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["test"].Value = TextBox1.Text;
        Response.Cookies["test"].Expires = DateTime.Now.AddYears(5);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Cookies["test"].Expires = DateTime.Now.AddYears(-30);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["test"] == null)
            TextBox2.Text = "No record found";
        else
            TextBox2.Text = Request.Cookies["test"].Value;
    }
}