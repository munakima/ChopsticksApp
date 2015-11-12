using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.DAL.Impl
{
    public class HomepicIHomepicRepository : IHomepicRepository
    {
        private ChopsticksDBEntities db = null;

        //  public HomepicIHomepicRepository(ChopsticksDBEntities1 db)
        //  {
        //      this.db = db;
        //  }
        public HomepicIHomepicRepository()
        {
            db = new ChopsticksDBEntities();
        }
        public IQueryable<HomePic> GetAllHomepicDetails()
        {
            return db.HomePics;
        }
        public HomePic GetHomePic(int id)
        {
            HomePic homePic = db.HomePics.Find(id);
            return homePic;
        }

        public void AddHomepic(HomePic pic)
        {
            db.HomePics.Add(pic);
            db.SaveChanges();
        }

        public void DeleteHomepic(int id)
        {
            HomePic homePic = db.HomePics.Find(id);
            db.HomePics.Remove(homePic);
            db.SaveChanges();
        }
        public bool HomePicExists(int id)
        {
            return db.HomePics.Count(e => e.Id == id) > 0;
        }
        public void EditHomepic(int id, HomePic homePic)
        {
            HomePic pic = db.HomePics.Find(id);
            pic.Url = homePic.Url;
            db.SaveChanges();
        }
    }
}
