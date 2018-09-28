
using Assignment1.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Assignment1.Controllers
{
    public class HouseController : Controller
    {
        private object db;

        // GET: House
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HouseModel house = db.house.Find(id);
            if (house == null)
            {
                return HttpNotFound();
            }
            return View(house);
        }
    }
}