using MatinGallery.Common.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Application.Services.Users.Commands.RemoveUser
{
    interface IRemoveUserService
    {
        ResultDto Execute(long UserId);
    }
}
