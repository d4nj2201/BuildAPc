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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture the full name
        AnOrder.Name = txtFullName.Text;
        //store the name in the session object.
        Session["AnName"] = AnOrder;

        //capture the order ID
        AnOrder.ID = Convert.ToInt32(txtOrderID.Text);
        Session["AnID"] = AnOrder;
        //Navigate to the view page.

        //capture the address
        AnOrder.Town = txtAddress.Text;
        Session["AnAddress"] = AnOrder;

        //capture the customer ID
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Session["AnCustomerID"] = AnOrder;

        AnOrder.DateAdded = Convert.ToDateTime(txtDataAdded.Text);
        Session["AnDate"] = AnOrder;

        Response.Redirect("Orders.aspx");

        
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(ID);
        if (Found == true)
        {
            //display the vlaues of the properties in the form.
            txtOrderID.Text = Convert.ToString(AnOrder.ID);
            txtAddress.Text = AnOrder.Town;
            txtCustomerID.Text = Convert.ToString(AnOrder.CustomerID);
            txtDataAdded.Text = Convert.ToString(AnOrder.DateAdded);
            txtFullName.Text = AnOrder.Name;
            txtTotal.Text = Convert.ToString(AnOrder.Total);

        }
    }
}