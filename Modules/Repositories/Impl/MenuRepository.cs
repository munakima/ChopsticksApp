using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class MenuRepository : IMenuRepository
    {
        private ChopsticksDBEntities db = null;

        public MenuRepository()
        {
            db = new ChopsticksDBEntities();
        }
        public IQueryable<Menu> GetAllMenusDetails()
        {
            return db.Menus;
        }
        public Menu GetMenu(int id)
        {
            Menu menu = db.Menus.Find(id);
            return menu;
        }

        public void AddMenu(Menu menu)
        {
            db.Menus.Add(menu);
            db.SaveChanges();
        }

        public void DeleteMenu(int id)
        {
            Menu menu = db.Menus.Find(id);
            db.Menus.Remove(menu);
            db.SaveChanges();
        }
        public bool MenuExists(int id)
        {
            return db.Menus.Count(e => e.Id == id) > 0;
        }
        public void EditMenu(int id, Menu menu)
        {
            Menu m = db.Menus.Find(id);
            m.MenuTypeId = menu.MenuTypeId;
            m.FoodId = menu.FoodId;
            db.SaveChanges();
        }
        public IQueryable<Menu> getMenuById(int Typeid, int CategoryId)
        {

            var menus=from m in db.Menus
                      where m.MenuTypeId == Typeid
                      && m.Food.CategaryId == CategoryId
                      select m;
            return menus;
        }
    }
}
