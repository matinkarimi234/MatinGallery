﻿using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ResultGetUserDto Execute(RequestGetUserDto request);
    }
}
