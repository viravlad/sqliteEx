using System;
using System.Data.SQLite;
using System.IO;

namespace SQLiteDemo
{
    class Database : IDisposable
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3; Pooling=true");
            if (!File.Exists("./database.sqlite3"))
            {
                
                SQLiteConnection.CreateFile("database.sqlite3");
                System.Console.WriteLine("Database file crated");
            }
            
        }

        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (myConnection != null)
            {
                myConnection.Close();
            }
        }

        public void Dispose()
        {
            if (myConnection != null)
            {
                myConnection.Dispose();
            }
        }
    }
}
