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

        //בודק האם המשתמש קיים
        [HttpGet]
        [Route("isUserExist/{userName}/{password}")]
        public IHttpActionResult isUserExist(string userName, string password)
        {
            var a = UserBL.isUserExist(userName, password);
            return Ok(a);
        }

        //שליפת קוד המשתמש
        [HttpGet]
        [Route("getUserId/{userName}/{password}")]
        public IHttpActionResult getUserId(string userName, string password)
        {
            return Ok(UserBL.getUserId(userName, password));
        }

        //שליפת משתמש 
        [HttpGet]
        [Route("getUserDetails")]
        public IHttpActionResult getUserDetails([FromBody]int userID)
        {
            return Ok(UserBL.getDetails(userID));
        }

        [HttpPost]
        [Route("edit")]
        public IHttpActionResult edit(UserEntities u)
        {
            try
            {
                UserBL.edit(u);
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


    }


}
