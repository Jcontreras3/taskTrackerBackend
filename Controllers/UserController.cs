using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskTrackerBackend.Models.DTO;
using taskTrackerBackend.Models;
using taskTrackerBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace taskTrackerBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

         private readonly UserService _data;

        // [HttpPost]
        // [Route("AddUser")]

        // public bool AddUser(CreateAccountDTO UserToAdd){
        //     return _data.AddUser(UserToAdd);

        // }
    }
}