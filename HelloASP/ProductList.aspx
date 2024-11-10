<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="HelloASP.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gridViewProductList" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductId" OnRowCommand="gridViewProductList_RowCommand">
        <Columns>
            <asp:BoundField DataField="ProductID"  HeaderText="Product Id" />
            <asp:BoundField DataField="ProductNumber" HeaderText="Product Number" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnViewDetails" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" Text="View Details"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
