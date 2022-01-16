using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  

    public class DeliveyDal
    {
        public static SENDIT1Entities db = new SENDIT1Entities();
       // שליפת שליחים של היוזר הנוכחי
        public static List<DELIVERY> getDeliveriesByUserId(int userId)
        {
            List<DELIVERY> ld = db.DELIVERY.Where(x => x.ID_USER == userId).ToList();
            return ld;
        }
        //הוספה
        public static void addDelivery(DELIVERY d)
        {
            db.DELIVERY.Add(d);
            db.SaveChanges();
        }

        //מחיקה 
        public static void deleteDelivery(int id)
        {
            
            db.DELIVERY.Remove(db.DELIVERY.FirstOrDefault(x => x.ID == id));
            db.SaveChanges();


        }
        
        //עדכון
        public static void updateDelivery(DELIVERY d)
        {
            //db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).ROUTE_ID = d.ROUTE_ID;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).STATUS_D = d.STATUS_D;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).F_NAME = d.F_NAME;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).L_NAME = d.L_NAME;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).PHONE = d.PHONE;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).NUM_HOURS = d.NUM_HOURS;
            db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).EMAIL = d.EMAIL;
            //db.DELIVERY.FirstOrDefault(x => x.ID == d.ID).ID_USER = d.ID_USER;

        }

        //שליפת שליח לפי קוד
        public static DELIVERY getDeliveryById(int id)
        {
            return db.DELIVERY.FirstOrDefault(x => x.ID == id);
        }


        public static List<DELIVERY> getAll()
        {
            return db.DELIVERY.ToList();
        }
    }
}
