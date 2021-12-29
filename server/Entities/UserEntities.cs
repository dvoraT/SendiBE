using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Entities
{
  public class UserEntities
    {
        public int id { get; set; }
        public int? route_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }


        //המרה מאוביקט מסוג מסד נתונים לאוביקט מסוג אנטייז
        public static UserEntities ConvertToEntities(USER u)
        {
            return new UserEntities()
            {
                id = u.ID,
                route_id = u.ROUTE_ID,
                user_name = u.USERNAME,
                user_password = u.USER_PASSWORD,
                name = u.NAME,
                address = u.ADRESS,
                phone = u.PHONE,
                email=u.EMAIL
            };
        }
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static USER ConvertToDB(UserEntities u)
        {
            return new USER()
            {
                ID = u.id,
                ROUTE_ID=u.route_id,
                USERNAME=u.user_name,
                USER_PASSWORD=u.user_password,
                NAME=u.name,
                ADRESS=u.address,
                PHONE=u.phone,
                EMAIL=u.email
               
            };

        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<UserEntities> ConvertToListEntities(List<USER> lu)
        {
            List<UserEntities> lu1 = new List<UserEntities>();
            foreach (var item in lu)
            {
                lu1.Add(ConvertToEntities(item));
            }
            return lu1;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<USER> ConvertToListDB(List<UserEntities> lu)
        {
            List<USER> lu1 = new List<USER>();
            foreach (var item in lu)
            {
                lu1.Add(ConvertToDB(item));

            }
            return lu1;
        }
    }
}
