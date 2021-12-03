using MatinGallery.Common.Dto;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Application.Services.Users.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }

}
