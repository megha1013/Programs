using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class string2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strname = Request.QueryString["name"];
        string strcolor = Request.QueryString["color"];
        Label1.Text = "You have Requested a"  + " " + strcolor + " " + strname;
    }
}