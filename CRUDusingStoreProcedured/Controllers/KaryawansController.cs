using CRUDusingStoreProcedured.Models;
using CRUDusingStoreProcedured.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUDusingStoreProcedured.Controllers
{
    public class KaryawansController : Controller
    {
        iKaryawanService _karyawanService = null;
        public KaryawansController(iKaryawanService karyawanService)
        {
            _karyawanService = karyawanService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<Karyawan> GetKaryawans(String name)
        {
            return _karyawanService.GetKaryawans(name);
        }

        public void SaveOrUpdate(Karyawan karyawan)
        {
            _karyawanService.SaveOrUpdate(karyawan);
        }
        public void Delete(int nikid)
        {
            _karyawanService.Delete(nikid);
        }
    }
}
