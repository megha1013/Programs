using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button b = new Button();
        b = (Button)sender;
        switch(b.ID)
        {
            case "Button1":
                Response.Write("button 1 clicked");
                break;
            case "Button2":
                Response.Write("button 2 clicked");
                break;
            case "Button3":
                Response.Write("button 3 clicked");
                break;
            default:
                Response.Write("Invalid Option");
                break;

        }
    }
}