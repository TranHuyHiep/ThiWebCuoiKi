using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using TranHuyHiep_CNTT1K61_201210118.Models;

namespace TranHuyHiep_CNTT1K61_201210118.Controllers
{
    public class HomeController : Controller
    {
        QlbanChauCanhContext db = new QlbanChauCanhContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lst = db.SanPhams.Take(9).ToList();
            return View(lst);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // sua 
        [HttpGet]
        public IActionResult editSP(string maSP)
        {
            var temp = db.SanPhams.SingleOrDefault(x => x.MaSanPham == maSP);
            ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoaiPhus.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(temp);
        }

        [HttpPost]
        public IActionResult editSP(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.SanPhams.Update(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaPhanLoai = new SelectList(db.PhanLoais.ToList(), "MaPhanLoai", "PhanLoaiChinh");
            ViewBag.MaPhanLoaiPhu = new SelectList(db.PhanLoais.ToList(), "MaPhanLoaiPhu", "TenPhanLoaiPhu");
            return View(sanPham);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}