using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class EventRequestModel
    {
        public int Id { get; set; }

        
        public string EventName { get; set; }

        
        public string Description { get; set; }

        public string TotalSpeakers { get; set; }

        public int? EventType { get; set; }


        public string Venu { get; set; }

        public DateTime? Date { get; set; }

        public int? UserId { get; set; }

        public string UserName { get; set; }


        public int? RequestSubmitId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<RequestSubmitModel> RequestSubmitList { get; set; }
        public List<UserModel> UserList { get; set; }

        public List<EventRequestModel> EventRequestList { get; set; }

        public List<EventMasterModel> EventMasterList { get; set; }

}
}
