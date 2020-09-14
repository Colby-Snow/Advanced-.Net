<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayReps.aspx.cs" Inherits="ASP_Using_Stored_Procedures.DIsplayReps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rep Data:</h1>
            <asp:SqlDataSource ID="DisplayRepDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:TAL_TESTConnectionString %>" SelectCommand="ProcRepForRate"
                SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:Parameter Name="pRATE" Type="Decimal" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="REP_NUM" DataSourceID="DisplayRepDataSource">
                <Columns>
                    <asp:BoundField DataField="REP_NUM" HeaderText="REP_NUM" ReadOnly="True" SortExpression="REP_NUM" />
                    <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                    <asp:BoundField DataField="COMMISSION" HeaderText="COMMISSION" SortExpression="COMMISSION" />
                    <asp:BoundField DataField="RATE" HeaderText="RATE" SortExpression="RATE" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
