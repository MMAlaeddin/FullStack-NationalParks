// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Authorization;
// // using NationalParks.Services;
// using NationalParks.Models;
// using System.Linq;

// namespace NationalParks.Controllers
// {
//   [Authorize]
//     [ApiController]
//     [Route("[controller]")]

//     public class UsersController : ControllerBase
//     {
//       // private IUserService _userService;

//       // public UsersController(IUserService userService)
//       // {
//       //   _userService = userService;
//       // }

//       // POST /users/authenticate
//       [AllowAnonymous]
//       [HttpPost("authenticate")]
//       public IActionResult Authenticate([FromBody] User userParam)
//       {
//         var user = _userService.Authenticate(userParam.Email, userParam.Password);

//         if (user == null)
//         {
//           return BadRequest(new { message = "Email or password is incorrect" });
//         }
//         else
//         {
//           return Ok(user);
//         }
//       }
      
//       // GET /users
//       [HttpGet]
//       public IActionResult GetAll()
//       {
//         var users = _userService.GetAll();
//         return Ok(users);
//       }
//     }
// }