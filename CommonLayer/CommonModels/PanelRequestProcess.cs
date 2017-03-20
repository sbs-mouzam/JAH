using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class PanelRequestProcess
    {
        public int Id { get; set; }

        public int? RequestSubmitId { get; set; }

        public int? BoardMemberId { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsLiked { get; set; }

        public string Comment { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Status { get; set; }

        public List<BoardRequestProcess> BoardRequestProcessList { get; set; }

        public List<RequestSubmit> RequestSubmitList { get; set; }

        public List<PanelRequestProcess> PanelRequestProcessList { get; set; }
        
    }
}
