using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class MenuTypeRepository : IMenuTypeRepository
    {
        private ChopsticksDBEntities db = null;

        public MenuTypeRepository()
        {
            db = new ChopsticksDBEntities();
        }
        public IQueryable<MenuType> GetAllMenuTypesDetails()
        {
            return db.MenuTypes;
        }
        public MenuType GetMenuType(int id)
        {
            MenuType menuType = db.MenuTypes.Find(id);
            return menuType;
        }
    }
}
