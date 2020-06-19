using ManualCRUD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManualCRUD.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbContext db = new StudentDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var datalist = db.Students.ToList();
            return View(datalist);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                SaveImageAndGetUrl(student);
                if (TempData["Student"] == null)
                    TempData["Student"] = student;
                db.Students.Add(student);
                db.SaveChanges();
                System.Web.HttpContext.Current.Session["Student"] = student;
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index","Student");
        }
        private void SaveImageAndGetUrl(Student student)
        {
            if (student.ImagePath != null)
            {
                if (student.ImagePath.ContentLength > 0)
                {
                    var fileNames = student.ImagePath.FileName.Replace(" ", string.Empty);
                    var paths = Server.MapPath("~/Images/");
                    student.ImagePath.SaveAs(Server.MapPath("~/Images/" + fileNames));
                    student.Image = fileNames;
                }

            }
        }
    }
}