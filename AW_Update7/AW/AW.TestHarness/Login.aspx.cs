using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AW.TestHarness
{
    public partial class Login : System.Web.UI.Page
    {

        public string connection = ConfigurationManager.ConnectionStrings["AdventureWorksLT2008ConnectionString2"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           if( Session["UserName"] !=null)
            {
               FormsAuthentication.RedirectFromLoginPage(Session["UserName"].ToString(), false);
            }
        }

        protected void AuthenticateUser(object sender, AuthenticateEventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("spAuthenticateUser1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", ctrlLogin.UserName);
            cmd.Parameters.AddWithValue("@password", ctrlLogin.Password);
            con.Open();
            int value = Convert.ToInt32(cmd.ExecuteScalar());
        //    con.Close();
            if (value == 1)
            {
                Session["Username"] = ctrlLogin.UserName;
                FormsAuthentication.RedirectFromLoginPage(ctrlLogin.UserName, false);
                string sqlquery = "select CustomerID from [SalesLT].[Customer] where EmailAddress = '" + ctrlLogin.UserName + "' ";
                SqlCommand cmd1 = new SqlCommand(sqlquery, con);
                int CustomerID = Convert.ToInt32(cmd1.ExecuteScalar());
                Session["customerId"] = CustomerID;

                string sqlquery1 = "select AddressID from [SalesLT].[CustomerAddress] where CustomerID = '" + CustomerID + "' ";
                SqlCommand cmd2 = new SqlCommand(sqlquery1, con);
                int AddressID = Convert.ToInt32(cmd2.ExecuteScalar());
                Session["AddressId"] = AddressID;


                Dictionary<int,int> cartItems=new Dictionary<int,int>();
                Session["shoppingCart"]=cartItems;
            }     
         }
        }
    }
