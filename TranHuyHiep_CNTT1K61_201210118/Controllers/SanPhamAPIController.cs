using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TranHuyHiep_CNTT1K61_201210118.Models;

namespace TranHuyHiep_CNTT1K61_201210118.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamAPIController : ControllerBase
    {
        QlbanChauCanhContext db = new QlbanChauCanhContext();
        [HttpGet]
        public List<SanPham> getProduct(string maSP)
        {
            var lst = db.SanPhams.Where(x => x.MaPhanLoaiPhu == maSP).ToList();
            return lst;
        }
    }
}
