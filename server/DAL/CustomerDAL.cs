using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public static SENDIT1Entities db = new SENDIT1Entities();

        //שליפה
        public static List<CUSTOMER> getMyCustomers(int userId)
        {
            return db.CUSTOMER.Where(c => c.USERID == userId).ToList();
        }
        //הוספה
        public static void addCustomer(CUSTOMER c)
        {
            db.CUSTOMER.Add(c);
            db.SaveChanges();
        }

        //עריכה
        public static void updatCustomer(CUSTOMER c)
        {

            db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).F_NAME = c.F_NAME;
            db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).L_NAME = c.L_NAME;
            db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).ADRESS = c.ADRESS;
            db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).PHONE = c.PHONE;
            db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).EMAIL = c.EMAIL;
            //db.CUSTOMER.FirstOrDefault(x => x.ID == c.ID).USERID = c.USERID;


        }

        //שליפה לפי קוד
        public static CUSTOMER getCustomerById(int id)
        {
            return db.CUSTOMER.FirstOrDefault(c => c.ID == id);
        }

        //מחיקה
        public static void delete(int id)
        {
            db.CUSTOMER.Remove(db.CUSTOMER.FirstOrDefault(c => c.ID == id));
            db.SaveChanges();
        }
    }
}
