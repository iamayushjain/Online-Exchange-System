<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Project.aspx.cs" Inherits="Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .auto-style1 {
            height: 23px;
            width: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1 align="center">Post an ad</h1>
        <hr />
        <table align="center" width="80%">
            <tr><td>Product name:</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td></tr>
             <tr><td class="auto-style1">Product category:</td><td class="auto-style1">
                 <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                 </asp:DropDownList>
                 </td></tr>
            <tr>
                <td>Product subcategory:</td><td>
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                </td>
            </tr>
             <tr><td>Product description:</td><td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 </td></tr>
             <tr><td>Product price:</td><td>
                 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 </td></tr>
             <tr><td>Add photo:</td><td>
&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="100px" Width="150px" />
                 &nbsp;
                 <asp:FileUpload ID="FileUpload1" runat="server" />
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
                 </td></tr>
             <tr>
                 <td>Username:</td><td>
                 <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>User Address:</td><td>
                 <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>Contact no:</td><td>
                 <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>Email:</td><td>
                 <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="Button2" runat="server" BackColor="#FF9900" CssClass="auto-style1" ForeColor="#003300" OnClick="Button2_Click" Text="Post" Width="150px" Height="40px" />
                     &nbsp;</td>
             </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
