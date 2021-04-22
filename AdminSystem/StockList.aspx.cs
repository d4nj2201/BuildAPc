using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the Stock Collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the data field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edited
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ReportByDescription(txtDescription.Text);
        lstStockList.DataSource = AllStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the clsStockCollection class
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ReportByDescription("");
        //clear any existing filter to tidy up the interface
        txtDescription.Text = "";
        lstStockList.DataSource = AllStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();
    }
}