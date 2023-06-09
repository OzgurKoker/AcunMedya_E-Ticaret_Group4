﻿using ETicaretApp.BLL;
using ETicaretApp.DAL.EntityFramework;
using ETicaretApp.Entities;
using ETicaretApp.Panel.UI.Models;
using ETicaretApp.Panel.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.Panel.UI.Controllers
{
    [Authorize]
    public class ProductImageController : Controller
    {
        ProductImageManager productImageManager = new ProductImageManager(new EfProductImageRepository());
        ProductManager productManager = new ProductManager(new EfProductRepository());
        private readonly INotificationService notificationService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductImageController(INotificationService notificationService, IWebHostEnvironment webHostEnvironment)
        {
            this.notificationService = notificationService;
            this.webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index(int? productId)
        {

            List<ProductImage> productImages;

            if (productId == 0 || productId == null)
            {
                productImages = productImageManager.Query().Include(x => x.Product).Where(x => !string.IsNullOrEmpty(x.Image)).ToList();
            }
            else
            {
                productImages = productImageManager.Query().Include(x => x.Product).Where(x => x.ProductId == productId).ToList();
            }

            ViewData["Products"] = new SelectList(productManager.ListAll().Where(x => productImages.Any(y => y.ProductId == x.Id)), "Id", "Name");
            return View(productImages);
        }

        public IActionResult CreateProductImagePartial()
        {
            ViewBag.Products = new SelectList(productManager.ListAll(), "Id", "Name");

            return PartialView("_CreateProductImagePartialView");
        }

        [HttpPost]
        public IActionResult Create(IFormFile photo, ProductImageViewModel productImage)
        {
            try
            {
                if (photo != null)
                {
                    string[] allowedExtensions = { ".jpg", ".jpeg", ".png" };
                    string fileExtension = Path.GetExtension(photo.FileName).ToLower();

                    if (allowedExtensions.Contains(fileExtension))
                    {
                        int fileSizeLimit = 10 * 1024 * 1024;

                        if (photo.Length <= fileSizeLimit)
                        {
                            string wwwrootPath = webHostEnvironment.WebRootPath;
                            string fileName = Path.GetFileNameWithoutExtension(photo.FileName);
                            string extension = Path.GetExtension(photo.FileName);

                            string newFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                            string path = Path.Combine(wwwrootPath + "/img/Product/", newFileName);

                            List<ProductImage> productImageList = productImageManager.ListAll().Where(x => x.ProductId == productImage.ProductId).ToList();

                            //vitrin fotografı olarak sectiyse db'ye bakıyor daha önce o ürüne vitrin fotosu atanmış mı diye
                            if (productImage.IsShowcaseImage)
                            {
                                foreach (var item in productImageList)
                                {
                                    if (item.IsShowcaseImage)
                                    {
                                        notificationService.Notification(NotifyType.Error, "Bu ürüne daha önce vitrin fotoğrafı atanmış");
                                        return RedirectToAction(nameof(Index));
                                    }
                                }
                            }

                            using (var fileStream = new FileStream(path, FileMode.Create))
                            {
                                photo.CopyTo(fileStream);
                            }

                            productImageManager.Create(new ProductImage()
                            {
                                Image = newFileName,
                                IsShowcaseImage = productImage.IsShowcaseImage,
                                ProductId = productImage.ProductId,
                            });
                            notificationService.Notification(NotifyType.Success, "Başarıyla fotoğraf eklendi.");

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            notificationService.Notification(NotifyType.Error, "Dosya boyutu limiti aşıldı (10mb)");
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    else
                    {
                        notificationService.Notification(NotifyType.Error, "Geçersiz Dosya Formatı (jpg,jpeg,png) Seçiniz.");
                        return RedirectToAction(nameof(Index));

                    }
                }
                else
                {
                    notificationService.Notification(NotifyType.Error, "Fotoğraf Seçimi Zorunludur.");

                }
            }
            catch (Exception ex)
            {

                notificationService.Notification(NotifyType.Error, ex.Message);

            }


            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public IActionResult UpdateShowcaseStatus(int id, bool showcaseStatus, int selectedId)
        {
            var productImage = productImageManager.GetById(selectedId);



            if (showcaseStatus)
            {

                if (productImageManager.Query().Any(x => x.ProductId == id && x.IsShowcaseImage == true)
)
                {
                    notificationService.Notification(NotifyType.Error, "Bu ürüne daha önce vitrin fotoğrafı atanmış.Öncekini kaldır.");
                    return BadRequest();
                }
                else
                {
                    productImage.IsShowcaseImage = true;
                    productImageManager.Update(productImage);
                    notificationService.Notification(NotifyType.Success, "Vitrin fotoğrafı olarak atandı.");
                    return Ok();


                }
            }
            else if (!showcaseStatus)
            {
                productImage.IsShowcaseImage = false;
                productImageManager.Update(productImage);
                notificationService.Notification(NotifyType.Warning, "Vitrin fotoğrafından çıkartıldı.");

                return Ok();

            }






            return View();
        }

    }
}
