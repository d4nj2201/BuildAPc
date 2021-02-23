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
}