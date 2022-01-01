using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using Entities;

namespace server.Controllers
{ [RoutePrefix("api/Deliveries")]
    public class DeliveriesController : ApiController
    {
        //שליפת שליחים של היוזר הנוכחי
        [HttpGet]
        [Route("getDeliveriesByUserId/{userId}")]
        public IHttpActionResult getDeliveriesByUserId(int userId)
        {
            return Ok(DliveryBL.getDeliveriesByUserId(userId));
        }
        //הוספת שליח
        [HttpPut]
        [Route("addDelivery")]
        public IHttpActionResult addDelivery(DeliveryEntities d)
        {
            try
            {
                DliveryBL.addDelivery(d);
                return Ok(true);
            }
            catch (Exception e)
            {
                throw e;
                // return Ok(false);
            }
        }
    }
}
