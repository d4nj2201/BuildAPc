using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using TestingOrders;

public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page.
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this si sthe first time the page is displayed.
        if (IsPostBack == false)
        {
            //update the list box.
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the County Collection.
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "ID";
        lstOrderList.DataTextField = "Contents";
        lstOrderList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new reocrd.
        Session["ID"] = -1;
        //redirect to the data entry page.
        Response.Redirect("AnOrder.aspx");
    }
}