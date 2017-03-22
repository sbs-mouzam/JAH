using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using DataAccessLayer.DataModel;
using DataAccessLayer.Generic_Pattern.Implementation;
using DataAccessLayer.Generic_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementation
{
    public class MasjidBs : IMasjid
    {
        private readonly IGenericPattern<Masjid> _tbl_Masjid;
        private MasjidModel _Masjid;
        public MasjidBs()
        {
            _tbl_Masjid = new GenericPattern<Masjid>();
            _Masjid = new MasjidModel();
        }


        public List<MasjidModel> MasjidList()
        {
            List<MasjidModel> _MasjidList = new List<MasjidModel>();
            var MasjidData = _tbl_Masjid.GetAll().ToList();
            _MasjidList = (from item in MasjidData
                           select new MasjidModel
                           {
                                  Id = item.Id,
                                  Name = item.Name,
                                  Location = item.Location,
                                  HeadUserId=item.HeadUserId,
                                  //HeadUserName=(item.HeadUserName
                                  ZoneId=item.ZoneId,
                                  ZoneName=(item.Zone!=null)?item.Zone.Name : string.Empty,
                                  Mobile=item.Mobile,
                                  CreatedDate = item.CreatedDate,
                                  CreatedBy = item.CreatedBy,
                                  
                              }).OrderByDescending(x => x.Id).ToList();
            return _MasjidList;
        }

        

        public List<UserModel> UserList()
        {
            GenericPattern<UserModel> _tbl_User = new GenericPattern<UserModel>();
            List<UserModel> _UserList = new List<UserModel>();
            var UserData = _tbl_User.GetAll().ToList();
            _UserList = (from item in UserData
                         select new UserModel
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


        public List<ZoneModel> ZoneList()
        {
            GenericPattern<ZoneModel> _tbl_Zone = new GenericPattern<ZoneModel>();
            List<ZoneModel> _ZoneList = new List<ZoneModel>();
            var ZoneData = _tbl_Zone.GetAll().ToList();
            _ZoneList = (from item in ZoneData
                         select new ZoneModel
                         {
                             Id = item.Id,
                             Name = item.Name,
                             CreatedDate = item.CreatedDate,
                         }).OrderByDescending(x => x.Id).ToList();
            return _ZoneList;
        }

        public MasjidModel GetDetails(MasjidModel model)
        {
            model = model ?? new MasjidModel();
            if (model.Id != 0)
            {
                model.MasjidList = MasjidList();
                model.UserList = UserList();
                model.ZoneList = ZoneList();
            }
            model.MasjidList = MasjidList();

            return model;

        }

        public int Save(MasjidModel model)
        {
            Masjid _tbl_masjid = new Masjid(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_Masjid.Update(_tbl_masjid);

            }
            else
            {
                _tbl_masjid.CreatedDate = System.DateTime.Now;
                _tbl_masjid = _tbl_Masjid.Insert(_tbl_masjid);
            }

            return _tbl_masjid.Id;
        }

        public MasjidModel GetById(int id)
        {
            MasjidModel _Masjid = new MasjidModel();
            var MasjidbyId = _tbl_Masjid.GetById(id);
            MasjidbyId = MasjidbyId ?? new Masjid();
            _Masjid = new MasjidModel
            {
                Id = MasjidbyId.Id,
                Name = MasjidbyId.Name,
                Location=MasjidbyId.Location,
                HeadUserId=MasjidbyId.HeadUserId,
                //HeadUserName=MasjidbyId.HeadUserName,
                ZoneId=MasjidbyId.ZoneId,
                ZoneName = (MasjidbyId.Zone != null) ? MasjidbyId.Zone.Name : string.Empty,
                Mobile = MasjidbyId.Mobile,
                CreatedBy = MasjidbyId.CreatedBy,
                CreatedDate = MasjidbyId.CreatedDate,
              
            };
            return _Masjid;
        }

        //public void Delete(AddMasjid entity)
        //{

        //    tbl_AddMasjid AddMasjidData = new tbl_AddMasjid(entity);
        //    using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
        //    {
        //        if (entity.Id != null && entity.Id != 0)
        //        {
        //            _tbl_AddMasjid.Delete(AddMasjidData.Id);

        //        }
        //        scope.Complete();
        //    }
        //}
    }
}
