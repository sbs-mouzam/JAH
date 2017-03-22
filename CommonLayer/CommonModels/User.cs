using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public string Area { get; set; }

        public int? UserTypeId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int? RoleId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<Role> RoleList { get; set; }

        public List <User> UserList { get; set; }
        public List <UserType> UserTypeList { get; set; }

    }
}
