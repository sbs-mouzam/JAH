using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhleHadees.Areas.User.Controllers
{
    public class BoardMemberController : Controller
    {
        // GET: User/BoardMember
        public ActionResult Index()
        {
            return View();
        }
    }
}