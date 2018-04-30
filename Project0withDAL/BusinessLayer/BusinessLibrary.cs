using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class BusinessLibrary
    {
        //Resturant r = new Resturant();
        DataLayer.DataManager data;

        public BusinessLibrary()
        {
            data = new DataLayer.DataManager();
        }

        public List<Models.Resturant> getAllResturants()
        {
            List<Models.Resturant> result = data.GetResturants().ToList();
            return result;
        }

        public List<Models.Resturant> getTopResturants()
        {
            List<Models.Resturant> tmp = data.GetResturants().ToList();
            List<Models.Resturant> results = tmp.OrderByDescending(x => x.getAverageRating()).Take(3).ToList();
            return results;
        }

        public List<Models.Resturant> getResturantsbyState()
        {
            List<Models.Resturant> tmp = data.GetResturants().ToList();
            List<Models.Resturant> results = tmp.OrderBy(x => x.State).ToList();
            return results;
        }

        public List<Models.Resturant> SearchRestutants(string partial)
        {
            List<Models.Resturant> tmp = data.GetResturants().ToList();
            List<Models.Resturant> results = tmp.Where(x => x.Name.Contains(partial)).ToList();
            return results;
        }

        public List<Models.Resturant> getResturantsbyName()
        {
            List<Models.Resturant> tmp = data.GetResturants().ToList();
            List<Models.Resturant> results = tmp.OrderBy(x => x.Name).ToList();
            return results;
        }


    }
}
