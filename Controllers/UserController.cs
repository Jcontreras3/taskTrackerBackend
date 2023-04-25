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
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

         private readonly UserService _data;

        public UserController(UserService dataFromService){
            _data = dataFromService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginDTO User){
            return _data.Login(User);
        }

        [HttpPost]
        [Route("AddUser")]

        public bool AddUser(CreateAccountDTO UserToAdd){
            return _data.AddUser(UserToAdd);

        }

        [HttpPost]
        [Route("UpdateUser")]
        public bool UpdateUser(UserModel userToUpdate){
            return _data.UpdateUser(userToUpdate);
        } 

        [HttpPost]
        [Route("updateUser/{id}/{username}")]
        public bool UpdaterUsername(int id, string username){
            return _data.UpdateUsername(id, username);
        }

        [HttpDelete]
        [Route("DeleteUser/{userToDelete}")]
        public bool DeleteUser(string userToDelete){
            return _data.DeleteUser(userToDelete);
        }

        [HttpGet]
        [Route("userbyusername/{username}")]
        public UserIdDTO GetUserIdDTOByUsername(string username){
            return _data.GetUserIdDTOByUsername(username);
        }
    }
}