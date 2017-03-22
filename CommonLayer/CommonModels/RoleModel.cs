using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RoleModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool? Status { get; set; }

        public List<RoleModel> RoleList { get; set; }



    }
}
