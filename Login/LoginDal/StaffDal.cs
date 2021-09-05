using System;
using MySql.Data.MySqlClient;
using Persistence;

namespace LoginDal
{
    public class StaffDal{
      public int Login(Staff staff){
        int login = 0;
         Console.WriteLine(staff.UserName + " - " + staff.Password);
        try{
          MySqlConnection connection = DbHelper.GetConnection();
          connection.Open();
          MySqlCommand command = connection.CreateCommand();
          command.CommandText = "select * from Staffs where user_name='"+
            staff.UserName+"' and user_pass='"+
            Md5Algorithms.CreateMD5(staff.Password)+"';";
          MySqlDataReader reader = command.ExecuteReader();
          if(reader.Read()){
            login = reader.GetInt32("role");
          }else
          {
              login = 0;
          }
          reader.Close();
          connection.Close();
          
        }catch{
          login = -1;
        }
         Console.WriteLine(login);
        return login;
      }
    }
}