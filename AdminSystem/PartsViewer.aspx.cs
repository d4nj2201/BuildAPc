using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsParts
        clsParts aPart = new clsParts();
        //get data from session object
        aPart = (clsParts)Session["aPart"];
        //display part description for this entry
        Response.Write(aPart.PartDescription);
    }
}