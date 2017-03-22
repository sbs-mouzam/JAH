using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    class PartialClass
    {
    }

    public partial class Masjid
    {
        public Masjid(MasjidModel _obj)
        {
            Id = _obj.Id;
            Name = _obj.Name;
            Location = _obj.Location;
            HeadUserId = _obj.HeadUserId;
            ZoneId = _obj.ZoneId;
            
            Mobile = _obj.Mobile;
            CreatedDate = _obj.CreatedDate;
            CreatedBy = _obj.CreatedBy;
        }
    }
}
