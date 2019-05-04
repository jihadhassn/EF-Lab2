using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.ER.Lab2_CF_.Models
{
  public  class Student
    {
        //public Student()
        //{
        //    Courses = new HashSet<Course>();
        //}
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int Fk_SchoolId { get; set; }
      public ContactInfo ContactInfo { get; set; }
        public School School { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
