<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="StaffId" width="96px"></asp:Label>
            <asp:TextBox ID="txtStafId" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="96px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number    "></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" OnTextChanged="txtPhoneNumber_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblHourlyWage" runat="server" Text="Hourly Wage" width="96px"></asp:Label>
        <asp:TextBox ID="txtHourlyWage" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="96px"></asp:Label>
        <asp:TextBox ID="TxtDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkIsWorking" runat="server" Text="Is working" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="BtnOk_Click" Text="Ok" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
