<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 313px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 310px">
            <asp:Label ID="lblCustomerId" runat="server" height="19px" style="z-index: 1; left: 40px; top: 33px; position: absolute" Text="CustomerId" width="71px"></asp:Label>
            <asp:Label ID="lblUsername" runat="server" height="19px" style="z-index: 1; left: 40px; top: 63px; position: absolute" Text="Username" width="71px"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 40px; top: 94px; position: absolute; height: 19px" Text="Password" width="71px"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" height="19px" style="z-index: 1; left: 40px; top: 130px; position: absolute" Text="Address" width="71px"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 40px; top: 166px; position: absolute" Text="DateAdded"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 133px; top: 32px; position: absolute; margin-top: 0px" OnTextChanged="txtCustomerId_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtUsername" runat="server" height="22px" style="z-index: 1; left: 129px; top: 67px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 129px; top: 100px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 129px; top: 135px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" height="22px" style="z-index: 1; left: 129px; top: 168px; position: absolute" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 38px; top: 204px; position: absolute" Text="Active" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 246px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 45px; top: 279px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 116px; top: 278px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 304px; top: 31px; position: absolute" Text="Find" />
        </div>
    </form>
</body>
</html>
