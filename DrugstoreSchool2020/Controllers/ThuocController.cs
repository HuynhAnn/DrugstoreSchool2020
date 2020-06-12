using DrugstoreSchool2020.Models;
using DrugstoreSchool2020.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugstoreSchool2020.Controllers
{
    
    public class ThuocController : Controller
    {
        private readonly ApplicationDbContext _dBContext;
        public ThuocController()
        {
            _dBContext = new ApplicationDbContext();
        }
        // GET: Thuoc
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ThuocViewModels
            {
                Categories = _dBContext.Categories.ToList()
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(ThuocViewModels viewModel)
        {
            var Thuoc = new Thuoc
            {
                TenThuoc=viewModel.TenThuoc,ThongTinThuoc=viewModel.ThongTinThuoc, DangThuocId = User.Identity.GetUserId(), DateTime = viewModel.GetDateTime(), CategoryId = viewModel.Category, DiaChi = viewModel.DiaChi
            };
            _dBContext.Thuocs.Add(Thuoc);
            _dBContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}