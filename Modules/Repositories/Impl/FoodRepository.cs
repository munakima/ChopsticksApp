using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class FoodRepository : IFoodRepository
    {
       private ChopsticksDBEntities db = null;

       public FoodRepository()
        {
            db = new ChopsticksDBEntities();
        }
       public IQueryable<Food> GetAllFoodsDetails()
        {
            return db.Foods;
        }
       public Food GetFood(int id)
        {
            Food food = db.Foods.Find(id);
            return food;
        }

       public void AddFood(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }

       public void DeleteFood(int id)
        {
            Food food = db.Foods.Find(id);
            db.Foods.Remove(food);
            db.SaveChanges();
        }
       public bool FoodExists(int id)
        {
            return db.Foods.Count(e => e.Id == id) > 0;
        }
       public void EditFood(int id, Food food)
        {
            Food f = db.Foods.Find(id);
            f.CategaryId = food.CategaryId;
            f.Name = food.Name;
            f.Price = food.Price;
            f.Detail = food.Detail;
            db.SaveChanges();
        }
    }
}
