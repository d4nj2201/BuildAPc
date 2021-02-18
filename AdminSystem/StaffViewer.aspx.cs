using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //Create a new instance
        clsStaff AStaff = new clsStaff();
        // Get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        // Display the name for this entry
        Response.Write(AStaff.StaffId + " ");
        Response.Write(AStaff.FullName+" ");
        Response.Write(AStaff.PhoneNumber+" ");
        Response.Write(AStaff.HourlyWage+" ");
        Response.Write(AStaff.DateOfBirth+" ");
        Response.Write(AStaff.IsWorking + " ");
    }
}