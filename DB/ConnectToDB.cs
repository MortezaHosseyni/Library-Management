using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace libraryManagement.DB
{
    class ConnectToDB
    {
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=libraryDatabase.db; Version = 3; New = True; Compress = True;");
            // Open the connection:
            sqlite_conn.Open();
            return sqlite_conn;
        }
    }
}
