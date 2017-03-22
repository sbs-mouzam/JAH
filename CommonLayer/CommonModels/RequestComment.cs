﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RequestComment
    {

        public int Id { get; set; }

        public int? RequestSubmitId { get; set; }

        public int? UserId { get; set; }

        public string userName { get; set; }


        public int? UserTypeId { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; }


        public List<User> UserList { get; set; }
        public List<UserType> UserTypeList { get; set; }

        public List<RequestSubmit> RequestSubmitList { get; set; }



        public List<RequestComment> RequestCommentList { get; set; }




    }
}