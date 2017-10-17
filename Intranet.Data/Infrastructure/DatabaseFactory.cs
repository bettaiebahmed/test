using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intranet.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private IntranetContext dataContext;
        public IntranetContext DataContext { get { return dataContext; } }
        public DatabaseFactory()
        {
            dataContext = new IntranetContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }


}
