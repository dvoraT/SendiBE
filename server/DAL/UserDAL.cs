using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class UserDAL
    {
        public static SENDIT1Entities db = new SENDIT1Entities();
        int i = 0;

        public static void addUser(USER u)
        {
            db.USER.Add(u);
            db.SaveChanges();
        }

        //שליפת כל היוזרים
        public static List<USER> getAll()
        {
            return db.USER.ToList();
        }

        //שליפת האיידי של המשתמש
        public static int? getUserId(string userName, string password)
        {
            USER currentUser = db.USER.First(x => x.USERNAME == userName && x.USER_PASSWORD == password);
            return currentUser.ID;
        }


        //שליפת פרטי המשתמש
        public static USER getDatails(int userID)
        {
            return db.USER.FirstOrDefault(u => u.ID == userID);
        }

        //עריכה
        public static void edit(USER u)
        {
            db.USER.FirstOrDefault(x => x.ID == u.ID).USERNAME = u.USERNAME;
            db.USER.FirstOrDefault(x => x.ID == u.ID).USER_PASSWORD = u.USER_PASSWORD;
            db.USER.FirstOrDefault(x => x.ID == u.ID).NAME = u.NAME;
            db.USER.FirstOrDefault(x => x.ID == u.ID).ADRESS = u.ADRESS;
            db.USER.FirstOrDefault(x => x.ID == u.ID).PHONE = u.PHONE;
            db.USER.FirstOrDefault(x => x.ID == u.ID).EMAIL = u.EMAIL;


        }
       
    }
}
