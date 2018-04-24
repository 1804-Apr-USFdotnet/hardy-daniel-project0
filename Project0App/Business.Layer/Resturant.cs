using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer
{
    public class Resturant
    {
        public List<ResturantRating> Ratings { get; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string FoodType { get; set; }
         

        public Resturant()
        {

        }

        public float GetAverageRating()
        {
            int i = 0;
            foreach (var rnk in Ratings )
            {
                i += rnk.Rating;
            }

            return i / Ratings.Count;
        }

        
        public void AddRating(ResturantRating r)
        {
            Ratings.Add(r);
        }
        
    }
}
