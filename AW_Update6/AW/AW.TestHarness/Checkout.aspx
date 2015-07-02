<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="Checkout.aspx.cs" Inherits="AW.TestHarness.Checkout" %>

<%@ Register Src="~/ShoppingCart.ascx" TagPrefix="uc1" TagName="ShoppingCart" %>
<%@ Register Src="~/UCAddressView.ascx" TagPrefix="uc1" TagName="UCAddressView" %>
<%@ Register Src="~/UCAddressEdit.ascx" TagPrefix="uc1" TagName="UCAddressEdit" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:ShoppingCart runat="server" ID="ShoppingCart" />
        <uc1:UCAddressView runat="server" ID="UCAddressView" />
        <uc1:UCAddressEdit runat="server" ID="UCAddressEdit" />
    </form>
</body>
</html>
