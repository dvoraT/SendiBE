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
        int i = 0;

        public static void addUser(USER u)
        {
            db.USER.Add(u);
            db.SaveChanges();
        }

        public static List<USER> getAll()
        {
            return db.USER.ToList();
        }

        public static int? getUserId(string userName, string password)
        {
            USER currentUser = db.USER.First(x => x.USERNAME == userName && x.USER_PASSWORD == password);
            return currentUser.ID;
        }
    }
}
