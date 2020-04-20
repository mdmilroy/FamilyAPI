using Microsoft.AspNet.Identity;
using Models.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PersonController : ApiController
    {
        [Authorize]
        private FamilyService CreateFamilyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var familyService = new FamilyService(userId);
            return familyService;
        }

        public IHttpActionResult Get()
        {
            FamilyService noteService = CreateFamilyService();
            var notes = noteService.GetFamily();
            return Ok(notes);
        }

        public IHttpActionResult Post(AddPerson person)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateFamilyService();

            if (!service.CreatePerson(person))
                return InternalServerError();

            return Ok();
        }
    }
}
