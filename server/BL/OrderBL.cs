using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class OrderBL
    {
        //הוספה
        public static void addOrder(OrderEntities o)
        {
            OrderDAL.addOrder(OrderEntities.ConvertToDB(o));

        }
    }
}
