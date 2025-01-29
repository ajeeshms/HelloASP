<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloASP.Customers.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Customers</h2>
    <asp:SqlDataSource ID="customerSqlDataSource" runat="server"
            ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
            SelectCommand="SELECT CustomerId, FirstName, LastName, EmailAddress FROM SalesLT.Customer">
        </asp:SqlDataSource>

        

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" AllowPaging="True" PageSize="10"
        DataSourceID="customerSqlDataSource">
        </asp:GridView>
</asp:Content>
