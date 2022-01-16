using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using BL;

namespace server.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        //הוספת לקוח
        [HttpPut]
        [Route("addCustomer")]
        public IHttpActionResult addCustomer(CustomerEntities c)
        {
            try
            {
                CustomerBL.addCustomer(c);
                return Ok(true);
            }
            catch (Exception e)
            {
                throw e;
                // return Ok(false);
            }
        }


        //שליפת לקוחות של היוזר הנוכחי
        [HttpGet]
        [Route("getMyCustomers/{userId}")]
        public IHttpActionResult getMyCustomers(int userId)
        {
            return Ok(CustomerBL.getMyCustomers(userId));
        }

        //עריכת לקוח

        [HttpPost]
        [Route("updatCustomer")]
        public IHttpActionResult updatCustomer(CustomerEntities c)
        {
            try
            {
                CustomerBL.updatCustomer(c);
                return Ok(true);
            }

            catch
            {
                return Ok(false);
            }
        }


        
        //שליפת לקוח לפי קוד
        [HttpGet]
        [Route("getCustomerById/{id}")]
        public IHttpActionResult getCustomerById(int id)
        {
            return Ok(CustomerBL.getCustomerById(id));
        }


        //מחיקת לקוח
        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult delete(int id)
        {
            try
            {
                CustomerBL.delete(id);
                return Ok(true);
            }

            catch
            {
                return Ok(false);
            }
        }
    }
}
