using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IHomepicRepository
    {
        IQueryable<HomePic> GetAllHomepicDetails();
        HomePic GetHomePic(int id);
        void AddHomepic(HomePic pic);

        void DeleteHomepic(int id);
        bool HomePicExists(int id);
        void EditHomepic(int id, HomePic homePic);
    }
}
