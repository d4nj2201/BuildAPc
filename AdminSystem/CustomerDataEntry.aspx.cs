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
            //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;
            //add the new record
            CustomerList.Add();
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
}