<%@ Page Title="" Language="C#" MasterPageFile="~/AW_Master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="AW.TestHarness.Checkout" %>


<%@ Register Src="~/ShoppingCart.ascx" TagPrefix="uc1" TagName="ShoppingCart" %>
<%@ Register Src="~/UCAddressView.ascx" TagPrefix="uc1" TagName="UCAddressView" %>
<%@ Register Src="~/UCAddressEdit.ascx" TagPrefix="uc1" TagName="UCAddressEdit" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:ShoppingCart runat="server" ID="ShoppingCart" />
    <asp:Button ID="btn_Checkout" runat="server" Text="Check Out" OnClick="btn_Checkout_Click" />
    <div id="addressview" runat="server" visible="false">
        <uc1:UCAddressView runat="server" ID="UCAddressView" />
        <asp:Button ID="Button1" runat="server" Text="Edit Address" OnClick="btn_Edit_Click" />
    </div>
    <div id="Div2" runat="server" visible="false">
        <uc1:UCAddressEdit runat="server" ID="UCAddressEdit" />
        <asp:Button ID="Button2" runat="server" Text="Place Order" />
    </div>



</asp:Content>


