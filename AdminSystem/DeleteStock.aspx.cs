using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock Collection
        clsStockCollection AllStock = new clsStockCollection();
        //find the record to delete
        AllStock.ThisStock.Find(StockID);
        //delete the record
        AllStock.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}