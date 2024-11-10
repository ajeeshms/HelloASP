<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductView_Details.ascx.cs" Inherits="HelloASP.UserControls.ProductView_Details" %>

<asp:Repeater ID="productDetailsRepeater" runat="server">
    <HeaderTemplate></HeaderTemplate>
    <ItemTemplate>
        <table  border="1" style="border-color:darkorange;background-color:lightgray">
            <tr>
                <td>
                    <fieldset>
                        <asp:Label ID="lblProdutName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblhdrProductNumber" runat="server" Text="Product Number"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblProductNumber" runat="server" Text='<%# Eval("ProductNumber") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHdrColor" runat="server" Text="Color"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblColor" runat="server" Text='<%# Eval("Color") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHdrStandardCost" runat="server" Text="Standard Cost"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="tlblStandardCost" runat="server" Text='<%# Eval("StandardCost") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHdrListPrice" runat="server" Text="List Price"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblListPrice" runat="server" Text='<%# Eval("ListPrice") %>'></asp:Label>
                </td>
            </tr>
        </table>
    </ItemTemplate>

</asp:Repeater>
