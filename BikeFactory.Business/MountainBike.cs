using BikeFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public class MountainBike:Bike
    {
        private EsuspensionType _esuspensiontype;

        public MountainBike(EsuspensionType esuspensiontype)
        {
            _esuspensiontype = esuspensiontype;
        }
        public MountainBike()
        {

        }

        public EsuspensionType EsuspensionType
        {
            get { return _esuspensiontype; }
            set { _esuspensiontype = value; }   
        }
        public override string ToString()
        {
            return "BikeType:  Mountain"+  base.ToString() + $" ,    SuspensionType: {_esuspensiontype}";  
        }
    }
}
