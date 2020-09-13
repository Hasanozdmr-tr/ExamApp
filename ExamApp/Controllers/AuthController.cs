using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using ExamApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExamApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public AuthController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public IActionResult Login()
        {
            return View(new UserLoginModel());
        }


        [HttpPost]
        public IActionResult Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUserByUsernameAndPassword(model.Username, model.Password);

                if (user == null)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "Exam");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            ViewBag.RoleList = new SelectList(_roleService.GetAll(), "Id", "RoleName");

            return View(new UserRegisterModel());
        }

        [HttpPost]
        public IActionResult Register(UserRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUserByUsername(model.Username);

                if (user != null)
                {
                    ModelState.AddModelError("", "Kullanıcı Mevcut");
                }
                else
                {
                    _userService.Save(new Entity.Entities.User()
                    {
                        Username = model.Username,
                        Password = model.Password,
                        RoleId = model.RoleId
                    });

                    return RedirectToAction("Login");
                }

            }

            return View(model);
        }
    }
}
