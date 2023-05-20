using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TranHuyHiep_CNTT1K61_201210118.Models;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    [RegularExpression(@"^[A-Za-z].*$", ErrorMessage = "Phai bat dau bang chu cai")]
    public string TenSanPham { get; set; } = null!;

    public string? MaPhanLoai { get; set; }

    public long? GiaNhap { get; set; }

    public long? DonGiaBanNhoNhat { get; set; }

    public long? DonGiaBanLonNhat { get; set; }

    public bool? TrangThai { get; set; }

    [RegularExpression(@"^[A-Za-z].*$", ErrorMessage = "Phai bat dau bang chu cai")]
    public string? MoTaNgan { get; set; }

    [RegularExpression(@"\w+\.jpg", ErrorMessage = "Duoi phai la .jpg")]
    public string? AnhDaiDien { get; set; }

    public bool? NoiBat { get; set; }

    public string? MaPhanLoaiPhu { get; set; }

    public virtual PhanLoai? MaPhanLoaiNavigation { get; set; }

    public virtual PhanLoaiPhu? MaPhanLoaiPhuNavigation { get; set; }

    public virtual ICollection<SptheoMau> SptheoMaus { get; set; } = new List<SptheoMau>();
}
