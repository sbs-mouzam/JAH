using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class EventRequestDetailModel
    {
        public int Id { get; set; }

        public int? EventRequestId { get; set; }

        public string EventName { get; set; }


        public string SpeakerName { get; set; }

        public DateTime? Date { get; set; }

        public TimeSpan? Time { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<EventRequestDetailModel> EventRequestDetailList { get; set; }


        public List<EventRequestModel> EventRequestList { get; set; }
    }
}
