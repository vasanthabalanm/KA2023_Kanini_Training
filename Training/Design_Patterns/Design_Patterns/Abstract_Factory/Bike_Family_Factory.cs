using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Bike_Family_Factory : Vehicle_Family_Factory
    {
        public override Vehicle_Factory CreateBikeFactory()
        {
            throw new NotImplementedException();
        }

        public override Vehicle_Factory CreateCarFactory()
        {
            throw new NotImplementedException();
        }
    }
}
