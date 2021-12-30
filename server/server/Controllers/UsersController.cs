using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using Entities;


namespace server.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        [HttpPut]
        [Route("addUser")]
        public IHttpActionResult addUser(UserEntities u)
        {
            try
            {
                UserBL.addUser(u);
                return Ok(true);
            }
            catch (Exception e )
            {
                throw e;
            // return Ok(false);
            }
        }


        [HttpGet]
        [Route("isUserExist/{userName}/{password}")]
        public IHttpActionResult isUserExist(string userName, string password)
        {
            return Ok(UserBL.isUserExist(userName, password));
        }
    }


}
