using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace AW.Framework
{
    public class TypeManager<T>
    {
        Type _entityType;
        PropertyInfo[] _propertyInfos;
        protected string _typeName;


        public TypeManager()
        {
            _entityType = typeof(T);
            _typeName = _entityType.Name;
            _propertyInfos = _entityType.GetProperties();
        }

        protected T GetInstance()
        {
            return (T)Activator.CreateInstance(_entityType);
        }
        protected bool IsNumericType(Type type)
        {
            if (type == null)
            {
                return false;
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return IsNumericType(Nullable.GetUnderlyingType(type));
                    }
                    return false;
            }
            return false;
        }


        protected List<T> BindEntity(DataTable dt)
        {

            List<T> entities = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                dynamic entity = GetInstance();
                foreach (DataColumn dc in dt.Columns)
                {
                    string propertyName = dc.ColumnName;
                    //if (propertyName.Equals(string.Concat(_typeName, "ID")))
                    //{
                    //    propertyName = "ID";
                    //}
                    //class have this static property name stored in _pair.Key 
                    if (dr[dc] != null && dr[dc] != System.DBNull.Value)
                    {
                        _entityType.GetProperty(propertyName).SetValue(entity, dr[dc],null);
                    }
                }
                entities.Add(entity);
            }
            return entities;
        }
    }
}
