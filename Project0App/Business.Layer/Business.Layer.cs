using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Layer;
namespace Business.Layer
{
    public class BusinessLayer
    {
        //public string Test()
        //{
        //    return "This is only a test";
        //}
        private DataLayer dl;
        List<Resturant> returnList;

        public BusinessLayer()
        {
            dl = DataLayer.getDataLayerOBJ();
        }

        public List<Resturant> GetAllResturants(List<Resturant> list)
        {
            returnList = new List<Resturant>(list);
            return returnList;
        }

        public List<Resturant> GetTopResturants(List<Resturant> list)
        {
            returnList = new List<Resturant>(list.OrderBy(r => r.GetAverageRating()).Take(3));
            return returnList;
        }

        public Resturant GetResturant(List<Resturant> list, string str)
        {
            var list1 = list.Where(x => x.Name.Equals(str));
            return list1.ElementAt(0);
        }


        
        //For testing purposes only
        //Testing my unit test
        public int Return10()
        { return 13; }
       
    }
}
