using DAL.Repositories;
using DAL.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFacade     
    {
        //System.Data.Entity.SqlServer.SqlProviderServices sqlCopied =
        //     System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        private IHomepicRepository _homepicRepository;
        private ICategoryRepository _categoryRepository;
        private IFoodRepository _foodRepository;
        private IMenuRepository _menuRepository;
        private IMenuTypeRepository _menuTypeRepository;
        private IBookingRepository _bookingRepository;

        public IHomepicRepository HomepicRepository
        {
            get
            {
                return _homepicRepository == null ? _homepicRepository = new HomepicIHomepicRepository() : _homepicRepository;
            }

        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository == null ? _categoryRepository = new CategoryRepository() : _categoryRepository;
            }

        }
        public IFoodRepository FoodRepository
        {
            get
            {
                return _foodRepository == null ? _foodRepository = new FoodRepository() : _foodRepository;
            }

        }
        public IMenuRepository MenuRepository
        {
            get
            {
                return _menuRepository == null ? _menuRepository = new MenuRepository() : _menuRepository;
            }

        }
        public IMenuTypeRepository MenuTypeRepository
        {
            get
            {
                return _menuTypeRepository == null ? _menuTypeRepository = new MenuTypeRepository() : _menuTypeRepository;
            }

        }
        public IBookingRepository BookingRepository
        {
            get
            {
                return _bookingRepository == null ? _bookingRepository = new BookingRepository() : _bookingRepository;
            }

        }
    }
}
