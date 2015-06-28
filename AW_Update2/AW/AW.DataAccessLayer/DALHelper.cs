using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AW.DataAccessLayer
{
   public static  class DALHelper
    {
       
           private static string ConnectionString
           {
               get { return ConfigurationManager.ConnectionStrings["AdventureWorksLT2008ConnectionString"].ConnectionString; }
           }
           public static int ExecuteNonQuerySP(string spName, Hashtable spParams)
           {
               int ret;
               SqlConnection conn = new SqlConnection(ConnectionString);
               SqlCommand cmd = new SqlCommand(spName);
               cmd.CommandType = CommandType.StoredProcedure;
               foreach (DictionaryEntry spParam in spParams)
               {
                   cmd.Parameters.Add(new SqlParameter(spParam.Key.ToString(), spParam.Value));
               }
               ret = cmd.ExecuteNonQuery();
               return ret;


           }
           public static object ExecuteScalarSP(string spName, Hashtable spParams)
           {
               object ret;

               SqlConnection conn = new SqlConnection(ConnectionString);
               SqlCommand cmd = new SqlCommand(spName);
               cmd.CommandType = CommandType.StoredProcedure;
               foreach (DictionaryEntry spParam in spParams)
               {
                   cmd.Parameters.Add(new SqlParameter(spParam.Key.ToString(), spParam.Value));
               }
               ret = cmd.ExecuteScalar();
               return ret;


           }

           public static IDataReader GetDataReader(string sqlquery)
           {
               SqlConnection conn = new SqlConnection(ConnectionString);
               SqlCommand cmd = new SqlCommand(sqlquery, conn);
               conn.Open();
               SqlDataReader datareader = cmd.ExecuteReader();
               return datareader;


           }

           public static DataSet GetDataset(string sqlQuery)
           {
               try
               {
                   using (SqlConnection connection = new SqlConnection(ConnectionString))
                   {
                       SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                       DataSet ds = new DataSet();
                       adapter.Fill(ds, "ResultDS");
                       return ds;
                   }
               }
               catch (Exception ex)
               {
                   throw (ex);
               }
           }
       }
    }

