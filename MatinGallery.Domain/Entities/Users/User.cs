using MatinGallery.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Domain.Entities.Users
{
    public class User:BaseEntity
    {
        #region Properties
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string ParentPhone { get; set; }
        public bool IsActive { get; set; }
        #endregion

        public ICollection<UserInRole> UserInRoles { get; set; }
    }
}
