<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="HomeAndUserClient.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="heading">SignUp<br /></div>
            <label for="uname">User Name</label>
            <br />
            <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
            <br />
            <label for="email">Email</label>
            <br />
            <asp:TextBox ID="email"  runat="server"></asp:TextBox>

            <br />
            <label for="pass">Password</label>
            <br />
            <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>

            <br />
            <label for="confirmPass">Confirm Password</label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
