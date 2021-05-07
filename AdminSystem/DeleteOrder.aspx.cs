using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrders;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object.
        ID = Convert.ToInt32(Session["ID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete.
        Order.ThisOrder.Find(ID);
        //delete the record.
        Order.Delete();
        //redirect back to the main page.
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}