using System;
using System.Collections.Generic;

namespace MatinGallery.Application.Services.Users.Commands.RegisterUser
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string RePasword { get; set; }
        public string ParentPhone { get; set; }
        public List<RolesRegisterUserDto> Roles { get; set; }
    }

}
