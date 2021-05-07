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
    Int32 ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if (ID != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order.
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update.
        Order.ThisOrder.Find(ID);
        //display the data for this record.
        txtOrderID.Text = Order.ThisOrder.ID.ToString();
        txtCustomerID.Text = Order.ThisOrder.CustomerID.ToString();
        txtDataAdded.Text = Order.ThisOrder.DateAdded.ToString();
        txtFullName.Text = Order.ThisOrder.Name;
        txtAddress.Text = Order.ThisOrder.Town;
        txtTotal.Text = Order.ThisOrder.Total.ToString();
        chkDelivered.Checked = Order.ThisOrder.Delivered;
        chkPayed.Checked = Order.ThisOrder.Payed;
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
            AnOrder.Town = Town;
            AnOrder.Name = Name;
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.Total = Convert.ToDouble(Total);
            AnOrder.Delivered = chkDelivered.Checked;
            AnOrder.Payed = chkPayed.Checked;
            //create a new instance of the order collection.
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. ID = -1 then add the data.
            if (Convert.ToInt32(ID) == -1)
            {
                //set the thisOrder property.
                OrderList.ThisOrder = AnOrder;
                //add the new record.
                OrderList.Add();
            }
            //other it must be an update
            else
            {
                //find the record to update.
                OrderList.ThisOrder.Find(Convert.ToInt32(ID));
                //set the thisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the list page.
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