﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public partial class EventMaster
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<EventMaster> EventMasterList { get; set; }

    }
}
