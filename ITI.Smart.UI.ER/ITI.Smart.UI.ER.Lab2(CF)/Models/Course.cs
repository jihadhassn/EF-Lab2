using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.ER.Lab2_CF_.Models
{
   public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }

        public Course()
        {
            Students = new HashSet<Student>();
        }
    }
}
