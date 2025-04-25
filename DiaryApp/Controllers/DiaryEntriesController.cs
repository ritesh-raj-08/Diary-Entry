using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)


        {
            if (obj == null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title is too short");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj); // Adds the new diary entry to the database
                _db.SaveChanges();   // this will save the chsnges to the database and add your data to database

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id)

        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)


        {
            if (obj == null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title is too short");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj); // Update the new diary entry to the database
                _db.SaveChanges();   // this will save the chsnges to the database and add your data to database

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)

        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);


            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)


        {
                _db.DiaryEntries.Remove(obj); // Remove the new diary entry to the database
                _db.SaveChanges();   // this will save the chsnges to the database and add your data to database

                return RedirectToAction("Index");
            
            
        }

    }
}
