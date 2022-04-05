<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="HomeAndUserClient.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300&family=Poppins:wght@200&family=Roboto&display=swap" rel="stylesheet" />
    <link href="css/bootstart.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
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
   
        <div class="login-container">
            <div class="login_box">
                 <form id="form1" class="form" runat="server">
                     <img src="https://www.kindpng.com/picc/m/439-4395428_house-for-rent-logo-hd-png-download.png" style="left:33%" />
                    <h2> SignUp </h2>
                    <div class="inputs">
                        <%--  User Name cant be empty --%>
                        <div class="text_area">
                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="Uname" runat="server" ErrorMessage="Username can't be empty"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="Uname" CssClass="input" runat="server"></asp:TextBox> 
                            <label for="uname">User Name</label>
                            <br />
                        </div>

                        <%--  email regex and cant empty --%>
                        <div class="text_area">
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email"
                                                           ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                                                           Display = "Dynamic" ErrorMessage = "Invalid email address"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display = "Dynamic" ForeColor="Red" ControlToValidate="email" runat="server" ErrorMessage="Email can't be empty"></asp:RequiredFieldValidator>
                            <asp:TextBox ID="email" CssClass="input"  runat="server"></asp:TextBox>
                            <label for="email">Email</label>
                        </div>
                        
                        <%--  Password regex and cant empty --%>
                        <div class="text_area">
                            <asp:regularexpressionvalidator id="rev1" runat="server" Display = "Dynamic" ForeColor="Red" controltovalidate="pass" errormessage="Password should have 8 characters,atleast 1 Alphabet,1 special character,1 digit" validationexpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&amp;])[A-Za-z\d$@$!%*?&amp;]{8,}"></asp:regularexpressionvalidator><br />
                            <asp:RequiredFieldValidator Display = "Dynamic" ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="pass" runat="server" ErrorMessage="Pass can't be empty"></asp:RequiredFieldValidator><br />
                            <asp:TextBox  ID="pass" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
                            <label for="pass">Password</label>
                        <br />
                        </div>

                        <%-- Confirm Password --%>
                        <div class="text_area">
                            <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="confirmpassword" runat="server" ErrorMessage="Confirm password can't be empty"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ForeColor="Red" Display = "Dynamic" ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="confirmpassword" ErrorMessage="Pass and Confirm pass dont match"></asp:CompareValidator>
                            <asp:TextBox ID="confirmpassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
                            <label for="confirmPass">Confirm Password</label>
                            <br />
                        </div>
                        
                        <asp:Button ID="Button1" CssClass="submit-button" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label><br />
                        <span>Already a User?&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Log In!!</asp:HyperLink></span>
                    </div>
                </form>
        </div>
    </div>
    
</body>
</html>
