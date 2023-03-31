using ApiWebGet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebGet.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();

        public UserController()
        {
            userList.Add(new User { UserId = 1, Name = "John Doe", Email = "johndoe@example.com" });
            userList.Add(new User { UserId = 2, Name = "Jane Doe", Email = "janedoe@example.com" });
        }

        // GET: api/user
        public IHttpActionResult GetUser()
        {
            return Ok(userList);
        }
    }
}
