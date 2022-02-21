using Clothes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DressMvc.Controllers
{
    public class DRESSController : Controller
    {
        // GET: DRESS
        public class DataComponentController : Controller
        {
            public ActionResult AddNewDress()
            {
                var con = new DataComponent();
                return View(new Dress());
            }
            [HttpPost]
            public ActionResult AddNewDress(Dress dress)
            {
                var con = new DataComponent();
                try
                {
                    con.AddNewDress(dress);
                    return View(new Dress());
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    ViewBag.ErrorMessage = message;
                    return View(new Dress());
                }
            }
            public ActionResult UpdateDress(string id)
            {
                int DressId = Convert.ToInt32(id);
                var con = new DataComponent();
                try
                {

                    return View(DressId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            [HttpPost]
            public ActionResult UpdateDress(Dress dress)
            {

                var con = new DataComponent();
                try
                {
                    con.UpdateDress(dress);

                    return RedirectToAction("GetAllDress");
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public ActionResult DeleteDress(string id)
            {
                var con = new DataComponent();
                int DressId = Convert.ToInt32(id);
                try
                {
                    con.DeleteDress(DressId);
                    return RedirectToAction("GetAllDress");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }
    }
}

















