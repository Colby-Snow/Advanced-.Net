<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Aquarium_Csharp_With_Database._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aquarium Calculator</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 850px;
        }
        .auto-style3 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">How many gallons of water does my aquarium hold?</h1>
        <br />
        <table class="auto-style2">
            <tr>
                <td rowspan="2">
                    <asp:Image ID="Image1" runat="server" Height="335px" ImageUrl="~/Aquarium.png" Width="340px" />
                </td>
                <td>Length (inches):<br />
                    <asp:TextBox ID="lengthTextBox" runat="server" Width="35px"></asp:TextBox>
                    <br />                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lengthTextBox" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Width (inches):<br />
                    <asp:TextBox ID="widthTextBox" runat="server" Width="35px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="widthTextBox" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>Height (inches):<br />
                    <asp:TextBox ID="heightTextBox" runat="server" Width="35px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="heightTextBox" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="submitButton" runat="server" Font-Size="Large" Text="Submit"  
                         OnClick="submitButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3"><span class="auto-style3"></span><br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
