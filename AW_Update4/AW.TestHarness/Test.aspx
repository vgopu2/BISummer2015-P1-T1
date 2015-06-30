<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AW.TestHarness.Test" %>

<%@ Register Src="~/UCAddressView.ascx" TagPrefix="uc1" TagName="UCAddressView" %>
<%@ Register Src="~/UCAddressEdit.ascx" TagPrefix="uc1" TagName="UCAddressEdit" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <uc1:UCAddressView runat="server" id="UCAddressView" />
        <uc1:UCAddressEdit runat="server" ID="UCAddressEdit" />
    </form>
</body>
</html>
