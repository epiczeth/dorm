using System;
using System.Data.OleDb;
using System.Diagnostics;

namespace somchit.SC
{
   internal class Adodb
   {
       private OleDbCommand cmdCommand;
       private OleDbDataReader reader;
       private OleDbConnection GetDbConnection()
       {
           OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\somchit.accdb;");
           try
           {
               conn.Open();
           }
           catch (Exception exception)
           {
             Debug.WriteLine(exception.Message);
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
              Debug.WriteLine(exception.Message);
           }
           return flag;
       }

       internal string GetNewRenterID()
       {
           string flag = "RID-10001";
           try
           {
               cmdCommand = new OleDbCommand("select top 1 r_id from renters order by r_id desc",GetDbConnection());
               reader = cmdCommand.ExecuteReader();
              
                   string raw = "";
                   while (reader.Read())
                   {
                       raw = reader[0].ToString();
                   }
                   string[] praw = raw.Split('-');
                   int proc = Convert.ToInt32(praw[1]);
                   flag = "RID-" + (proc + 1);
           }
           catch (Exception exception)
           {
               Debug.WriteLine(exception.Message);
           }
           return flag;
       }
       internal string GetNewRoomNumber()
       {
           string flag = "1";
           try
           {
               cmdCommand = new OleDbCommand("select top 1 room_no from rooms order by room_no desc", GetDbConnection());
               reader = cmdCommand.ExecuteReader();

               int raw = 0;
               while (reader.Read())
               {
                   raw = Convert.ToInt32(reader[0].ToString());
               }
               flag = (raw + 1).ToString();
           }
           catch (Exception exception)
           {
               Debug.WriteLine(exception.Message);
           }
           return flag;
       }
    }
}
