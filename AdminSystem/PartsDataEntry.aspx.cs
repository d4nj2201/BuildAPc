using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create new instance of parts
        clsParts aPart = new clsParts();
        //capture PartId
        aPart.PartId = Convert.ToInt32(txtPartId.Text);
        //capture PartDescription
        aPart.PartDescription = txtPartDescription.Text;
        //capture PartType
        aPart.PartType = txtPartType.Text;
        //capture Price
        aPart.Price = Convert.ToDouble(txtPrice.Text);
        //capture DateAdded
        aPart.DateAdded = Convert.ToDateTime(txtDateAdded);
        //capture wattage
        aPart.Wattage = Convert.ToInt32(txtWattage);
        //capture availability
        aPart.Available = Convert.ToBoolean(chkAvailable.Checked);
        //store the description in the session object
        Session["aPart"] = aPart;
        //Navigate to viewer page
        Response.Redirect("PartsViewer.aspx");
    }
}