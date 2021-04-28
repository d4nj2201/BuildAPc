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
        // set name of primary key
        lstStaffList.DataValueField = "StaffId";
        // set the data field to display
        lstStaffList.DataTextField = "FullName";
        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != 1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedIndex);
            Session["StaffId"] = StaffId;
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store prim key
        Int32 StaffId;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFullName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFullName(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "PostCode";
        lstStaffList.DataBind();
    }
}