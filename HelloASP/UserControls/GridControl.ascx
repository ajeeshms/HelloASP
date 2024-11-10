<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridControl.ascx.cs" Inherits="HelloASP.UserControls.GridControl" %>
Here goes the grid
<asp:GridView runat="server" ID="theGrid" AutoGenerateColumns="false" OnRowEditing="thrGrid_RowEditing" OnRowCancelingEdit="theGrid_RowCancellingEdit">
    <Columns>
        <asp:TemplateField ItemStyle-Width="100px" HeaderText="Product No.">
            <ItemTemplate>
                <asp:Label ID="lblCode" runat="server" Text='<%#Eval("ProductNumber")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField ItemStyle-Width="400px" HeaderText="Name">
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtService" runat="server" Text='<%#Eval("Name")%>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField ItemStyle-Width="200px" HeaderText="List Price">
            <ItemTemplate>
                <asp:Label ID="lbllistPrice" runat="server" Text='<%#Eval("ListPrice")%>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtlistPrice" runat="server" Text='<%#Eval("ListPrice")%>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
