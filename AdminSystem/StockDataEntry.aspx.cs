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
        string StockID = txtStockID.Text;
        //capture the description
        string Description = txtDescription.Text;
        //capture the last edited date
        string LastEdited = txtLastEdited.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the quantity
        string Quantity = txtQuantity.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(StockID, Description, LastEdited, Price, Quantity);
        if (Error == "")
        {
            //capture the StockID
            AStock.StockID = Convert.ToInt32(StockID);
            //capture the description
            AStock.Description = Description;
            //capture the last edited date
            AStock.LastEdited = Convert.ToDateTime(LastEdited);
            //capture the price
            AStock.Price = Convert.ToDouble(Price);
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //store the stock in the session object
            Session["AStock"] = AStock;
            //redirect to the viewer page
            Response.Redirect("StockViewer.aspx");//results view needs fixing
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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