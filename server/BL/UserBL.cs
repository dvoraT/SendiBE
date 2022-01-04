using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
   public class UserBL
    {
        //הוספה
        public static void addUser(UserEntities u)
        {
            UserDAL.addUser(UserEntities.ConvertToDB(u));
       
        }
        //בדיקה האם משתמש קיים
        public static UserEntities isUserExist(string userName, string password)
        {
            List<UserEntities> lu =UserEntities.ConvertToListEntities( UserDAL.getAll());
            return lu.FirstOrDefault(x => x.user_name == userName && x.user_password == password);
        }
        //שליפת קוד של משתמש
        public static int? getUserId(string userName, string password)
        {
            return UserDAL.getUserId(userName, password);
        }

        //שליפת פרטי משתמש
        public static UserEntities getDetails(int userID)
        {
            return UserEntities.ConvertToEntities(UserDAL.getDatails(userID));
        }
    }
}
