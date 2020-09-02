<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loans.aspx.cs" Inherits="CheapLoans.Loans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CHEAP LOANS</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>GET CHEAP LOANS NOW!!!!!</label><br/>
            <asp:Label runat="server" ID ="NameLB" Text="Name: "/><asp:TextBox runat="server" ID="NameTB"/><br />
            <asp:RequiredFieldValidator ID="RequiredNameValidator" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
            <asp:Label runat="server" ID ="LoanAmtLB" Text="Loan Amount: "/><asp:TextBox runat="server" ID="LoanAmtTB"/><br />
            <asp:Button Text="Submit" runat="server" ID="Submit" OnClick="SubmitForm"/>
            <asp:SqlDataSource runat="server" ID="LoansDataSource" ConnectionString="LoansConnectionString"/>
        </div>
    </form>
</body>
</html>
