using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StockID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the address book
        clsStockCollection AllStock = new clsStockCollection();
        //find the record to update
        AllStock.ThisStock.Find(StockID);
        //display the data for this record
        txtStockID.Text = AllStock.ThisStock.StockID.ToString();
        txtDescription.Text = AllStock.ThisStock.Description;
        txtLastEdited.Text = AllStock.ThisStock.LastEdited.ToString();
        txtPrice.Text = AllStock.ThisStock.Price.ToString();
        txtQuantity.Text = AllStock.ThisStock.Quantity.ToString();
        chkInStock.Checked = AllStock.ThisStock.InStock;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the StockID
        //string StockID = txtStockID.Text;
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
        Error = AStock.Valid(StockID.ToString(), Description, LastEdited, Price, Quantity);
        if (Error == "")
        {
            //capture the StockID
            AStock.StockID = StockID;
            //capture the description
            AStock.Description = Description;
            //capture the last edited date
            AStock.LastEdited = Convert.ToDateTime(LastEdited);
            //capture the price
            AStock.Price = Convert.ToDouble(Price);
            //capture the quantity
            AStock.Quantity = Convert.ToInt32(Quantity);
            //capture instock
            AStock.InStock = chkInStock.Checked;
            //create an instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            if (StockID == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockID);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            //redirect to the list page
            Response.Redirect("StockList.aspx");//results view needs fixing
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}