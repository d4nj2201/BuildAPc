<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PartsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblPartId" runat="server" Text="Part ID" width="102px"></asp:Label>
        <asp:TextBox ID="txtPartId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPartDescription" runat="server" Text="Part Description  "></asp:Label>
            <asp:TextBox ID="txtPartDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPartType" runat="server" Text="Part Type" width="102px"></asp:Label>
        <asp:TextBox ID="txtPartType" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="102px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="102px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblWattage" runat="server" Text="Wattage" width="102px"></asp:Label>
            <asp:TextBox ID="txtWattage" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblAvailable" runat="server" Text="Available" width="102px"></asp:Label>
        <asp:CheckBox ID="chkAvailable" runat="server" Text=" " />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
