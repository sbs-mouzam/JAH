﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class ZoneModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<ZoneModel> ZoneList { get; set; }


    }
}
