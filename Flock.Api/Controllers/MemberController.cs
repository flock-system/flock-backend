using Microsoft.AspNetCore.Mvc;
using System;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Flock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {

        [HttpPost("create")]
        public IActionResult CreateMember()
        {
            string name = "joão";

            return Ok(name);
        }

    }
}
