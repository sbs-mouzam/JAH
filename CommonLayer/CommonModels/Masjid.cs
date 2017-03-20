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

        public string Area { get; set; }

        public int? HalqaId { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int? UserIdHead { get; set; }

        public DateTime? CreatedDate { get; set; }

        

        public List<Masjid> MasjidList { get; set; }
        public List<Halqa> HalqaList { get; set; }
        public List<User> UserList { get; set; }


    }
}
