using BusinessLayer.Abstract;
using EntityLayer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private IAuthService _authService;
        private IUserService _userService;

        public RegisterController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserForRegisterDto p)
        {
            var userExists = _authService.UserExists(p.Email);
            if (!userExists.Success)
            {
                return RedirectToAction("Index","Home");
            }

            var registerResult = _authService.Register(p, p.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
