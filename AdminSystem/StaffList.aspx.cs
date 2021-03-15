using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{// this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }
    void DisplayStaff()
    {
        //create an instance of staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        // set the data source to list of staff in collection
        lstStaffList.DataSource = Staff.StaffList;
        //
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}