<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="198px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged" style="margin-top: 0px" Width="240px" AutoPostBack="True"></asp:ListBox>
        </div>
    </form>
</body>
</html>
