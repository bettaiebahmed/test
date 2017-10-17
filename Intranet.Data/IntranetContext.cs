using Intranet.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Data {
    public class IntranetContext :DbContext {


        public IntranetContext(): base("Name=IntranetConnection") {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }



    }
}
