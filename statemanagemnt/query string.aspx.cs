using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class query_string : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //diff bw server.transfer and response.redirect
    protected void Button1_Click(object sender, EventArgs e)
    {
      //  Server.Transfer("string2.aspx?name=" + this.TextBox1.Text + "&color=" + this.TextBox2.Text);
        Response.Redirect("string2.aspx?name=" + this.TextBox1.Text + "&color=" + this.TextBox2.Text);
    }
}