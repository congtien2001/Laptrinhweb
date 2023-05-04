using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021270.DomainModels;

namespace _19T1021270.Web.Models
{
    /// <summary>
    /// Kết quả tìm kiếm, phân trang đối với Nhà cung cấp
    /// </summary>
    public class SupplierSearchOutput : PaginationSearchOutput
    {
        public List<Supplier> Data { get; set; }
    }
}