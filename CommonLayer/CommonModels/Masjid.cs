using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class Masjid
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int? HeadUserId { get; set; }

        public string HeadUserName { get; set; }

        public int? ZoneId { get; set; }

        public string ZoneName { get; set; }


        public string Mobile { get; set; }
            
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }


        public List<Masjid> MasjidList { get; set; }
        public List<User> UserList { get; set; }
        public List<Zone> ZoneList { get; set; }

    }
}
