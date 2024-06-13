using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_DB
{

   [Observable]
   public static class QueryBuilder
   {

      public static string BuildInsertQuery(string tableName, Dictionary<string, string> parameters)
      {
         if ( !string.IsNullOrEmpty(tableName) && parameters.Count > 0 )
         {
            var builder = new StringBuilder();
            builder.Append("Insert into ");
            builder.Append(tableName);
            builder.Append(" (");
            BuildParameters(builder, parameters.Keys.ToArray());
            builder.Append(") ");
            builder.Append("values(");
            BuildParameters(builder, parameters.Values.ToArray());
            builder.Append(")");
            return builder.ToString();
         }
         return null;
      }

      private static void BuildParameters(StringBuilder builder, string[] values)
      {
         for ( var i = 0; i < values.Length; i++ )
         {
            var value = values[i];
            builder.Append(values[i] == null ? "NULL" : values[i]);
            if ( i != values.Length - 1 )
            {
               builder.Append(", ");
            }
         }
      }

   }

}