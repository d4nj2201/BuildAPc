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
    Int32 StaffId1;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffId1 = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            if (StaffId1 != 1)
            {
                DisplayAddress();
            }
        }
    }

    private void DisplayAddress()
    {
        //create an instance of the address book
        clsStaffCollection StaffBook = new clsStaffCollection();
        // find the record to update
        StaffBook.ThisStaff.Find(StaffId1);
        // display the data for this record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtFullName.Text = StaffBook.ThisStaff.FullName;
        txtPhoneNumber.Text = StaffBook.ThisStaff.PhoneNumber;
        TxtDateOfBirth.Text = StaffBook.ThisStaff.DateOfBirth.ToString();
        txtHourlyWage.Text = StaffBook.ThisStaff.HourlyWage.ToString();
        chkIsWorking.Checked = StaffBook.ThisStaff.IsWorking;
    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        // create new instance 
        clsStaff AStaff = new clsStaff();
        // Capture Staff ID
        string StaffId = txtStaffId.Text;
        // Capture the full name
        string FullName = txtFullName.Text;
        // Capture the phone number
        string PhoneNumber = txtPhoneNumber.Text;
        // Capture the Hourly Wage
        string HourlyWage = txtHourlyWage.Text;
        // Capture Date of birth
        string DateOfBirth = TxtDateOfBirth.Text;
        // Set Error 
        string Error = " ";
        // validate the data
        Error = AStaff.Valid(StaffId, FullName, DateOfBirth, HourlyWage, PhoneNumber);
        if (Error == " ")
        {
            // Capture Staff ID
            AStaff.StaffId = StaffId1;
            // Capture the full name
            AStaff.FullName = FullName;
            // Capture the phone number
            AStaff.PhoneNumber = PhoneNumber;
            // Capture the Hourly Wage
            AStaff.HourlyWage = Convert.ToDouble(HourlyWage);
            // Capture Date of birth
            AStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            // Capture the is working button
            AStaff.IsWorking = chkIsWorking.Checked;
            //create a new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            
            // if this is a new record add the data
            if(StaffId1 == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId1);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
            //Navigate user to page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void txtPhoneNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // New instance of staff class
        clsStaff AStaff = new clsStaff();
        // variable to store primary key
        Int32 StaffId;
        // variable for the result
        Boolean Found = false;
        // get primary key entered by user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        // if found 
        if(Found == true)
        {
            txtStaffId.Text = AStaff.StaffId.ToString();
            txtFullName.Text = AStaff.FullName;
            txtPhoneNumber.Text = AStaff.PhoneNumber;
            txtHourlyWage.Text = AStaff.HourlyWage.ToString();
            TxtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
        }


    }

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }
}