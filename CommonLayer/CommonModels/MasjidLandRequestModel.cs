using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class MasjidLandRequestModel
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public int? UserId { get; set; }

        public string UserName { get; set; }
        
        public string Location { get; set; }

        public string Area { get; set; }

        public int? MasjidId { get; set; }

        public string MasjidName{ get; set; }

        public string TimePeriod { get; set; }

        public decimal? AmountPaid { get; set; }

        public decimal? AmountNeeded { get; set; }

        public string LandArea { get; set; }

        public decimal? LandPrice { get; set; }

        public string PurchasingFrom { get; set; }

        public string Doc1 { get; set; }

        public string Doc2 { get; set; }

        public string Doc3 { get; set; }

        public string Pic1 { get; set; }

        public string Pic2 { get; set; }

        public string Pic3 { get; set; }

        public int? RequestSubmitId { get; set; }

        public bool? Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? RequestTypeId { get; set; }

        public List<RequestSubmitModel> RequestSubmitList { get; set; }

        public List<RequestTypeModel> RequestTypeList { get; set; }

        public List<MasjidModel> MasjidList { get; set; }
        
        public List <UserModel> UserList { get; set; }
    }
}
