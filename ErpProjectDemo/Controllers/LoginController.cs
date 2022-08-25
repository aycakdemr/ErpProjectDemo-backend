using BusinessLayer.Abstract;
using EntityLayer.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    public class LoginController : Controller
    {
        private IAuthService _authService;
        private IUserService _userService;

        public LoginController(IAuthService authService, IUserService userService)
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
        public IActionResult Index(UserForLoginDto p)
        {
            var userToLogin = _authService.Login(p);
            if (!userToLogin.Success)
            {
                return View();
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
          
        }
    }
}
