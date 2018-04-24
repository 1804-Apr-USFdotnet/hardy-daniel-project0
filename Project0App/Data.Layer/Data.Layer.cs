using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer
{
    public class DataLayer
    {
        private static DataLayer dl = null;
        private DataLayer()
        {
            /*Not crystal clear on the seperation of concerns.  This is a Work in progress*/
        }

        public static DataLayer getDataLayerOBJ()
        {
            if (dl == null) dl = new DataLayer();

            return dl;
        }


    }
}
