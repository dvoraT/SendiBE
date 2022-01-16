using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;



namespace BL
{
   public class CustomerBL
    {

        //שליפה
        public static List<CustomerEntities> getMyCustomers(int userId)
        {
            return CustomerEntities.ConvrtToListEntities(CustomerDAL.getMyCustomers(userId));
        }
        //הוספה
        public static void addCustomer(CustomerEntities c)
        {
            CustomerDAL.addCustomer(CustomerEntities.ConvertToDB(c));

        }

        //עריכה
        public static void updatCustomer(CustomerEntities c)
        {
            CustomerDAL.updatCustomer(CustomerEntities.ConvertToDB(c));
        }

        //שליפת לקוח לפי קוד
        public static CustomerEntities getCustomerById(int id)
        {
            return CustomerEntities.ConvertToEntities(CustomerDAL.getCustomerById(id));
        }

        //מחיקה
        public static void delete(int id)
        {
             CustomerDAL.delete(id);
        }


    }
}
