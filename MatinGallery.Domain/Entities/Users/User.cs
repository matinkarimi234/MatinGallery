using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Domain.Entities.Users
{
    public class User
    {
        #region Properties
        public long Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string ParentPhone { get; set; }
        #endregion

        public ICollection<UserInRole> UserInRoles { get; set; }
    }
}
