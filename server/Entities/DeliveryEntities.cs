using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class DeliveryEntities
    {
        public int id { get; set; }
        public int? route_id { get; set; }
        public int? user_id { get; set; }
        public bool? status_d { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string phone { get; set; }
        public int? num_hours { get; set; }
        public string email { get; set; }



        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static DeliveryEntities ConvertToEntities(DELIVERY d)
        {
            return new DeliveryEntities()
            {
                id = d.ID,
                route_id = d.ROUTE_ID,
                user_id=d.ID_USER,
                status_d = d.STATUS_D,
                f_name = d.F_NAME,
                l_name = d.L_NAME,
                phone = d.PHONE,
                num_hours = d.NUM_HOURS,
                email = d.EMAIL

            };
        }
       
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static DELIVERY ConvertToDB(DeliveryEntities d)
        {
            return new DELIVERY()
            {
                ID = d.id,
                ROUTE_ID = d.route_id,
                ID_USER=d.user_id,
                STATUS_D = d.status_d,
                F_NAME = d.f_name,
                L_NAME = d.l_name,
                PHONE = d.phone,
                NUM_HOURS = d.num_hours,
                EMAIL = d.email
            };
        }
        
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<DeliveryEntities> ConvertToListEntities(List<DELIVERY> ld)
        {
            List<DeliveryEntities> ld1 = new List<DeliveryEntities>();
            foreach( var item in ld)
            {
                ld1.Add(ConvertToEntities(item));
            }
            return ld1;
        }
        
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<DELIVERY> ConverToListDB(List<DeliveryEntities> ld)
        {
            List<DELIVERY> ld1 = new List<DELIVERY>();
            foreach (var item in ld)
            {
                ld1.Add(ConvertToDB(item));
            }
            return ld1;
        }





       




    }
}
