using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class RequestTypeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool? Status { get; set; }

        public List<RequestTypeModel> RequestTypeList { get; set; }

        
    }
}
