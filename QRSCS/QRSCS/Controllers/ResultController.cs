using QRSCS.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QRSCS.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetInfo()
        {
            var id = Convert.ToInt32(Request.QueryString["GRNO"]);
            ResultManager manager = new ResultManager();
            var data = manager.GetStudentInfo(id);
            return Json(data, JsonRequestBehavior.AllowGet);

        }
    }
}