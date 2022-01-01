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
        public static void addUser(UserEntities u)
        {
            UserDAL.addUser(UserEntities.ConvertToDB(u));
       
        }

        public static Boolean isUserExist(string userName, string password)
        {
            return UserDAL.getAll().Any(x => x.USERNAME == userName && x.USER_PASSWORD == password);
        }

        public static int? getUserId(string userName, string password)
        {
            return UserDAL.getUserId(userName, password);
        }
    }
}
