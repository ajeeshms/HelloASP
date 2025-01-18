<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProductDetails.aspx.cs" Inherits="HelloASP.ProductDetails" %>

<%@ Register Src="~/UserControls/ProductView_Details.ascx" TagPrefix="uc1" TagName="ProductView_Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:ProductView_Details runat="server" ID="ProductView_Details" />
</asp:Content>
