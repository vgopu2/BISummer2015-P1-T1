<%@ Control Language="C#" AutoEventWireup="true"    CodeBehind="ShoppingCart.ascx.cs" Inherits="AW.TestHarness.ShoppingCart" %>



<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">
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
        <asp:BoundField DataField="Description" HeaderText="Description"  />
        <asp:BoundField DataField="Color" HeaderText="Color"  />
        <asp:TemplateField HeaderText="Quantity">   
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text="Label5"  ></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:BoundField DataField="ListPrice" HeaderText="ListPrice"  />
        
        <asp:BoundField DataField="CategoryName" HeaderText="CategoryName"  />
        <asp:BoundField DataField="ModelName" HeaderText="ModelName"  />

         <asp:TemplateField HeaderText="Price">   
            <ItemTemplate>
                <asp:Label ID="lblPrice" runat="server" Text=" Price"  ></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>
</asp:GridView>


<b>Total Price : </b><b><asp:Label ID="lblTotalValue" runat="server" ></asp:Label></b></br>
