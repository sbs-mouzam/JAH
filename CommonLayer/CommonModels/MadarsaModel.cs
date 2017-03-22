using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public partial class MadarsaModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Area { get; set; }

        public int? HalqaId { get; set; }

        public string HalqaName { get; set; }


        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int? UserIdHead { get; set; }

        public string HeadUserName { get; set; }


        public DateTime? CreatedDate { get; set; }


        public List<HalqaModel> HalqaList { get; set; }
        public List<UserModel> UserList { get; set; }

        public List<MadarsaModel> MadarsaList { get; set; }


    }
}
