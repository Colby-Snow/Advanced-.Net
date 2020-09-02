<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display_single_fish.aspx.cs" Inherits="Aquarium_Csharp_With_Database.display_single_fish" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--<asp:Label ID="Label5" runat="server" Text="Enter fish id: "></asp:Label>-->
            <asp:Label ID="Label1" runat="server" Text="Enter fish id: "></asp:Label>
            <asp:TextBox ID="searchTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="fishNameLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cost: "></asp:Label>
            <asp:Label ID="fishCostLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Type: "></asp:Label>
            <asp:Label ID="fishTypeLabel" runat="server" Text=""></asp:Label>            
            <br /><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
