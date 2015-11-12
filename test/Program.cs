using Modules;
using Modules.DAL;
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
            // Display the number of command line arguments:
            IHomepicRepository i = (new DALFacade()).HomepicRepository;


            rlist(i);

            System.Console.WriteLine("===========id1====== EditHomepic(int id, HomePic homePic);===========================");
            HomePic p1 = new HomePic();
            p1.Id = 11;
            if (i.HomePicExists(88))
            {
                p1.Url = "sdsd11.jpg";
                i.EditHomepic(11, p1);
            }
            else
            {
                System.Console.WriteLine("fallll");
            }
            rlist(i);
            System.Console.WriteLine("===========id1====== EditHomepic(int id, HomePic homePic);===========================");
            i.DeleteHomepic(12);
            rlist(i);
            Console.ReadLine();
        }

        private static void rlist(IHomepicRepository i)
        {
            foreach (var a in i.GetAllHomepicDetails())
            {
                System.Console.WriteLine(a.Id);
                System.Console.WriteLine(a.Url);
            }
        }
    }
}
