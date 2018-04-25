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

        public List<Resturant> GetTop3Resturants(List<Resturant> list)
        {
            returnList = new List<Resturant>(list.OrderBy(r => r.GetAverageRating()).Take(3));
            return returnList;
        }

        public Resturant GetResturant(List<Resturant> list, string str)
        {
            var list1 = list.Where(x => x.Name.Equals(str));
            return list1.ElementAt(0);
        }
        public List<ResturantRating> GetReviews(List<Resturant> list, string str)
        {
            Resturant r = GetResturant(list, str);
            return r.Ratings;
            
        }
        public List<Resturant> ReturnFromPartial(List<Resturant> list, string str)
        {
            List<Resturant> returnList = (List<Resturant>)list.Where(x => x.Name.StartsWith(str));
            return returnList;
        }



        //For testing purposes only
        //Testing my unit test
        public int Return10()
        { return 13; }
       
    }
}
