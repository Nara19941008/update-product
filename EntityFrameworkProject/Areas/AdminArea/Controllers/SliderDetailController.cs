using EntityFrameworkProject.Data;
using EntityFrameworkProject.Helpers;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderDetailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public SliderDetailController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            SliderDetail sliderDetail = await _context.SliderDetails.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            ViewBag.count = await _context.SliderDetails.Where(m => !m.IsDeleted).CountAsync();

            return View(sliderDetail);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderDetail sliderDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                if (!sliderDetail.SignPhoto.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "Please choose correct image type");
                    return View();
                }

                if (!sliderDetail.SignPhoto.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "Please choose correct image size");
                    return View();
                }

                string fileName = Guid.NewGuid().ToString() + "_" + sliderDetail.SignPhoto.FileName;

                string path = Helper.GetFilePath(_environment.WebRootPath, "img", fileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await sliderDetail.SignPhoto.CopyToAsync(stream);
                }

                sliderDetail.SignImage = fileName;

                await _context.SliderDetails.AddAsync(sliderDetail);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            SliderDetail sliderDetail = await _context.SliderDetails.FindAsync(id);

            if (sliderDetail == null) return NotFound();

            return View(sliderDetail);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                SliderDetail sliderDetail = await _context.SliderDetails.FirstOrDefaultAsync(m => m.Id == id);

                if (sliderDetail is null) return NotFound();

                return View(sliderDetail);

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SliderDetail sliderDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(sliderDetail);
                }

                if (sliderDetail.SignPhoto != null)
                {
                    if (!sliderDetail.SignPhoto.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image type");
                        return View();
                    }

                    if (!sliderDetail.SignPhoto.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image size");
                        return View();
                    }

                    string fileName = Guid.NewGuid().ToString() + "_" + sliderDetail.SignPhoto.FileName;

                    SliderDetail dbSliderDetail = await _context.SliderDetails.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);

                    if (dbSliderDetail is null) return NotFound();

                    if (dbSliderDetail.Header.Trim().ToLower() == sliderDetail.Header.Trim().ToLower()
                        && dbSliderDetail.Description.Trim().ToLower() == sliderDetail.Description.Trim().ToLower()
                        && dbSliderDetail.SignPhoto == sliderDetail.SignPhoto)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    string path = Helper.GetFilePath(_environment.WebRootPath, "img", fileName);

                    using (FileStream stream = new FileStream(path, FileMode.Create))
                    {
                        await sliderDetail.SignPhoto.CopyToAsync(stream);
                    }

                    sliderDetail.SignImage = fileName;

                    _context.SliderDetails.Update(sliderDetail);

                    await _context.SaveChangesAsync();

                    string dbPath = Helper.GetFilePath(_environment.WebRootPath, "img", dbSliderDetail.SignImage);

                    Helper.DeleteFile(dbPath);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            SliderDetail sliderDetail = await _context.SliderDetails.FindAsync(id);

            if (sliderDetail == null) return NotFound();

            string path = Helper.GetFilePath(_environment.WebRootPath, "img", sliderDetail.SignImage);

            Helper.DeleteFile(path);

            _context.SliderDetails.Remove(sliderDetail);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
