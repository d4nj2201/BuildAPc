﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using TestingOrders;

public partial class _1Viewer : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //Createa  new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object.
        AnOrder = (clsOrder)Session["AnName"];
        AnOrder = (clsOrder)Session["AnID"];
        AnOrder = (clsOrder)Session["AnAddress"];
        AnOrder = (clsOrder)Session["AnCustomerID"];
        AnOrder = (clsOrder)Session["AnDate"];
        //display the full name for this entry
        Response.Write(AnOrder.Name);
        Response.Write(AnOrder.ID);
        Response.Write(AnOrder.Town);
        Response.Write(AnOrder.CustomerID);
        Response.Write(AnOrder.DateAdded);

     
    }


}