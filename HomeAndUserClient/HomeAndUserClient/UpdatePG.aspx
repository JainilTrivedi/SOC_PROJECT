<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePG.aspx.cs" Inherits="HomeAndUserClient.UpdatePG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Pg</title>
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
                <img src="https://www.kindpng.com/picc/m/439-4395428_house-for-rent-logo-hd-png-download.png" style="left:37%" />
                    <h2>Update  PG details  </h2>
                <div class="inputs">
                    
                    <asp:TextBox CssClass="input" ID="location" AutoPostBack="true" OnTextChanged="location_change" runat="server"></asp:TextBox>
                    <label for="location">Location</label><br />
                    
                    <asp:TextBox CssClass="input" ID="area" AutoPostBack="true" OnTextChanged="area_change" runat="server"></asp:TextBox>
                    <label for="area">Area</label><br />
                    
                    <asp:TextBox CssClass="input" ID="Age" AutoPostBack="true" OnTextChanged="Age_change" runat="server"></asp:TextBox>
                    <label for="Age">Age</label><br />
                    
                    <asp:TextBox CssClass="input" ID="rent" AutoPostBack="true" OnTextChanged="rent_change" runat="server"></asp:TextBox>
                    <label for="rent">Rent</label><br />
                    
                    <asp:TextBox CssClass="input" ID="BHK" AutoPostBack="true" OnTextChanged="Bhk_change" runat="server"></asp:TextBox>
                    <label for="BHK">BHK</label><br />
                    
                    <asp:Button CssClass="submit-button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <span><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminPage.aspx">Return Home</asp:HyperLink></span>
                    
                </div>
            </form>
        </div>
    </div>
</body>
</html>
