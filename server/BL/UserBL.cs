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
    }
}
