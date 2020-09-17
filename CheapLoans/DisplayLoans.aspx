<%@ Page Title="Display Loans" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplayLoans.aspx.cs" Inherits="CheapLoans.DisplayLoans" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Current Cheap Loans!!!!</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoanNum" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="LoanNum" HeaderText="LoanNum" InsertVisible="False" ReadOnly="True" SortExpression="LoanNum" />
                <asp:BoundField DataField="CustName" HeaderText="CustName" SortExpression="CustName" />
                <asp:BoundField DataField="LoanAmount" HeaderText="LoanAmount" SortExpression="LoanAmount" />
                <asp:BoundField DataField="AnnualIntRate" HeaderText="AnnualIntRate" SortExpression="AnnualIntRate" />
                <asp:BoundField DataField="NumPayments" HeaderText="NumPayments" SortExpression="NumPayments" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LoansConnectionString %>" SelectCommand="SelectAllProcedure" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </div>
</asp:Content>
