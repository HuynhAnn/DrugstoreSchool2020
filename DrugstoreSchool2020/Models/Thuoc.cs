using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugstoreSchool2020.Models
{
    public class Thuoc
    {
        public int Id { get; set; }
        public ApplicationUser DangThuoc { get; set; }
        [Required]
        public string DangThuocId { get; set; }
        [Required]
        [StringLength(255)]
        public string TenThuoc { get; set; }
        public string ThongTinThuoc { get; set; }
        public DateTime DateTime { get; set; }
        public string DiaChi { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}