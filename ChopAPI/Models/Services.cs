using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modules;
using Modules.DAL;
using Modules.DAL.Impl;

namespace ChopAPI.Models
{
    public class Services
    {
        private IHomepicRepository _homepicRepository = (new DALFacade()).HomepicRepository;
        public IHomepicRepository HomepicRepository
        {
            get
            {
                return _homepicRepository == null ? _homepicRepository = new HomepicIHomepicRepository() : _homepicRepository;
            }

        }
    }
}