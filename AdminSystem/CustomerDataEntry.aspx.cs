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
        clsCustomer ACustomer = new clsCustomer();
      
        ACustomer.CustomerId = Convert.ToInt16(txtCustomerId.Text);
        ACustomer.Username = txtUsername.Text;
        ACustomer.Password = txtPassword.Text;
        ACustomer.Address = txtAddress.Text;
        ACustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        ACustomer.Active = Convert.ToBoolean(chkActive.Checked);
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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
}