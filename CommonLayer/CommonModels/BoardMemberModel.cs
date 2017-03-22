using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class BoardMemberModel
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public string Email { get; set; }

        
        public string Contact { get; set; }

        
        public string Area { get; set; }

        public int? BoardTypeId { get; set; }

        
        public string UserName { get; set; }

        
        public string Password { get; set; }

        public int? RoleId { get; set; }

        public bool? IsActive { get; set; }

        
        public DateTime? CreatedDate { get; set; }
        
        public List<BoardTypeModel> BoardTypeList { get; set; }
        public List<RoleModel> RoleList { get; set; }
        public List<BoardMemberModel> BoardMemberList { get; set; }
    }
}
