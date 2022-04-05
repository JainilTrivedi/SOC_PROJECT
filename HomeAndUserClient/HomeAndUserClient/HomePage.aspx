<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="HomeAndUserClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent PG</title>
    <link rel="stylesheet" href="Styles/Navbar_table.css" />
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
    <link rel="stylesheet" href="Styles/Navbar_table.css" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        
           <nav  class="nav" style="background-color:#80ced6" >
                <img src="https://www.kindpng.com/picc/m/439-4395428_house-for-rent-logo-hd-png-download.png" class="nav_logo" />
                <h2>PG Finder </h2>
                <ul>
                    <li><asp:Button ID="Button1" CssClASS="nav_text" runat="server" OnClick="Button1_Click" Text="Update Profile" /></li>
                    <li><asp:Button ID="Button2" CssClass="nav_text" runat="server" OnClick="Button2_Click" Text="Logout" /></li>
                </ul>
            </nav>
        <div class="home_container">
            <h1> Pg Details</h1>
            <div class="outer_container">
           <asp:DataList ID="UserDetails"  runat="server">
                   <HeaderTemplate>
                       <table class="table_container table  mr-5 mt-5" cellspacing="4" >
                           <thead>
                               <tr class="table_text">
                                   <th> Sr No </th>
                                   <th>Location</th>
                                   <th>Area</th>
                                   <th>Age</th>
                                   <th>Bhk</th>
                                   <th>Rent</th>
                                   <th>Actions</th>
                                   <th></th>
                               </tr>
                           </thead>
                   
                   </HeaderTemplate>
                   <ItemTemplate>
                       <tbody>
                           <tr class="table_text">
                               <td> <%# Container.ItemIndex + 1 %>  </td>
                               <td><%# Eval("location") %></td>
                               <td><%#Eval("area") %></td>
                               <td><%#Eval("age") %></td>
                               <td><%#Eval("bhk") %></td>
                               <td><%#Eval("rent") %></td>
                               <td> <asp:LinkButton CommandArgument='<%#Eval("Id") %>' ID="ContactLinkButtonPG" runat="server">Contact Owner</asp:LinkButton> </td>
                           </tr>
                       </tbody>
                   </ItemTemplate>
                </asp:DataList>
                <br />
            <br />
            <br />
        </div>
            
            
            <%--<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />--%>
           
        </div>
    </form>
</body>
</html>
