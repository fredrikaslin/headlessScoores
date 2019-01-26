using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Scoores.CoreServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        [HttpGet]
        [Route("getClubs")]
        public ActionResult GetAllClubs()
        {
            List<Club> clubs = new List<Club>();
            //using (var session = NhHelper.NhHelper.OpenSession())
            //{
            //    var result = _clubRepository.GetAllClubs(session);
            //    if (result == null)
            //    {
            //        return NotFound();
            //    }
            //    foreach (var item in result)
            //    {
            //        clubs.Add(new Club { Id = item.Id, ClubName = item.ClubName, ClubSettings = item.ClubSettings });
            //    }

            //    return Ok(clubs);
            //}
            return Ok(clubs);

        }

        [HttpPost]
        [Route("createClub")]
        public IActionResult CreateClub(ClubModel club)
        {
            //using (var session = NhHelper.NhHelper.OpenSession())
            //{
            //    var clubExists = _clubRepository.GetClubByName(session, club.ClubName);
            //    if (!clubExists)
            //    {

            //        string jsonSettings = JsonConvert.SerializeObject(club.ClubSetting);


            //        _clubRepository.CreateNewClub(session, club, jsonSettings);
            //        return Ok("Club created. Click 'JOIN CLUB' and sign up!");
            //    }
            //    else
            //    {
            //        return BadRequest("Club already exists.");
            //    }
            //}
            return Ok();
        }

        [HttpGet]
        [Route("getSettings")]
        public IActionResult GetSettings()
        {
            //Guid clubId = new Guid(_clubId);
            //Club result;
            //using (var session = NhHelper.NhHelper.OpenSession())
            //{
            //    result = _clubRepository.GetClubSettings(session, clubId);
            //}

            //ClubModel clubModel = new ClubModel()
            //{
            //    Id = result.Id,
            //    ClubName = result.ClubName,
            //    ClubSetting = JsonConvert.DeserializeObject<ClubSetting>(result.ClubSettings)
            //};

            //return Ok(clubModel);
            return Ok();

        }
    }
}





/*
     [RoutePrefix("api")]
    public class ClubController : ApiController
    {
        private readonly IClubRepository _clubRepository;
        private string _clubId;

        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
            _clubId = ((ClaimsIdentity)User.Identity).FindFirstValue("clubId");

        }

        [HttpGet]
        [Route("club/getClubs")]
        public IHttpActionResult GetAllClubs()
        {
            List<Club> clubs = new List<Club>();
            using (var session = NhHelper.NhHelper.OpenSession())
            {
                var result = _clubRepository.GetAllClubs(session);
                if (result == null)
                {
                    return NotFound();
                }
                foreach (var item in result)
                {
                    clubs.Add(new Club { Id = item.Id, ClubName = item.ClubName, ClubSettings = item.ClubSettings });
                }

                return Ok(clubs);
            }
        }

        [HttpPost]
        [Route("club/createClub")]
        public IHttpActionResult CreateClub(ClubModel club)
        {
            using (var session = NhHelper.NhHelper.OpenSession())
            {
                var clubExists = _clubRepository.GetClubByName(session, club.ClubName);
                if (!clubExists)
                {

                    string jsonSettings = JsonConvert.SerializeObject(club.ClubSetting);


                    _clubRepository.CreateNewClub(session, club, jsonSettings);
                    return Ok("Club created. Click 'JOIN CLUB' and sign up!");
                }
                else
                {
                    return BadRequest("Club already exists.");
                }
            }
        }

        [HttpGet]
        [Route("club/getSettings")]
        public IHttpActionResult GetSettings()
        {
            Guid clubId = new Guid(_clubId);
            Club result;
            using (var session = NhHelper.NhHelper.OpenSession())
            {
                result = _clubRepository.GetClubSettings(session, clubId);
            }

            ClubModel clubModel = new ClubModel()
            {
                Id = result.Id,
                ClubName = result.ClubName,
                ClubSetting = JsonConvert.DeserializeObject<ClubSetting>(result.ClubSettings)
            };

            return Ok(clubModel);
        }
    }
     
     
     */
