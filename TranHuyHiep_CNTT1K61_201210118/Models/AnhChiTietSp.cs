using System;
using System.Collections.Generic;

namespace TranHuyHiep_CNTT1K61_201210118.Models;

public partial class AnhChiTietSp
{
    public string MaAnh { get; set; } = null!;

    public string? MaSptheoMau { get; set; }

    public string TenFileAnh { get; set; } = null!;

    public virtual SptheoMau? MaSptheoMauNavigation { get; set; }
}
