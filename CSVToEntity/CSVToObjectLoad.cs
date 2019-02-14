using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSVToEntity
{
    public static class CSVToObjectLoad
    {
        internal static T loadEntity<T>(string[] csvFields)
        {
            T objToReturn = Activator.CreateInstance<T>();

            Type objType = objToReturn.GetType();
            PropertyInfo[] properties = objType.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                CsvFieldAttribute attr = property.GetCustomAttribute<CsvFieldAttribute>();

                if (attr != null)
                {
                    int location = attr.CsvFieldLocation;

                    property.SetValue(objToReturn, csvFields[location]);
                }
            }

            return objToReturn;
        }

       
    }
}
