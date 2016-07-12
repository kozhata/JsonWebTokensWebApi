using AuthorizationServer.Api.Entities;
using AuthorizationServer.Api.Models;
using AuthorizationServer.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace AuthorizationServer.Api.Controllers
{
    [RoutePrefix("api/audience")]
    public class AudienceController : ApiController
    {
        [HttpPost]
        [Route("")]
        public IHttpActionResult AddAudience(AudienceModel audienceModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Audience newAudience = AudienceService.AddAudience(audienceModel.Name);

            return Ok<Audience>(newAudience);

        }
    }
}