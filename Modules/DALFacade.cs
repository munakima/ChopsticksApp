using Modules.DAL;
using Modules.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class DALFacade
    {
        private IHomepicRepository _homepicRepository;

        public IHomepicRepository HomepicRepository
        {
            get
            {
                return _homepicRepository == null ? _homepicRepository = new HomepicIHomepicRepository() : _homepicRepository;
            }

        }
    }
}
