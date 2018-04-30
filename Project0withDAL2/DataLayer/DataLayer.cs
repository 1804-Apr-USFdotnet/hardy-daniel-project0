using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        
        public IEnumerable<Resturant> getResturants()
        {
            IEnumerable<Resturant> result;
            using (var db = new ResturantDBEntities())
            {
                //var dataList = db.Resturants.ToList();
                result = db.Resturants.ToList();
            }
            return result;
        }
    }
}
