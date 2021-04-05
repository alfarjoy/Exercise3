using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise3.Pages
{
    public class EditModel : PageModel
    {
        public EditModel(EnrollmentDBContext enrollmentdbcontext)
        {
            _enrollmentdbcontext = enrollmentdbcontext;
        }

        private readonly EnrollmentDBContext _enrollmentdbcontext;

        [BindProperty]
        public Student Student { get; set; }

        public void OnGet(int id)
        {
            Student = _enrollmentdbcontext.Students.
                FirstOrDefault(students => students.StudentId == id);
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Student stud = new Student();
            stud = _enrollmentdbcontext.Students.FirstOrDefault(student => student.StudentId == Student.StudentId);

            if (stud != null)
            {
                stud.Name = Student.Name;
                stud.Age = Student.Age;
                stud.Address = Student.Address;

                _enrollmentdbcontext.Update(stud);
                _enrollmentdbcontext.SaveChanges();
            }
            return Redirect("Student");

        }
    }
}
