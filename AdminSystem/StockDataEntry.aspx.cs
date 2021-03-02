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
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the StockID
        AStock.StockID = Convert.ToInt32(txtStockID.Text);
        //Store the stock ID in the session object
        Session["AStock"] = AStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 StockID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockID = Convert.ToInt32(txtStockID.Text);
        //find the record
        Found = AStock.Find(StockID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDescription.Text = AStock.Description;
            txtLastEdited.Text = AStock.LastEdited.ToString();
            txtPrice.Text = AStock.Price.ToString();
            txtQuantity.Text = AStock.Quantity.ToString();
            chkInStock.Checked = AStock.InStock;
        }
    }
}