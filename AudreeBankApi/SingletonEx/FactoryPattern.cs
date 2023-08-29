using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class FactoryPattern
    {
        public static Vehicle CreateVehicle(string vehicleType)
        {            
            if (vehicleType == "Car")
            {
                return new Car();
            }
            else if(vehicleType == "Bus")
            {
                return new Bus();
            }
            else if (vehicleType == "Truck")
            {
                return new Bus();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
