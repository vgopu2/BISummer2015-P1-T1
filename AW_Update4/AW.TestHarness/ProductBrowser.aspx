<%@ Page Title="" Language="C#" MasterPageFile="~/AW_Master.Master" AutoEventWireup="true" CodeBehind="ProductBrowser.aspx.cs" Inherits="AW.TestHarness.ProductBrowser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dlProducts" runat="server" DataSourceID="SqldataSource" RepeatColumns="4" >
        <ItemTemplate>         
        <table  style="border: 1px solid" border: 1px solid #A55129 ; background-color: #FFF7E7" >
           
           
            <tr style="border:1px thin" >
                <td  style="width:450px  " >
                     <asp:CheckBox ID="ch" runat="server" />
                   <b> ProductName</b>  :<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' /><br /> 
                </td>
                 <tr  >
                     
                <td>
                     <b>ProductNumber  </b>: <asp:Label ID="lblNumber" runat="server" Text='<%# Eval("ProductNumber") %>' />  <br />
                </td>
                     </tr>
                 <tr>
                <td>
                   <b>Color </b>  : <asp:Label ID="Label1" runat="server" Text='<%# Eval("Color") %>' /><br />
                </td>
                      </tr>
                 <tr>
                <td>
                   <b>Standard </b> :<asp:Label ID="Label2" runat="server" Text='<%# Eval("StandardCost") %>' /><br />
                </td>
                      </tr>
            </tr>
        </table>
        </ItemTemplate>
          </asp:DataList> 

        <asp:SqlDataSource ID="SqldataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksLT2008ConnectionString2 %>"
         SelectCommand ="Select Name, ProductNumber, Color, StandardCost from [SalesLT].[vProductListing]" >

        </asp:SqlDataSource>
  
</asp:Content>
