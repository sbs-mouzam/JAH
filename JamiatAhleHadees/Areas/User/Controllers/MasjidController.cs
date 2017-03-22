using BusinessLogic.Implementation;
using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhleHadees.Areas.User.Controllers
{
    public class MasjidController : Controller
    {
        private MasjidModel _Masjid;
        private readonly IMasjid _MasjidBs;
            
        public MasjidController()
        {
            _Masjid = new MasjidModel();
            _MasjidBs = new MasjidBs();
        }
        public ActionResult Index()
        {

            var res = _MasjidBs.MasjidList();
            return View(res);
            
        }


        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                _Masjid = _MasjidBs.GetById(Convert.ToInt32(id));
                _Masjid.UserList = _MasjidBs.UserList().ToList();
                _Masjid.ZoneList = _MasjidBs.ZoneList().ToList();
            }
            else
            {
                _Masjid.MasjidList = _MasjidBs.MasjidList().ToList();
                _Masjid.UserList = _MasjidBs.UserList().ToList();
                _Masjid.ZoneList = _MasjidBs.ZoneList().ToList();
            }
            return View(_Masjid);
        }
    }
}