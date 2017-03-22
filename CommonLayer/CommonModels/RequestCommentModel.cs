using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RequestCommentModel
    {

        public int Id { get; set; }

        public int? RequestSubmitId { get; set; }

        public int? UserId { get; set; }

        public string userName { get; set; }


        public int? UserTypeId { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; }


        public List<UserModel> UserList { get; set; }
        public List<UserTypeModel> UserTypeList { get; set; }

        public List<RequestSubmitModel> RequestSubmitList { get; set; }



        public List<RequestCommentModel> RequestCommentList { get; set; }




    }
}
