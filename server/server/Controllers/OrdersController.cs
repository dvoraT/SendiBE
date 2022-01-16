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
    [RoutePrefix("api/Orders")]

    public class OrdersController : ApiController
    {
        //הוספת לקוח
        [HttpPut]
        [Route("addOrder")]
        public IHttpActionResult addOrder(OrderEntities o)
        {
            try
            {
               OrderBL.addOrder(o);
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
