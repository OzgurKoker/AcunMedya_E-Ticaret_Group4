﻿using ETicaretApp.BLL;
using ETicaretApp.DAL.EntityFramework;
using ETicaretApp.Entities;
using ETicaretApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETicaretApp.UI.Controllers
{
    public class HomeController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
    

        public IActionResult Index()
        {
            var model = new IndexViewModel()
            {
                Categories = categoryManager.ListAll()
            };
            return View(model);
        }



   
    }
}