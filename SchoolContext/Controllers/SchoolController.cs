using System.Linq;
using System.Web.Mvc;
using SchoolContext.Models;

namespace SchoolContext.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext.Models.SchoolContext db = new SchoolContext.Models.SchoolContext();

        // عرض الطلاب
        public ActionResult Students()
        {
            var students = db.Students.ToList();
            return View(students);
        }

        // عرض الدورات
        public ActionResult Courses()
        {
            var courses = db.Courses.ToList();
            return View(courses);
        }

        // إضافة طالب جديد
        [HttpPost]
        public ActionResult AddStudent(string firstName, string lastName)
        {
            var student = new Student { FirstName = firstName, LastName = lastName };
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Students");
        }

        // إضافة دورة جديدة
        [HttpPost]
        public ActionResult AddCourse(string courseName)
        {
            var course = new Course { CourseName = courseName };
            db.Courses.Add(course);
            db.SaveChanges();
            return RedirectToAction("Courses");
        }
    }
}
