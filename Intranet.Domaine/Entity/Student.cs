using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Domaine.Entity {
    public class Student {
        [Key]
        public int idStudent { get; set; }
        public string name_student { get; set; }
    }
}
