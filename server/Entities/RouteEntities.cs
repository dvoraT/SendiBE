using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class RouteEntities
    {
        public int id { get; set; }
        public int? order_id { get; set; }
        public int? delivery_id { get; set; }


        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static RouteEntities ConvertToEntities(ROUTE r)
        {
            return new RouteEntities()
            {
            id=r.ID,
            order_id=r.ORDER_ID,
            delivery_id=r.DELIVERY_ID
            };

        }

        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static ROUTE ConverToDB(RouteEntities r)
        {
            return new ROUTE()
            {
                ID = r.id,
                ORDER_ID=r.order_id,
                DELIVERY_ID=r.delivery_id
            };

        }

        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<RouteEntities> ConverToListEntities(List<ROUTE> lr)
        {
            List<RouteEntities> lr1 = new List<RouteEntities>();
            foreach( var item in lr)
            {
                lr1.Add(ConvertToEntities(item));
            }
            return lr1;
        }

        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<ROUTE> ConvertToListDB(List<RouteEntities> lr)
        {
            List<ROUTE> lr1 = new List<ROUTE>();
            foreach( var item in lr)
            {
                lr1.Add(ConverToDB(item));
            }
            return lr1;
        }
    }
}
