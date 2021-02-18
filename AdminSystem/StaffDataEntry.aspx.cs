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

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        // create new instance 
        clsStaff AStaff = new clsStaff();
        // Capture Staff ID
        AStaff.StaffId = Convert.ToInt32(txtStafId.Text);
        // Capture the full name
        AStaff.FullName = txtFullName.Text;
        // Capture the phone number
        AStaff.PhoneNumber = txtPhoneNumber.Text;
        // Capture the Hourly Wage
        AStaff.HourlyWage = Convert.ToDouble(txtHourlyWage.Text);
        // Capture Date of birth
        AStaff.DateOfBirth = Convert.ToDateTime(TxtDateOfBirth.Text);
        // Capture the is working button
        AStaff.IsWorking = Convert.ToBoolean(chkIsWorking.Checked);
        //Store the data in the session object
        Session["AStaff"] = AStaff;
        //Navigate user to page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void txtPhoneNumber_TextChanged(object sender, EventArgs e)
    {

    }
}