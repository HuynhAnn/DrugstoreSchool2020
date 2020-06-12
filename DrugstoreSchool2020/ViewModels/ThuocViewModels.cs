using DrugstoreSchool2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrugstoreSchool2020.ViewModels
{
    public class ThuocViewModels
    {
        public string TenThuoc { get; set; }
        public string ThongTinThuoc { get; set; }
        public string Date { get; set; }
        public string DiaChi { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date));
        }
    }
}