using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Domaine.Entity {
    public class Classroom {
        [Key]
        public int idClassroom { get; set; }
        public string name_classroom { get; set; }
        public virtual ICollection<Student> students { get; set; }

    }
}
