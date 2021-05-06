using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using TestingOrders;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order ID etc...
        string ID = txtOrderID.Text;
        string CustomerID = txtCustomerID.Text;
        string Town = txtAddress.Text;
        string Name = txtFullName.Text;
        string DateAdded = txtDataAdded.Text;
        string Total = txtTotal.Text;
        //variable to store error msgs
        string Error = "";
        //validate the data.
        Error = AnOrder.Valid(ID, CustomerID, Town, Name, DateAdded, Total);
        if (Error == "")
        {
            AnOrder.ID = Convert.ToInt32(ID);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.Total = Convert.ToDouble(Total);
            AnOrder.Total = Convert.ToInt32(Total);
            AnOrder.Name = Name;
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.Delivered = chkDelivered.Checked;
            AnOrder.Payed = chkPayed.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");

        } else
        {
            lblError.Text = Error;
        }

        
        
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