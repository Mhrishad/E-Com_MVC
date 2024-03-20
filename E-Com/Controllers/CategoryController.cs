﻿using E_Com.Data;
using E_Com.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Com.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
