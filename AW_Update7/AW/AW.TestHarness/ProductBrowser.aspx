<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/AW_Master.Master" CodeBehind="ProductBrowser.aspx.cs" Inherits="AW.TestHarness.ProductBrowser" %>

<%@ Register Src="~/ProductDescription.ascx" TagPrefix="uc1" TagName="ProductDescription" %>
<%@ Register Src="~/ProductOrder.ascx" TagPrefix="uc1" TagName="ProductOrder" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  
      <script type="text/javascript">
          function   SetPrice(ddlQty)
          {
              var ddlId = $(ddlQty).attr('id');
              var tpId = ddlId.replace('ddlquantity', 'lblTotalPrice');
              var tblId = "ContentPlaceHolder1_ProductOrd_GridView1";
              var tp = $('#' + tpId);              
              var table = $('#'+tblId);
              var tr= table.find('tr')[1]
              var $tds = $(tr).find('td'),
                     listprice = $tds.eq(4).text();

                //  alert($(ddlQty).val() * listprice);

                  $(tp).html($(ddlQty).val() * listprice);
                  // do something with productId, product, Quantity
          }

          function ShowPopup() {
              $(function () {
                  $("#dialog1").dialog({
                      title: "Product Description", width: 500,
                      buttons: {
                          Close: function () {
                              $(this).dialog('close');
                          }
                      },
                      modal: true
                  });
              });
          };
          function ShowPopup1() {
              $(function () {
                  var dlg = $("#Div2").dialog({
                      title: "Product Order", width: 1100,
                      buttons: {
                          Close: function () {
                              $(this).dialog('close');
                          }
                       
                      },
                      modal: true
                  });

                  dlg.parent().appendTo(jQuery("form:first"));
              });
          };
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
  <div id="dialog1" style="display: none">
        <uc1:ProductDescription runat="server" id="ProductDescri" />
</div>
    <div id="Div2" style="display: none" >
        <uc1:ProductOrder runat="server" ID="ProductOrd" />
</div>

        <asp:Button ID="bu" runat="server" Text="button" OnClick="bu_Click" />
    <asp:DataList ID="dlProducts" runat="server"  RepeatColumns="4"  OnItemCommand="DataList1_Command"  BackColor="LightCyan" DataKeyField="ProductID" Border="1"  >
        <ItemTemplate> 
           
      <%--  <table  style="border: 1px solid" border: 1px solid #A55129 ; background-color: #FFF7E7" >--%>
           
  <table>
            <tr  >
                <td   >
                    <asp:LinkButton ID="LinkButton1" runat="server"  CommandName="view">View</asp:LinkButton>
                   <%-- <asp:LinkButton ID="LinkButton3" runat="server" CommandName="order">Order</asp:LinkButton>--%>
                    
                   <b> ProductName</b>  :<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' /><br /> 
                </td>
                 <tr  >
                     
                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server">Order</asp:LinkButton>
                     <b>ProductNumber  </b>: <asp:Label ID="lblNumber" runat="server" Text='<%# Eval("ProductNumber") %>' />  <br />
                </td>
                     </tr>
                 <tr>
                <td>
                   <br />
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

       <%-- <asp:SqlDataSource ID="SqldataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksLT2008ConnectionString2 %>"
         SelectCommand ="Select Name, ProductNumber, Color, StandardCost from [SalesLT].[vProductListing]" >

        </asp:SqlDataSource>--%>
  
</asp:Content>
