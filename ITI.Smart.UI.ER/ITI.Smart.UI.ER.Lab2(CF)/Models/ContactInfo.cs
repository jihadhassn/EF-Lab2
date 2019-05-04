using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.ER.Lab2_CF_.Models
{
   public class ContactInfo
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public Student Student { get; set; }
    }
}
