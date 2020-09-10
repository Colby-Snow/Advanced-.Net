﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loans.aspx.cs" Inherits="CheapLoans.Loans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CHEAP LOANS</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>GET CHEAP LOANS NOW!!!!!</label><br/>
            <asp:RequiredFieldValidator ID="RequiredNameValidator" runat="server" ErrorMessage="Required" ControlToValidate="NameTB" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Label runat="server" ID ="NameLB" Text="Name: "/><asp:TextBox runat="server" ID="NameTB"/><br />
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="LoanAmtTB" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:Label runat="server" ID ="LoanAmtLB" Text="Loan Amount: "/><asp:TextBox runat="server" ID="LoanAmtTB"/><br />
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="AnnualIntTB" ForeColor="Red"></asp:RequiredFieldValidator>            
            <asp:Label runat="server" ID ="AnnualIntLB" Text="Annual Interest Rate: "/><asp:TextBox runat="server" ID="AnnualIntTB"/><br />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="NumPaymentsTB" ForeColor="Red"></asp:RequiredFieldValidator>            
            <asp:Label runat="server" ID ="NumPaymentsLB" Text="Number of Payments: "/><asp:TextBox runat="server" ID="NumPaymentsTB"/><br />
            
            <asp:Button Text="Submit" runat="server" ID="Submit" OnClick="SubmitForm"/>
            <asp:Button Text="Display" runat="server" ID="Display" OnClick="DisplayPage" />
            <asp:SqlDataSource runat="server" ID="LoansDataSource" ConnectionString="LoansConnectionString"/>
        </div>
    </form>
</body>
</html>
