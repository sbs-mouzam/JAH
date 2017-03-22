using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RequestLikeModel
    {

        public int Id { get; set; }
        
        public int? RequestSubmitId { get; set; }

        public int? UserId { get; set; }

        public string UserName { get; set; }

        public int? UserTypeId { get; set; }

        public bool IsLike { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<UserModel> UserList { get; set; }
        public List<UserTypeModel> UserTypeList { get; set; }

        public List<RequestSubmitModel> RequestSubmitList { get; set; }



        public List<RequestLikeModel> RequestLikeList { get; set; }



    }
}
