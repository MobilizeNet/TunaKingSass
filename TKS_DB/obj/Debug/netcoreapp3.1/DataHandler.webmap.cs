#pragma warning disable
#line 1 "DataHandler.cs"
#pragma warning disable
#line 1 "DataHandler.cs"
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_DB
{

   [Observable]
   public partial class DataHandler
   {
      /// <summary>
      /// The connection string
      /// </summary>
      public const string ConnectionString = "Server=S16-WS12-DB011;Database=TKS;User Id=productreader;Password=curlyLe@f15;";

      public void CreateNewRegisterInTable(string tableName, IQueryFormater formater)
      {
         var connection = new SqlConnection(ConnectionString);
         var query = QueryBuilder.BuildInsertQuery(tableName, formater.GetQueryValues());
         var command = new SqlCommand(query, connection);
         try
         {
            connection.Open();
            command.ExecuteNonQuery();
         }
         finally
         {
            connection.Close();
         }
      }

      public string GetUserById(string id)
      {
         string userId = null;
         if ( !string.IsNullOrWhiteSpace(id) )
         {
            var connection = new SqlConnection(ConnectionString);
            var command = new SqlCommand();
            try
            {
               connection.Open();
               command.CommandType = CommandType.Text;
               command.Parameters.Add("id", SqlDbType.VarChar).Value = id.ToLower();
               command.CommandText = "Select user_id from roles.users where lower(user_id)  = @id";
               command.Connection = connection;
               userId = (string)command.ExecuteScalar();
            }
            finally
            {
               connection.Close();
            }
         }
         return userId;
      }

      public T GetScalarValue<T>(string columnName, string table, string condition, string where)
      {
         T userId = default(T);
         if ( !string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(table) && !string.IsNullOrWhiteSpace(condition) && !string.IsNullOrWhiteSpace(where) )
         {
            var connection = new SqlConnection(ConnectionString);
            var command = new SqlCommand();
            try
            {
               connection.Open();
               command.CommandType = CommandType.Text;
               command.Parameters.Add("where", SqlDbType.VarChar).Value = where;
               command.CommandText = $"Select {columnName} from {table} where {condition} = @where";
               command.Connection = connection;
               userId = (T)command.ExecuteScalar();
            }
            finally
            {
               connection.Close();
            }
         }
         return (T)userId;
      }

      public void UpdateFields(string id, string role)
      {
         var connection = new SqlConnection(ConnectionString);
         try
         {
            connection.Open();
            var command = new SqlCommand($"update roles.users set user_roles = '{role}' where user_id = '{id}'", connection);
            command.ExecuteNonQuery();
         }
         finally
         {
            connection.Close();
         }
      }

      public List<T> GetListDataSource<T>(string column, string tableName)
      {
         var list = new List<T>();
         var connection = new SqlConnection(ConnectionString);
         try
         {
            connection.Open();
            var command = new SqlCommand($"select {column} from {tableName}", connection);
            using ( var reader = command.ExecuteReader() )
            {
               while ( reader.Read() )
               {
                  list.Add((T)reader[column]);
               }
            }
         }
         finally
         {
            connection.Close();
         }
         return list;
      }

      public decimal GetTableIdent(string tableName)
      {
         var connection = new SqlConnection(ConnectionString);
         var command = new SqlCommand();
         var ident = -1M;
         try
         {
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT IDENT_CURRENT('{tableName}')";
            command.Connection = connection;
            ident = (decimal)command.ExecuteScalar();
         }
         finally
         {
            connection.Close();
         }
         return ident;
      }

      public int GetTableCount(string tableName)
      {
         var connection = new SqlConnection(ConnectionString);
         var command = new SqlCommand();
         var ident = -1;
         try
         {
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT Count(*) from {tableName}";
            command.Connection = connection;
            ident = (int)command.ExecuteScalar();
         }
         finally
         {
            connection.Close();
         }
         return ident;
      }

      /// <summary>
      /// Gets the customers.
      /// </summary>
      public DataTable GetDataTableSource(string columns, string table)
      {
         var dataTable = new DataTable();
         using ( var adapter = new SqlDataAdapter(@"select " + columns + " from " + table, ConnectionString) )
         {
            adapter.Fill(dataTable);
         }
         return dataTable;
      }

      public DataTable GetDataSource(string valueMember, string displayMember, string tableName, bool ignoreDisplay = false)
      {
         var dataTable = new DataTable();
         var connection = new SqlConnection(ConnectionString);
         try
         {
            connection.Open();
            var command = new SqlCommand($"select {valueMember}, {displayMember} from {tableName}", connection);
            using ( var reader = command.ExecuteReader() )
            {
               dataTable.Load(reader);
            }
         }
         finally
         {
            connection.Close();
         }
         return dataTable;
      }

      public DataTable GetDataTableSourceCondition(string columns, string table, string condition)
      {
         var dataTable = new DataTable();
         using ( var adapter = new SqlDataAdapter(@"select " + columns + " from " + table + " where " + condition, ConnectionString) )
         {
            adapter.Fill(dataTable);
         }
         return dataTable;
      }

   }

}
#pragma warning restore
