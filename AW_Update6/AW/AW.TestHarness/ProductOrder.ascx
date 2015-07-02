<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductOrder.ascx.cs" Inherits="AW.TestHarness.ProductOrder" %>

 <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"    AutoGenerateColumns  ="false" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" >
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name"  />
        <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber"  />
        <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="45%" />
        <asp:BoundField DataField="Color" HeaderText="Color"  />
        <asp:BoundField DataField="ListPrice" HeaderText="ListPrice"  />

       <%-- <asp:TemplateField HeaderText="Total Price" >
            <ItemTemplate>
                <asp:Label ID="lblTotalPrice" runat="server" ></asp:Label>
                </ItemTemplate>
        </asp:TemplateField>--%>
        <asp:BoundField DataField="CategoryName" HeaderText="CategoryName"  />
        <asp:BoundField DataField="ModelName" HeaderText="ModelName"  />
        <asp:TemplateField HeaderText="Quantity">
            <ItemTemplate>
            <asp:DropDownList ID="ddlquantity" runat="server"  onChange="SetPrice(this)"  AutoPostBack="false">
               
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                
            </asp:DropDownList>
                </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Price" >
            <ItemTemplate>
                <asp:Label ID="lblTotalPrice" runat="server" ></asp:Label>
                </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<br />
<asp:Button ID="btnOrder" runat="server" Text="Add to Cart" OnClick="btnOrder_Click" UseSubmitBehavior="false" />