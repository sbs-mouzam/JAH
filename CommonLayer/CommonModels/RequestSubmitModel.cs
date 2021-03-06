﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RequestSubmitModel
    {
        public int Id { get; set; }

        public int RequestTypeId { get; set; }

        public string Status { get; set; }

        public bool? IsApproved { get; set; }

        public string Comment { get; set; }

        public DateTime? RequestDate { get; set; }

        public List<RequestTypeModel> RequestTypeList { get; set; }


        public List<RequestSubmitModel> RequestSubmitList { get; set; }

    }
}
