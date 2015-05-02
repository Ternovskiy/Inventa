using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace InventaDataModul
{
    public partial class Repository : IRepository
    {
        [Inject]
        public DataClassesInventaDataContext Db { get; set; }

    }
}
