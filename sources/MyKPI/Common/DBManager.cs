using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MyKPI.Common
{
    public class DBManager
    {
        private static readonly Lazy<DBManager> lazyDBManager = new Lazy<DBManager>(() => new DBManager());
        public static DBManager InstantDBManger { get { return lazyDBManager.Value; } }
        private string ConnectString = "Server=192.168.100.9; database=mykpi; UID=root; password=123456; SslMode=none; charset=utf8";
        private MySqlConnection connection = null;

        private DBManager()
        {
        }

        public DataTable GetData(string sql)
        {
            try
            {
                connection = new MySqlConnection(ConnectString);
                var cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("DBManager Error:" + exp.ToString());
                return null;
            }
        }

        public void QueryExecutionWithTransaction(string sql)
        {            
            connection = new MySqlConnection(ConnectString);
            connection.Open();
            var cmd = new MySqlCommand(sql, connection);
            var transaction = connection.BeginTransaction();
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                connection.Close();
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("DBManager Error:" + exp.ToString());
                //  LogService.LogError("Query Execution With Transaction", ex);
                try
                {
                    transaction.Rollback();
                    connection.Close();
                }
                catch (Exception exp1)
                {
                    CommonFunctions.ShowErrorDialog("DBManager Error:" + exp1.ToString());
                    connection.Close();
                    //  LogService.LogError("Query Execution With Transaction roll back", ex1);
                }
            }
        }

        public void QueryExecutionWithTransaction(string[] ArrSql)
        {         
            connection = new MySqlConnection(ConnectString);
            connection.Open();
            var cmd = connection.CreateCommand();
            var transaction = connection.BeginTransaction();
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            try
            {
                foreach (string sql in ArrSql)
                {
                    if ((sql != string.Empty) && (sql != null))
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }

                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
              //  LogService.LogError("Query Execution With Transaction", ex);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex1)
                {
              //      LogService.LogError("Query Execution With Transaction roll back", ex1);
                }
            }
        }

        public void StoredProcedureExecution(string SqlCommand, Dictionary<string, object> SqlParameterList)
        {
            connection = new MySqlConnection(ConnectString);
            connection.Open();
            try
            {
                var cmd = connection.CreateCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (KeyValuePair<string, object> SqlParameter in SqlParameterList)
                {
                    cmd.Parameters.AddWithValue(SqlParameter.Key, SqlParameter.Value);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
               // LogService.LogError("Stored Procedure Execution", ex);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }      
    }
}
