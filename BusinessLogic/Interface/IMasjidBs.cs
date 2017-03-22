using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IMasjidBs
    {
        List<Masjid> MasjidList();


        List<User> UserList();

        Masjid GetDetails(Masjid model);

        int Save(Masjid model);

        Masjid GetById(int id);

        void Delete(Masjid entity);

    }
}
