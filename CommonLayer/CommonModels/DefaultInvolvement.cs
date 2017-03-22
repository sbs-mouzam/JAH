using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class DefaultInvolvement
    {

        public int Id { get; set; }

        public int? UserTypeId { get; set; }

        public int? RequestTypeId { get; set; }

        public DateTime CreatedDate { get; set; }


        public List<RequestType> RequestTypeList { get; set; }
        public List<UserType> UserTypeList { get; set; }
        
        public List<DefaultInvolvement> DefaultInvolvementList { get; set; }
    }
}
