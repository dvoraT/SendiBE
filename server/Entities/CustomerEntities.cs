using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class CustomerEntities
    {
        public int id { get; set; }
        public int? user_id { get; set; }
        public string f_name { get; set; }//לבדוק אם צריך לעשות שוב את החיבור
        public string l_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static CustomerEntities ConvertToEntities(CUSTOMER c)
        {
            return new CustomerEntities()
            {
                id = c.ID,
                user_id = c.USERID,
                f_name = c.F_NAME,
                l_name=c.L_NAME,
                address = c.ADRESS,
                phone = c.PHONE,
                email = c.EMAIL
            };
        }

        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static CUSTOMER ConvertToDB(CustomerEntities c)
        {
            return new CUSTOMER()
            {
                ID=c.id,
                USERID=c.user_id,
                F_NAME=c.f_name,
                L_NAME=c.l_name,
                ADRESS=c.address,
                PHONE=c.phone,
                EMAIL=c.email
            };

        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<CustomerEntities> ConvrtToListEntities(List<CUSTOMER> lc)
        {
            List<CustomerEntities> lc1 = new List<CustomerEntities>();
            foreach( var item in lc)
            {
                lc1.Add(ConvertToEntities(item));
            }
            return lc1;
                
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<CUSTOMER> ConvertToListDB(List<CustomerEntities>lc)
        {
            List<CUSTOMER> lc1 = new List<CUSTOMER>();
            foreach(var item in lc)
            {
                lc1.Add(ConvertToDB(item));
            }
            return lc1;
        }


    }
}
