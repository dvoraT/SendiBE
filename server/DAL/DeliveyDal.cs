using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  

    public class DeliveyDal
    {
        public static SENDITEntities db = new SENDITEntities();
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
    }
}
