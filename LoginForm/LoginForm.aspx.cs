using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AW.TestHarness
{
    public partial class LoginForm : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["AdventureWorksLT2012ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                FormsAuthentication.RedirectFromLoginPage(Session["Username"].ToString(), false);
            }
        }

        protected void AuthenticateUser(object sender, AuthenticateEventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", ctrlLogin.UserName);
            cmd.Parameters.AddWithValue("@password", ctrlLogin.Password);
            con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (value == 1)
            {
                Session["Username"] = ctrlLogin.UserName;
                FormsAuthentication.RedirectFromLoginPage(ctrlLogin.UserName, false);
            }



            /*  if (FormsAuthentication.Authenticate(ctrlLogin.UserName, ctrlLogin.Password))
              {
                  Session.Add("UserName", ctrlLogin.UserName);
                  FormsAuthentication.RedirectFromLoginPage(ctrlLogin.UserName, false);
              }*/

        }

    }
}