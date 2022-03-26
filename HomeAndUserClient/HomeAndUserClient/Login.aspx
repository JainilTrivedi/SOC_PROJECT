<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeAndUserClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="uname">User Name</label>
            <div class="uname">  
                <asp:TextBox ID="uname"  runat="server"></asp:TextBox>
                <br />
                <br />
            <label for="pass" >Password</label>
                <br />
                <asp:TextBox ID="pass"   runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="LoggedIn" runat="server" OnClick="LoggedIn_Click" Text="Log in" />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                New User?&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">SignUp</asp:HyperLink>&nbsp;here!!</div>
        </div>
    </form>
</body>
</html>
