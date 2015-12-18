using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    // Display the number of command line arguments:
            //    ICategoryRepository i = (new DALFacade()).CategoryRepository;
           // IMenuRepository im = (new DALFacade()).MenuRepository;
            IBookingRepository im = (new DALFacade()).BookingRepository;
            //IFoodRepository im = (new DALFacade()).FoodRepository;
            //im.getMenuById(1, 2);
            System.Console.WriteLine("===========id1====== EditHomepic(int id, HomePic homePic);===========================");
            //    //HomePic p1 = new HomePic();

               rlist(im);
               //Food p = new Food();
               //p.Name = "ss";
               //p.CategaryId = 1;
               //p.Price = 22;
               //p.Detail = "detail";
               //im.AddFood(p);
               //rlist(im);
            //    System.Console.WriteLine("===========id1====== EditHomepic(int id, HomePic homePic);===========================");
            //    //HomePic p1 = new HomePic();
            //    //p1.Id = 11;
            //    //if (i.HomePicExists(88))
            //    //{
            //    //    p1.Url = "sdsd11.jpg";
            //    //    i.EditHomepic(11, p1);
            //    //}
            //    //else
            //    //{
            //    //    System.Console.WriteLine("fallll");
            //    //}
            //    //rlist(i);
            //    //System.Console.WriteLine("===========id1====== EditHomepic(int id, HomePic homePic);===========================");
            //    //i.DeleteHomepic(12);
            //    //rlist(i);
              Console.ReadLine();
            //}

            //private static void rlist(ICategoryRepository i)
            //{
            //    foreach (var a in i.GetAllCategoriesDetails())
            //    {
            //        System.Console.WriteLine(a.Id);
            //        System.Console.WriteLine(a.Name);
            //    }
        
        }
        private static void rlist(IBookingRepository i)
        {
            foreach (var a in i.GetAllBookingsDetails())
            {
                System.Console.WriteLine(a.CustName);
                System.Console.WriteLine(a.BookingTime);
            }
        }
    }

}
