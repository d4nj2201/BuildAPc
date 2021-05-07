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
    Int32 ID;
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
        lstOrderList.DataTextField = "Town";
        lstOrderList.DataBind();
    }

   

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new reocrd.
        Session["ID"] = -1;
        //redirect to the data entry page.
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the PK of the record to be edited.
        Int32 ID;
        //if a record has been selected from the list.
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the pk value of the record to edit.
            ID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object.
            Session["ID"] = ID;
            //redirect to the edit page.
            Response.Redirect("AnOrder.aspx");
        } else //if no record has been selected.
        {
            //display an error.
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted.
        Int32 ID;
        //if a reocrd has been selected from the list.
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete.
            ID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object.
            Session["ID"] = ID;
            //redirect to the delete page.
            Response.Redirect("DeleteOrder.aspx");
        } else //if no record has been selected.
        {
            //display an erorr.
            lblError.Text = "Please select a record to delete from the list.";
        }
    }
}