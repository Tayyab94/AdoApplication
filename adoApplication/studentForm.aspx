<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentForm.aspx.cs" Inherits="adoApplication.studentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;" border="1">
            <tr>
                <td colspan="2" style="color:blue; align-items:center; font-size:xx-large">Student Form!</td>
            </tr>
            <tr>
                <td>All Students</td>
                <td>
                    <asp:DropDownList ID="ddlStudents" runat="server" Height="16px" Width="130px" AutoPostBack="True" OnSelectedIndexChanged="ddlStudents_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="200px" />
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Department</td>
                <td>
                    <asp:DropDownList ID="ddlDepartment" runat="server">
                        <asp:ListItem>COMMERCE</asp:ListItem>
                        <asp:ListItem>LAW</asp:ListItem>
                        <asp:ListItem>BUSINESS</asp:ListItem>
                        <asp:ListItem>ENGLISH</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButton ID="rdBtnMale" runat="server" Checked="True" GroupName="gender" Text="Male" />
                    <asp:RadioButton ID="rdBtnFemale" runat="server" GroupName="gender" Text="Female" />
                </td>
            </tr>
            <tr>
                <td>Subjects</td>
                <td>
                    <asp:CheckBox ID="cboxPhy" runat="server" Text="Physics" />
                    <asp:CheckBox ID="cboxChem" runat="server" Text="Chemistry" />
                    <asp:CheckBox ID="cboxBio" runat="server" Text="Biology" />
                </td>
            </tr>
            <tr>
                <td>Profile Picture</td>
                <td>
                    <asp:FileUpload ID="fuPicture" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="50px" />
                    <asp:Button ID="btnReport" runat="server" OnClick="btnReport_Click" Text="View Report" />
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
