using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IMenuRepository
    {
        IQueryable<Menu> GetAllMenusDetails();
        Menu GetMenu(int id);
        void AddMenu(Menu menu);

        void DeleteMenu(int id);
        bool MenuExists(int id);
        void EditMenu(int id, Menu menu);
        IQueryable<Menu> getMenuById(int Typeid, int CategoryId);
    }
}
