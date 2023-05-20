using System;
using System.Collections.Generic;

namespace TranHuyHiep_CNTT1K61_201210118.Models;

public partial class PhanLoai
{
    public string MaPhanLoai { get; set; } = null!;

    public string? PhanLoaiChinh { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
