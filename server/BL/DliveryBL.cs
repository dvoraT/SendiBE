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
        //מחיקה
        public static void deleteDelivery(int id)
        {
            DeliveyDal.deleteDelivery(id);
        }

        //שליפת שליח לפי קוד
        public static DeliveryEntities getDeliveryById(int id)
        {
            return DeliveryEntities.ConvertToEntities(DeliveyDal.getDeliveryById(id));
        }
        //עדכון
        public static void updateDelivery(DeliveryEntities d)
        {
            DeliveyDal.updateDelivery(DeliveryEntities.ConvertToDB(d));
        }


        public static DeliveryEntities isExist(string phoneNumber)
        {
            List<DeliveryEntities> dl = DeliveryEntities.ConvertToListEntities(DeliveyDal.getAll());
            return dl.FirstOrDefault(d => d.phone == phoneNumber);
        }

    }
}
