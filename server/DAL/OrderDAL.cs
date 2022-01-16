using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class OrderDAL
    {
        public static SENDIT1Entities db = new SENDIT1Entities();

        //הוספה
        public static void addOrder(ORDER o)
        {
            db.ORDER.Add(o);
            db.SaveChanges();
        }

    }
}
