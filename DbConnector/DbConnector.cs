using System;
using System.Collections.Generic;
using System.Data;

namespace DbConnector
{
    enum DbType
    {
        MYSQL,
        SQLSERVER
    }
    class DbConnector
    {
        public DbBase connector;
        public DbConnector(DbType type, string dbServer, string dbPort, string dbName, string dbUser, string dbPassword)
        {
            switch (type)
            {
                case DbType.MYSQL:
                    connector = new MYSQL(dbServer, dbPort, dbName, dbUser, dbPassword);
                    break;
                case DbType.SQLSERVER:
                    connector = new SQLSERVER(dbServer, dbPort, dbName, dbUser, dbPassword);
                    break;
            }
        }

    }
}
