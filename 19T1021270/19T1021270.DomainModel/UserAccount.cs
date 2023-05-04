using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19T1021270.DomainModels
{
    /// <summary>
    /// Quản lý thông tin tài khoản người dùng
    /// </summary>
    public  class UserAccount
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Photo { get; set; }

        public string RoleNames { get; set; }

        
    }
}
