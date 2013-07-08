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
            //const string databaseName = @"data.db";
            if (!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));

                SQLiteCommand usersname =
                    new SQLiteCommand("CREATE TABLE users (Id integer PRIMARY KEY NOT NULL AUTOINCREMENT , name  varchar(200) NOT NULL);", connection);
                // erexeq 2-rd tablen ela stex creat linum?
                // SQLiteCommand Userschat =
                //new SQLiteCommand("CREATE TABLE message (Id integer PRIMARY KEY NOT NULL AUTOINCREMENT , messages  varchar(200) NOT NULL, U-Id INTEGER  NOT NULL);", connection);
                connection.Open();
                usersname.ExecuteNonQuery();
                connection.Close();

            }
            
            

        }

        
        private void DBinsertUsername(string username)
        {
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'users' ('id', 'name') VALUES (1, 'username');", connection);
            command.ExecuteNonQuery();


        }
    }
}
