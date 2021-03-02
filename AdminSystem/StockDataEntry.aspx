<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!--This is the Stock Entry page.-->
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="StockID" width="93px"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastEdited" runat="server" Text="LastEdited" width="93px"></asp:Label>
        <asp:TextBox ID="txtLastEdited" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text=" Price" width="93px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="93px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" Text="InStock" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
