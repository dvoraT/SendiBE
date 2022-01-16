using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class PackageEntities
    {
        public int id { get; set; }
        public Guid? number { get; set; }
        //public int? order_id { get; set; }


        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static PackageEntities ConvertToEntities(PACKAGE p)
        {
            return new PackageEntities()
            {
                id = p.ID,
                number = p.NUMBER,
                //order_id = p.ORDERID
            };
        }
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static PACKAGE ConvertToDB(PackageEntities p)
        {
            return new PACKAGE()
            {
                ID=p.id,
                NUMBER=p.number,
                //ORDERID=p.order_id
            };

        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static  List<PackageEntities> ConvertToListEntities(List<PACKAGE> lp)
        {
            List<PackageEntities> lp1 = new List<PackageEntities>();
            foreach(var item in lp)
            {
                lp1.Add(ConvertToEntities(item));
            }
            return lp1;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<PACKAGE> ConvertToListDB(List<PackageEntities> lp)
        {
            List<PACKAGE> lp1 = new List<PACKAGE>();
            foreach( var item in lp)
            {
                lp1.Add(ConvertToDB(item));

            }
            return lp1;
        }
    }
}
