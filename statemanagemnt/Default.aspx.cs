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
        int i = 1;
        if (HiddenField1.Value == String.Empty) // hidden field used for small amount of data.. used at client side!
        {
            HiddenField1.Value = i.ToString();
        }

        else
        {
            HiddenField1.Value = (Convert.ToInt32(HiddenField1.Value) + 1).ToString();

        }
        Label1.Text = HiddenField1.Value;
    }
}