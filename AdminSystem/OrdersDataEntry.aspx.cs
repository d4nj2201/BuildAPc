﻿using System;
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
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the full name
        AnOrder.Name = txtFullName.Text;
        //store the name in the session object.
        Session["AnName"] = AnOrder;
        //Navigate to the view page.
        Response.Redirect("Orders.aspx");
    }
}