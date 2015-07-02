<%@ Page Title="" Language="C#" MasterPageFile="~/AW_Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AW.TestHarness.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="ctrlLogin" runat="server" OnAuthenticate="AuthenticateUser"></asp:Login>
</asp:Content>
