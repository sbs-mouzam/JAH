using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class DefaultInvolvementModel
    {

        public int Id { get; set; }

        public int? UserTypeId { get; set; }

        public int? RequestTypeId { get; set; }

        public DateTime CreatedDate { get; set; }


        public List<RequestTypeModel> RequestTypeList { get; set; }
        public List<UserTypeModel> UserTypeList { get; set; }
        
        public List<DefaultInvolvementModel> DefaultInvolvementList { get; set; }
    }
}
