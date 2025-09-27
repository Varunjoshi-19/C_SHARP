using Microsoft.AspNetCore.Mvc;
using testingApplication.Interface;
using testingApplication.Models;

namespace testingApplication.Controllers
{

    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            Console.WriteLine(userDto);

            _userService.RegisterUser(userDto);
            return Ok("User registered successfully!");

        }








    }



}