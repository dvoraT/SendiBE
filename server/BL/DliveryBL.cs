using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
   public class DliveryBL
    {
        //שליפת שליחים של היוזר הנוכחי
        public static List<DeliveryEntities> getDeliveriesByUserId(int userId)
        {
            return DeliveryEntities.ConvertToListEntities(DeliveyDal.getDeliveriesByUserId(userId));
        }
        //הוספה
        public static void addDelivery(DeliveryEntities d)
        {
            DeliveyDal.addDelivery(DeliveryEntities.ConvertToDB(d));
        }

    }
}
