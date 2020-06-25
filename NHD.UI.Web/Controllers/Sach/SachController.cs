using NHD.Service.Interfaces;
using NHD.Services;
using NHD.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHD.UI.Web.Controllers.Sach
{
    public class SachController : Controller
    {
        private ISachService sachService;
        public SachController()
        {
            sachService = new SachService();
        }
        // GET: ListSach
        public ActionResult ListSach()
        {
            var data = sachService.GetAll();
            var result = new List<SachVM>();
            foreach (var item in data)
            {
                var sach = new SachVM()
                {
                    SachId = item.SachId,
                    Name = item.TenSach
                };

                result.Add(sach);
            }

            return View(result);
        }
    }
}