<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductModels.aspx.cs" Inherits="HelloASP.ProductModels" %>
<%@ Register TagPrefix="uc1" TagName="UserControl1" Src="~/UserControls/GridControl.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <main>
        <uc1:UserControl1 ID="productModelsTable" GridType="PRODUCTMODELS" runat="server" />
    </main>
    
</asp:Content>

