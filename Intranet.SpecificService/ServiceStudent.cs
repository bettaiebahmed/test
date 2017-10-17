using Intranet.Data.Infrastructure;
using Intranet.Domaine.Entity;
using Intranet.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.SpecificService {
    public class ServiceStudent : Service<Student>, IserviceStudent { 
            private static IDatabaseFactory db = new DatabaseFactory();
            private static IUnitOfWork uow = new UnitOfWork(db);
          public ServiceStudent():base(uow)
          {

         }

}
}
