using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;

namespace Entities
{
   public class OrderEntities
    {
        public int id { get; set; }
        public Guid? order_number  { get; set; }
        public int? order_status { get; set; }
        public int? boxes_amount { get; set; }
        public DateTime? deadline_date { get; set; }
        public int? customer_id { get; set; }
        public int? route_id { get; set; }
        public int? delivery_id { get; set; }
        public int? user_id { get; set; }
        public DateTime? creation_date { get; set; }


        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static OrderEntities ConvertToEntities(ORDER o)
        {
            return new OrderEntities()
            {
                id = o.ID,
                order_number = o.ORDER_NUMBER,
                order_status = o.ORDER_STATUS,
                boxes_amount = o.BOXES_AMOUNT,
                deadline_date = o.DEADLINE_DATE,
                customer_id = o.CUSTOMER_ID,
                route_id = o.ROUTE_ID,
                delivery_id = o.ID_DELIVERY,
                creation_date=o.CREATION_DATE

            };

        }

        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static ORDER ConvertToDB(OrderEntities o)
        {
            
            return new ORDER()
            {
                ID = o.id,
                ORDER_NUMBER = o.order_number,
                ORDER_STATUS = o.order_status,
                BOXES_AMOUNT = o.boxes_amount,
                DEADLINE_DATE = o.deadline_date,
                CUSTOMER_ID = o.customer_id,
                ROUTE_ID = o.route_id,
                ID_DELIVERY=o.delivery_id,
                CREATION_DATE=o.creation_date
            };
        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<OrderEntities> ConvertToListEntities(List<ORDER> lo)
        {
            List<OrderEntities> lo1 = new List<OrderEntities>();
            foreach( var item in lo)
            {
                lo1.Add(ConvertToEntities(item));
            }
            return lo1;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<ORDER> ConvertToListDB(List<OrderEntities> lo)
        {
            List<ORDER> lo1 = new List<ORDER>();
            foreach( var item in lo)
            {
                lo1.Add(ConvertToDB(item));
            }
            return lo1;
        }
    }
}
