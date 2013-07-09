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
       
        SQLiteCommand Usersname;
        SQLiteCommand Usersmess;
        static DbControl DBmanage=null;
        private SQLiteConnection connection;
        SQLiteDataReader sqlite_datareader;


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

                connection.Open();

                               
                SQLiteCommand Usersname  = connection.CreateCommand();
                Usersname.CommandText = "CREATE TABLE users (id integer primary key AUTOINCREMENT, name varchar(200));";
                   // Usersname.CommandText =("CREATE TABLE users (Id integer PRIMARY KEY NOT NULL AUTOINCREMENT , name  varchar(200) NOT NULL);", connection);
                Usersname.ExecuteNonQuery();

                SQLiteCommand Usersmess  = connection.CreateCommand();
                Usersmess.CommandText = "CREATE TABLE message (id integer primary key AUTOINCREMENT, messages varchar(400), us_id integer);";
                
                Usersmess.ExecuteNonQuery();
                connection.Close();

            }
            
            

        }

        private void InsertUserTab(string usname)
        {

            //usersname.CommandText = "INSERT INTO users (name) VALUES ('usname');";
            
          
           Usersname.Parameters["@name"].Value = usname;

           Usersname.ExecuteNonQuery();

           
        }

        private void InsertMessageTab(string message, string name)
        {
            Int64 integer;

             integer=Int64.Parse( Usersname.CommandText = "SELECT id FROM users WHERE name=name");
            Usersmess.Parameters["@messages"].Value = message;
            Usersmess.Parameters["us_id"].Value = integer;

            Usersmess.ExecuteNonQuery();
        
         }

        private string GetMessage(string names)
        {
            Int64 integer;

            integer = Int64.Parse(Usersname.CommandText = "SELECT id FROM users WHERE name=names");

            string mes;
            mes = Usersname.CommandText = "SELECT messages FROM message WHERE us_id=integer".ToString();


            return mes; 
        
        }
        
       
    }
}
