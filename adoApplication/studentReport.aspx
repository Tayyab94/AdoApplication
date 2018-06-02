<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentReport.aspx.cs" Inherits="adoApplication.studentReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" Width="395px">
        </asp:GridView>
    <div>
    
        <asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" Text="Add New" />
    
    </div>
    </form>
</body>
</html>
