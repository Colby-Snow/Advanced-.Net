<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Using_Stored_Procedures.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            All Items:<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="ITEM_NUM">
                <Columns>
                    <asp:BoundField DataField="ITEM_NUM" HeaderText="ITEM_NUM" SortExpression="ITEM_NUM" ReadOnly="True" />
                    <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" SortExpression="DESCRIPTION" />
                    <asp:BoundField DataField="ON_HAND" HeaderText="ON_HAND" SortExpression="ON_HAND" />
                    <asp:BoundField DataField="CATEGORY" HeaderText="CATEGORY" SortExpression="CATEGORY" />
                    <asp:BoundField DataField="STOREHOUSE" HeaderText="STOREHOUSE" SortExpression="STOREHOUSE" />
                    <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TAL_DistributorsConnectionString %>" SelectCommand="SELECT * FROM [ITEM]">
            </asp:SqlDataSource>
            <br />
            
            <asp:Button ID="BtnLoadSpecific" runat="server" OnClick="BtnLoadSpecific_Click" Text="Load Specific Items" />
            <br />
            <br />
            Specific Items:<br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" Text="Clear Specific Items" />
            <br />
        </div>
    </form>
</body>
</html>
