using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sweepers_Dev.Data;
using Sweepers_Dev.Models;
using Sweepers_Dev.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sweepers_Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> Get()
        {
            var users = _userManager.Users.ToList();
            return users;

        }

    }
}