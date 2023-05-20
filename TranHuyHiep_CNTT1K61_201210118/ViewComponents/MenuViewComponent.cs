using Microsoft.AspNetCore.Mvc;
using TranHuyHiep_CNTT1K61_201210118.Models;

namespace TranHuyHiep_CNTT1K61_201210118.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        QlbanChauCanhContext db = new QlbanChauCanhContext();
        public MenuViewComponent() { }

        public IViewComponentResult Invoke()
        {
            var lstCLB = db.PhanLoaiPhus.ToList();
            return View(lstCLB);
        }
    }
}
