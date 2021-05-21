<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 65px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 276px" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 29px; top: 44px; position: absolute; height: 24px; width: 50px; right: 480px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 91px; top: 44px; position: absolute; width: 54px; height: 24px" Text="No" />
    </form>
</body>
</html>
