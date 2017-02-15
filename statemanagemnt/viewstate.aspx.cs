using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class viewstate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count;
        if(ViewState["count"]==null)
        {
            count = 1;
        }
        else
        {
            count = (int)ViewState["count"] + 1;

        }
        ViewState["count"] = count;
        Label1.Text = "count: " + count.ToString();
    }
}