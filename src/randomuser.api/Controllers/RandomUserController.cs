using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace RandomUserService.Controllers
{
    [RoutePrefix("v1")]
    public class RandomUserController : ApiController
    {
        private IDefaultApi _randomUser;

        public RandomUserController(IDefaultApi client)
        {
            _randomUser = client;
        }

        [Route("user/{gender}/{nationality}")]
        [HttpGet]
        public IHttpActionResult GetSingleUser(string gender, string nationality)
        {
            UserResponse response = null;

            try
            {
                response = _randomUser.ApiGet(gender, nationality);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Ok(response);
        }
    }
}
