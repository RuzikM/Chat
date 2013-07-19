using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;


namespace WpfApplication1
{
    class DbControl
    {
        string databaseName = @"data.db";

        static DbControl DBmanage=null;
        private SQLiteConnection connection;

        private DbControl()
        {
        }

        static DbControl Getinstance()
        {
            if (DBmanage==null)
            {
                DBmanage=new DbControl();
            }
            return DBmanage;

        }

        
        private void DBCreate()
        {
            const string databaseName = @"data.db";
            if (!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                connection =
                new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                SQLiteCommand command =
                new SQLiteCommand("CREATE TABLE users (id INTEGER PRIMARY KEY, name TEXT);", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
            
            

        }

        private void DBinsert(string username)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'users' ('id', 'name') VALUES (1, '');", connection);
            command.ExecuteNonQuery();


        }
    }
}
