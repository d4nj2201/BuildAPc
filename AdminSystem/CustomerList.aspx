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
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 34px; top: 374px; position: absolute; height: 25px; width: 60px" Text="Apply" />
        <asp:ListBox ID="lstCustomerList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 28px; top: 28px; position: absolute; height: 263px; width: 374px; bottom: 219px;"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 26px; top: 299px; position: absolute; width: 44px; right: 509px;" Text="Add" />
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
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 73px; top: 300px; position: absolute; width: 46px; height: 25px; margin-bottom: 0px" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 404px; position: absolute; width: 56px; height: 21px; margin-bottom: 19px;"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 26px; top: 339px; position: absolute; width: 114px; height: 22px" Text="Enter a username"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 142px; top: 338px; position: absolute; width: 145px"></asp:TextBox>
        </p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 122px; top: 299px; position: absolute; width: 51px; height: 26px" Text="Delete" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 99px; top: 374px; position: absolute; width: 61px; height: 25px; right: 419px" Text="Clear" />
    </form>
</body>
</html>
