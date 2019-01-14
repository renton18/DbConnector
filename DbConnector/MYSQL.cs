using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DbConnector
{
    //MySQL Connector/Net
    //参照追加必要「MySql.Data」
    class MYSQL : DbBase
    {
        private string connectionStr = "Server={0};Database={2};Uid={3};Pwd={4}";
        private MySqlConnection connection;
        private MySqlTransaction transaction;
        /// <summary>
        /// Initializes a new instance of the <see cref="MYSQL"/> class.
        /// </summary>
        /// <param name="dbServer">The database server.</param>
        /// <param name="dbPort">The database port.</param>
        /// <param name="dbName">Name of the database.</param>
        /// <param name="dbUser">The database user.</param>
        /// <param name="dbPassword">The database password.</param>
        public MYSQL(string dbServer, string dbPort, string dbName, string dbUser, string dbPassword)
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
                this.connection = new MySqlConnection(connectionStr);
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
                        command.Parameters.Add(new MySqlParameter(item.Key, item.Value));
                    }
                    var adapter = new MySqlDataAdapter(command);
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
            using (var command = new MySqlCommand() { Connection = connection, Transaction = transaction })
            {
                try
                {
                    command.CommandText = sql;
                    //パラメータ代入
                    foreach (KeyValuePair<string, Object> item in paramDict)
                    {
                        command.Parameters.Add(new MySqlParameter(item.Key, item.Value));
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