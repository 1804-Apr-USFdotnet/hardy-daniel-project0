using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Project0withDAL
{
    public class BusinessLayer
    {
        DataManager dm;
        public BusinessLayer()
        {
            dm = new DataManager();
        }

        public List<Resturant> getTopResturants()
        {
            var tmp = new List<Resturant>(dm.getResturants().ToList());
            var result = tmp.OrderBy(x => x.getAverageRating()).ToList();
            return (List<Resturant>)result;
        }

        
    }
}
