using MatinGallery.Application.Services.Users.Commands.RegisterUser;
using MatinGallery.Application.Services.Users.Commands.RemoveUser;
using MatinGallery.Application.Services.Users.Commands.UserStatusChange;
using MatinGallery.Application.Services.Users.Queries.GetRoles;
using MatinGallery.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUsersService _getUsersService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRegisterUserService _registerUserService;
        private readonly IRemoveUserService _removeUserService;
        private readonly IUserStatusChange _userStatusChange;

        //Constructor
        public UsersController(IGetUsersService getUsersService, IGetRolesService getRolesService,
            IRegisterUserService registerUserService, 
            IRemoveUserService removeUserService, IUserStatusChange userStatusChange)
        {
            _getUsersService = getUsersService;
            _getRolesService = getRolesService;
            _registerUserService = registerUserService;
            _removeUserService = removeUserService;
            _userStatusChange = userStatusChange;
        }


        public IActionResult Index(string searchkey, int page = 1)
        {
            return View(_getUsersService.Execute(new RequestGetUserDto
            {
                Page = page,
                SearchKey = searchkey
            }));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = new SelectList(_getRolesService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(string FullName, string UserName, string Email, DateTime dateOfBirth,
                                    long RoleId, string Password, string RePassword, string Phone)
        {
            var result = _registerUserService.Execute(new RequestRegisterUserDto
            {
                FullName = FullName,
                UserName = UserName,
                Email = Email,
                ParentPhone = "0",
                Phone = Phone,
                DateOfBirth = dateOfBirth,
                Roles = new List<RolesRegisterUserDto>()
                {
                    new RolesRegisterUserDto
                    {
                        Id = RoleId
                    }
                },
                Password = Password,
                RePasword = RePassword,

            });

            return Json(result);
        }
        [HttpPost]
        public IActionResult Delete(long UserId)
        {
            return Json(_removeUserService.Execute(UserId));
        }

        [HttpPost]
        public IActionResult UserStatusChange(long UserId)
        {
            return Json(_userStatusChange.Execute(UserId));
        }
    }
}
