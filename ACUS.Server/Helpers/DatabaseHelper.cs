using ACUS.Shared;
using LiteX.DbHelper.Core;
using LiteX.DbHelper.Oracle;
using System.Data;

namespace ACUS.Server.Helpers
{
    class DatabaseHelper
    {
        private IDbHelper dbHelper;

        public DatabaseType DatabaseType
        {
            get
            {
                if (dbHelper is OracleHelper)
                {
                    return DatabaseType.Oracle;
                }

                return DatabaseType.SQLServer;
            }
        }

        public DatabaseHelper(IDbHelper dbHelper)
        {
            this.dbHelper = dbHelper;            
        }

        public DataTable GetDataTable(string query)
        {
            return dbHelper.GetDataTable(query, CommandType.Text);
        }
    }
}
