using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AW.DataAccessLayer;

namespace AW.Framework
{
   public class EntityManager<T> : TypeManager<T>
    {
        private string _selQryTempl;

        public EntityManager()
        {
            _selQryTempl = GetSelectQuery();
        }


        public List<T> GetAll()
        {
            return ExecuteQry();
        }

        protected string GetSelectQuery()
        {
            string selQry = "";
            if (_typeName == "Customer")
            {
                selQry = "SELECT *  FROM [SalesLT].[Customer]";
            }
            else if (_typeName == "Product")
            {
                selQry = "SELECT *  FROM [SalesLT].[Product]";
            }
            else if (_typeName == "ProductDescription")
            {
                selQry = "SELECT *  FROM [SalesLT].[ProductDescription]";
            }
            else if (_typeName == "Order")
            {
                selQry = "select Name,ProductNumber,Color,ListPrice,CategoryName,ModelName,Description FROM [SalesLT].[vOrder] cross join [SalesLT].[ProductDescription]";
               
            }

            return selQry;
        }

        private List<T> ExecuteQry(string whereClause = "")
        {
            List<T> retVal = new List<T>();
            
            DataSet ds = DALHelper.GetDataset(_selQryTempl + whereClause);
            if (ds != null && ds.Tables.Count > 0)
            {
                retVal = BindEntity(ds.Tables[0]);
            }
            return retVal;
        }
    }
}
