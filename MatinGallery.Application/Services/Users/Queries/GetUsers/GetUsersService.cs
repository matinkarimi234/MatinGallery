using MatinGallery.Application.Interfaces.Contexts;
using MatinGallery.Common;
using System.Collections.Generic;
using System.Linq;

namespace MatinGallery.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDatabaseContext _context;
        public GetUsersService(IDatabaseContext context)
        {
            _context = context;
        }
        public List<GetUsersDto> Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if(!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.UserName.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            return users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUsersDto
            {
                Id = p.Id,
                FullName = p.FullName,
                UserName = p.UserName,
                Email = p.Email,
                Phone = p.Phone,
                DateOfBirth = p.DateOfBirth,
                ParentPhone = p.ParentPhone
            }).ToList();
        }
    }
}
