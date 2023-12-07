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
    public class RolesController : Controller
    {
        private readonly RoleManager<ApplicationUser> _roleManager;

        public RolesController(RoleManager<ApplicationUser> roleManager)
        {
            _roleManager = roleManager;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> Get()
        {
            var roles = _roleManager.Roles.ToList();
            return roles;

        }

    }
}