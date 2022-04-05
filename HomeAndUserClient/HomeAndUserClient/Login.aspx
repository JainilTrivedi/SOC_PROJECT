<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeAndUserClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300&family=Poppins:wght@200&family=Roboto&display=swap" rel="stylesheet" />
    <link href="css/bootstart.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="fontawsome/css/all.min.css" rel="stylesheet" />
    <link href="css/web.css" rel="stylesheet" />
    <script src="bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="bootstrap/js/popper.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="Styles/Forms.css" />

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
</head>
<body>
    <div class="login_container">
        <div class="login-box">
        <form id="form1" class="form"  runat="server">
            <img src="https://www.kindpng.com/picc/m/439-4395428_house-for-rent-logo-hd-png-download.png" />
                <h2> Login</h2>
                <div class="inputs">
                        <asp:TextBox ID="uname" CssClass="input"  runat="server"></asp:TextBox>
                        <label for="uname">User Name</label>
                        <br />
                        <asp:TextBox ID="pass" CssClass="input"  runat="server" TextMode="Password"></asp:TextBox>
                         <label  for="pass" >Password</label>    
                    
                        <asp:Button ID="LoggedIn" runat="server" CssClass="submit-button"  OnClick="LoggedIn_Click" Text="Log in" />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <br />
                        <span>New User?&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">SignUp!!</asp:HyperLink></span>
                </div>
            </form>
            </div>
      </div>
</body>
</html>
