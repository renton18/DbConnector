using System;

namespace DbConnector
{
    enum DbType
    {
        mysql,
        sqlserver
    }
    class DbConnector
    {
        private DbType type = 0;
        public DbConnector(DbType type)
        {
            this.type = type;
        }
        public DbBase GetDbInstance(string dbServer, string dbPort, string dbName, string dbUser, string dbPassword)
        {
            switch (type)
            {
                case DbType.mysql:
                    return new MYSQL(dbServer, dbPort, dbName, dbUser, dbPassword);
                case DbType.sqlserver:
                    return new SQLSERVER(dbServer, dbPort, dbName, dbUser, dbPassword);
            }
            return null;
        }
    }
}
