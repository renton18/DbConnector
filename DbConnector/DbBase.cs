using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnector
{
    class DbBase
    {
        /// <summary>
        /// open
        /// </summary>
        public virtual void Open()
        {
        }

        /// <summary>
        /// close
        /// </summary>
        public virtual void Close()
        {
        }

        /// <summary>
        /// select(パラメータあり)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="paramDict">The parameter dictionary.</param>
        /// <returns></returns>
        public virtual DataTable ExecuteQuery(string sql, Dictionary<string, Object> paramDict)
        {
            return null;

        }
        /// <summary>
        /// select(パラメータなし)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public virtual DataTable ExecuteQuery(string sql)
        {
            return null;
        }

        /// <summary>
        /// insert update delete(パラメータあり)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <param name="paramDict">The parameter dictionary.</param>
        /// <returns>実行結果件数</returns>
        public virtual int ExecuteNonQuery(string sql, Dictionary<string, Object> paramDict)
        {
            return 0;
        }

        /// <summary>
        /// insert update delete(パラメータなし)
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns>実行結果件数</returns>
        public virtual int ExecuteNonQuery(string sql)
        {
            return 0;
        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public virtual void BeginTransaction()
        {
        }

        /// <summary>
        /// コミット
        /// </summary>
        public virtual void Commit()
        {
        }

        /// <summary>
        /// ロールバック
        /// </summary>
        public virtual void RollBack()
        {
        }
    }
}
