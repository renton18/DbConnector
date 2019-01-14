using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DbConnector
{

    //ADO.NET
    //参照追加必要なし
    class SQLSERVER : DbBase
    {
        private string connectionStr = "Data Source={0}, {1}"
                                            + @";Integrated Security=False"
                                            //+";MultipleActiveResultSets=True"
                                            + @";Initial Catalog={2}"
                                            + @";User ID={3}"
                                            + @";Password={4}";
        private SqlConnection connection;
        private SqlTransaction transaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLSERVER"/> class.
        /// </summary>
        /// <param name="dbServer">The database server.</param>
        /// <param name="dbPort">The database port.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUser">The database user.</param>
        /// <param name="dbPassword">The database password.</param>
        public SQLSERVER(string dbServer, string dbPort, string dbName, string dbUser, string dbPassword)
        {
            connectionStr = string.Format(connectionStr, dbServer, dbPort, dbName, dbUser, dbPassword);
        }
        /// <summary>
        /// open
        /// </summary>
        public override void Open()
        {
            try
            {
                this.connection = new SqlConnection(connectionStr);
                this.connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// close
        /// </summary>
        public override void Close()
        {
            this.connection.Close();
            this.connection.Dispose();
        }

        /// <summary>
        /// select(パラメータあり)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="paramDict">The parameter dictionary.</param>
        /// <returns></returns>
        public override DataTable ExecuteQuery(string sql, Dictionary<string, Object> paramDict)
        {
            var datatable = new DataTable();
            using (var command = this.connection.CreateCommand())
            {
                try
                {
                    command.CommandText = sql;
                    // パラメータ代入
                    foreach (KeyValuePair<string, Object> item in paramDict)
                    {
                        command.Parameters.Add(new SqlParameter(item.Key, item.Value));
                    }
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(datatable);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return datatable;
        }
        /// <summary>
        /// select(パラメータなし)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public override DataTable ExecuteQuery(string sql)
        {
            return this.ExecuteQuery(sql, new Dictionary<string, Object>());
        }

        /// <summary>
        /// insert update delete(パラメータあり)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="paramDict">The parameter dictionary.</param>
        /// <returns>実行結果件数</returns>
        public override int ExecuteNonQuery(string sql, Dictionary<string, Object> paramDict)
        {
            int resultCount = 0;
            using (var command = new SqlCommand() { Connection = connection, Transaction = transaction })
            {
                try
                {
                    command.CommandText = sql;
                    //パラメータ代入
                    foreach (KeyValuePair<string, Object> item in paramDict)
                    {
                        command.Parameters.Add(new SqlParameter(item.Key, item.Value));
                    }
                    resultCount = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return resultCount;
        }

        /// <summary>
        /// insert update delete(パラメータなし)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns>実行結果件数</returns>
        public override int ExecuteNonQuery(string sql)
        {
            return this.ExecuteNonQuery(sql, new Dictionary<string, Object>());
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public override void BeginTransaction()
        {
            this.transaction = this.connection.BeginTransaction();
        }

        /// <summary>
        /// コミット
        /// </summary>
        public override void Commit()
        {
            if (this.transaction.Connection != null)
            {
                this.transaction.Commit();
                this.transaction.Dispose();
            }
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public override void RollBack()
        {
            if (this.transaction.Connection != null)
            {
                this.transaction.Rollback();
                this.transaction.Dispose();
            }
        }
    }
}