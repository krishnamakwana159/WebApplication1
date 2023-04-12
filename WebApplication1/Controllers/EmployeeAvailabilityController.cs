using RxMis.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RxMis.Web.Controllers
{
    public class EmployeeAvailabilityController : Controller
    {
        MISDbContext dbContext = new MISDbContext();

        // GET: EmployeeAvailability
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult GetAvailaibilityData()
        {
            SqlParameter[] param = {
                new SqlParameter("@EmpObjectID", 957)
            };

            string result = dbContext.Database.SqlQuery<string>("exec dbo.usp_EmpAvl_GetEmployeeDetails @EmpObjectID", param).FirstOrDefault();
            return Json(result, JsonRequestBehavior.AllowGet);

           // return Json(true);
        }

        [HttpPost]
        public ActionResult Save()
        {

            return Json(true);
        }
    }
}