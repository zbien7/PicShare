using Microsoft.AspNetCore.Mvc;
using PicShare.Areas.Identity.Data;
using PicShare.Data;
using PicShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PicShare.Controllers
{
    public class GalleryController : Controller
    {
        PicShareDbContext db;
        public GalleryController(PicShareDbContext db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult Categories()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPhotos(PhotographyViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            
            var Files = model.photoGraphy.filePhoto;

            if (Files.Count > 0)
            {
                foreach (var item in Files)
                {
                    PhotoGraphy photography = new PhotoGraphy();
                    var guid = Guid.NewGuid().ToString();
                    var filePath = "wwwroot/photography/" + guid + item.FileName;
                    var fileName = guid + item.FileName;
                    
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        item.CopyTo(stream);
                        photography.Name = fileName;
                        photography.Path = filePath;
                        photography.Title = item.FileName;
                        photography.Category = model.photoGraphy.Category;
                        photography.NoOfViews = 1;
                        photography.ApplicationUserId = userId;
                        db.PhotoGraphy.Add(photography);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");
        }
        public IActionResult DeletePhoto(int id)
        {
            var photo = db.PhotoGraphy.Find(id);
            if (photo != null)
            {
                db.PhotoGraphy.Remove(photo);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public IActionResult AllPhotos()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }

        public IActionResult Art()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult Nature()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult People()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult Buildings()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult Food()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
        public IActionResult StillLife()
        {
            PhotographyViewModel viewModel = new PhotographyViewModel();
            viewModel.photoGraphyList = db.PhotoGraphy.ToList();
            viewModel.photoGraphy = new PhotoGraphy();
            return View(viewModel);
        }
    }
}
