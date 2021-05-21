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
    Int32 CustomerId;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack==false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

        
    }

    private void DisplayCustomer()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data for this record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtUsername.Text = CustomerBook.ThisCustomer.Username.ToString();
        txtPassword.Text = CustomerBook.ThisCustomer.Password.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.Active;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the username
        string Username = txtUsername.Text;
        //capture the password
        string Password = txtPassword.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(Username, Password, Address, DateAdded);
        if (Error == "")
        {
            // ACustomer.CustomerId = Convert.ToInt16(txtCustomerId.Text);
            //capture the customerid
            ACustomer.CustomerId = CustomerId;
            //capture the username
            ACustomer.Username = Username;
            //capture the password
            ACustomer.Password = Password;
            //capture the address
            ACustomer.Address = Address;
            //capture the date added
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture whether active or not
            ACustomer.Active = chkActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
           
            //if this is a new record i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int16 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt16(txtCustomerId.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUsername.Text = ACustomer.Username;
            txtPassword.Text = ACustomer.Password;
            txtAddress.Text = ACustomer.Address;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            
        }

    }

    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}