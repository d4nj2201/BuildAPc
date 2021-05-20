<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 28px; top: 28px; position: absolute; height: 263px; width: 374px; bottom: 219px;"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 26px; top: 299px; position: absolute" Text="Add" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 74px; top: 300px; position: absolute; width: 45px; height: 25px; margin-bottom: 0px" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 364px; position: absolute; width: 56px; height: 20px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
