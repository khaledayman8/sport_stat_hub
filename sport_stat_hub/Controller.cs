using System;
using System.Data;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            string connString = @"YOUR_CONNECTION_STRING_HERE";
            dbMan = new DBManager(connString);
        }

        public void TerminateConnection()
        {
            // nothing required now (connections are auto-closed)
        }
        public DataTable CheckLogin(string username, string password)
        {
            string query = $"SELECT * FROM Admins WHERE username = '{username}' AND password = '{password}'";
            return dbMan.ExecuteReader(query);
        }
    }
}