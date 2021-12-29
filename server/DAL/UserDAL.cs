using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDAL
    {
        public static SENDITEntities db = new SENDITEntities();

        public static void addUser(USER u)
        {
            db.USER.Add(u);
            db.SaveChanges();
        }
    }
}
