using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using DataAccessLayer.Generic_Pattern.Implementation;
using DataAccessLayer.Generic_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementation
{
    public class MasjidBs : IMasjidBs
    {
        private readonly IGenericPattern<Masjid> _tbl_Masjid;
        private Masjid _Masjid;
        public MasjidBs()
        {
            _tbl_Masjid = new GenericPattern<Masjid>();
            _Masjid = new Masjid();
        }


        public List<Masjid> MasjidList()
        {
            List<Masjid> _MasjidList = new List<Masjid>();
            var MasjidData = _tbl_Masjid.GetAll().ToList();
            _MasjidList = (from item in MasjidData
                           select new Masjid
                           {
                                  Id = item.Id,
                                  Name = item.Name,
                                  Location = item.Location,
                                  HeadUserId=item.HeadUserId,
                                  ZoneId=item.ZoneId,
                                  Mobile=item.Mobile,
                                  CreatedDate = item.CreatedDate,
                                  CreatedBy = item.CreatedBy,
                                  
                              }).OrderByDescending(x => x.Id).ToList();
            return _MasjidList;
        }

        

        public List<User> UserList()
        {
            GenericPattern<User> _tbl_User = new GenericPattern<User>();
            List<User> _UserList = new List<User>();
            var UserData = _tbl_User.GetAll().ToList();
            _UserList = (from item in UserData
                         select new User
                         {
                             Id = item.Id,
                             Name = item.Name,
                             Email = item.Email,
                             Contact=item.Contact,
                             Area = item.Area,
                             UserTypeId=item.UserTypeId,
                             UserName=item.UserName,
                             Password = item.Password,
                             RoleId=item.RoleId,
                             CreatedDate = item.CreatedDate,
                         }).OrderByDescending(x => x.Id).ToList();
            return _UserList;
        }

        public Masjid GetDetails(Masjid model)
        {
            model = model ?? new Masjid();
            if (model.Id != 0)
            {
                model.MasjidList = MasjidList();
                model.UserList = UserList();
                model.ZoneList = ZoneList();
            }
            model.MasjidList = MasjidList();

            return model;

        }

        public int Save(Masjid model)
        {
            Masjid _tbl_masjid = new Masjid(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_masjid.Status = true;
                _tbl_Masjid.Update(_tbl_masjid);

            }
            else
            {
                _tbl_addmasjid.CreatedBy = 1;
                _tbl_addmasjid.CreatedDate = System.DateTime.Now;
                _tbl_addmasjid.Status = true;
                _tbl_addmasjid = _tbl_AddMasjid.Insert(_tbl_addmasjid);
            }

            return _tbl_addmasjid.Id;
        }

        public AddMasjid GetById(int id)
        {
            AddMasjid _AddMasjid = new AddMasjid();
            var MasjidbyId = _tbl_AddMasjid.GetById(id);
            MasjidbyId = MasjidbyId ?? new tbl_AddMasjid();
            _AddMasjid = new AddMasjid
            {
                Id = MasjidbyId.Id,
                MasjidName = MasjidbyId.MasjidName,
                SadarUserId = MasjidbyId.SadarUserId,
                SadarUserName = (MasjidbyId.tbl_User != null) ? MasjidbyId.tbl_User.Name : string.Empty,
                HalqaId = MasjidbyId.HalqaId,
                HalqaName = (MasjidbyId.tbl_AddHalqa != null) ? MasjidbyId.tbl_AddHalqa.HalqaName : string.Empty,
                Lattitude = MasjidbyId.Lattitude,
                Longitude = MasjidbyId.Longitude,
                CreatedBy = MasjidbyId.CreatedBy,
                CreatedDate = MasjidbyId.CreatedDate,
                Status = MasjidbyId.Status
            };
            return _AddMasjid;
        }

        public void Delete(AddMasjid entity)
        {

            tbl_AddMasjid AddMasjidData = new tbl_AddMasjid(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_AddMasjid.Delete(AddMasjidData.Id);

                }
                scope.Complete();
            }
        }
    }
}
