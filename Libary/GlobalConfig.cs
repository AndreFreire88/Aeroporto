﻿using Libary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Libary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection {  get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string conName)
        {
            return ConfigurationManager.ConnectionStrings[conName].ConnectionString;
        }
    }
}
