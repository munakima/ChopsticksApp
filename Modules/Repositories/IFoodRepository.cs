using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IFoodRepository
    {
        IQueryable<Food> GetAllFoodsDetails();
        Food GetFood(int id);

        void AddFood(Food food);

        void DeleteFood(int id);
        bool FoodExists(int id);
        void EditFood(int id, Food food);
    }
}
