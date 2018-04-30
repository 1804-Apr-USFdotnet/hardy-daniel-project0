using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public IEnumerable<Models.Resturant> GetResturants()
        {
            IEnumerable<Models.Resturant> result;

            using (var dbcontext = new ResturantDBEntities())
            {
                var entities = dbcontext.Resturants.ToList();
                result = entities.Select(x => DataToModel(x)).ToList();
            }
            return result.ToList();

        }

        public void addResturant(Models.Resturant model)
        {
            using (var dbcontext = new ResturantDBEntities())
            {
                dbcontext.Resturants.Add(ModelToData(model));
                dbcontext.SaveChanges();
            }
        }

        //Mapping

        public static Resturant ModelToData(Models.Resturant model)
        {
            DataLayer.Resturant r = new DataLayer.Resturant();
            r.Name = model.Name;
            r.Address = model.Address;
            r.City = model.City;
            r.State = model.State;
            r.FoodType = model.FoodType;
            foreach (var rev in model.Reviews)
            {
                var tmp = new DataLayer.Review
                {
                    Author = rev.Author,
                    Rating = rev.Rating,
                    Comment = rev.Comment
                };
                r.Reviews.Add(tmp);
            }

            return r;
        }

        public static Models.Resturant DataToModel(Resturant data)
        {
            Models.Resturant r = new Models.Resturant();
            r.Name = data.Name;
            r.Address = data.Address;
            r.City = data.City;
            r.State = data.State;
            r.FoodType = data.FoodType;
            r.Reviews = new List<Models.Review>();
            foreach ( var rev in data.Reviews)
            {
                var tmp = new Models.Review
                {
                    Author = rev.Author,
                    Rating = rev.Rating,
                    Comment = rev.Comment
                };
                r.Reviews.Add(tmp);
            }

            return r;
        }
    }
}
