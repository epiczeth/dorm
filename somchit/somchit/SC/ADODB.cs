using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data;
using  System.Data.OleDb;

namespace somchit.SC
{
   internal class Adodb
   {
       private OleDbCommand cmdCommand;
       private OleDbDataReader reader;
       private OleDbConnection GetDbConnection()
       {
           OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dorm.accdb;Jet OLEDB:Database Password=admin;");
           try
           {
               conn.Open();
           }
           catch (Exception exception)
           {
             System.Diagnostics.Debug.WriteLine(exception.Message);
           }
           return conn;
       }

       internal bool IsExistingUser(string user,string password)
       {
           bool flag = false;
           try
           {
               cmdCommand = new OleDbCommand("select count(*) from users where [username]=@id and [password]=@pwd",GetDbConnection());
               cmdCommand.Parameters.Add("@id", OleDbType.VarChar).Value = user;
               cmdCommand.Parameters.Add("@pwd", OleDbType.VarChar).Value = password;
               flag = ((int)cmdCommand.ExecuteScalar() > 0) ? true : false;
           }
           catch (Exception exception)
           {
              System.Diagnostics.Debug.WriteLine(exception.Message);
           }
           return flag;
       }
    }
}
