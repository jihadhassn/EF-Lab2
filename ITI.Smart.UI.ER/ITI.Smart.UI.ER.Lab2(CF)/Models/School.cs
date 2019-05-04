using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.ER.Lab2_CF_.Models
{
   public class School
    {
        public School()
        {
            Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
