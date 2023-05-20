using System;
using System.Collections.Generic;

namespace TranHuyHiep_CNTT1K61_201210118.Models;

public partial class MauSac
{
    public string MaMau { get; set; } = null!;

    public string TenMau { get; set; } = null!;

    public virtual ICollection<SptheoMau> SptheoMaus { get; set; } = new List<SptheoMau>();
}
