<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMenu.ascx.cs" Inherits="AW.Portal.UserControls.SiteMenu" %>
    <asp:Menu ID="menusite" runat="server" Orientation="Horizontal" BackColor="#E3EAEB" DynamicHorizontalOffset="2"
         Font-Names="Arial" Font-Size="12" ForeColor="#666666" StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#E3EAEB"  />
        <DynamicSelectedStyle BackColor="#1C5E55" />
        <Items>
            <asp:MenuItem Text="Home"  Value="Home"  NavigateUrl="~" />
            <asp:MenuItem Text="ProductBrowser" Value="Product Browser" NavigateUrl="~" />
            <asp:MenuItem Text="MyOrders" Value="My Orders" NavigateUrl="~" />
        </Items>
        <StaticHoverStyle BackColor="#666666" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#1C5E55" />
    </asp:Menu>
