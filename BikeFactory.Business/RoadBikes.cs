using BikeFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public class RoadBikes:Bike
    {
        private ETireType _etiretype;

        public RoadBikes(ETireType etiretype)
        {
            _etiretype = etiretype;
        }

        public ETireType ETiretype
        {
            get { return _etiretype; }
            set { _etiretype = value; } 
        }
        public RoadBikes()
        {

        }
        public override string ToString()
        {
            return "BikeType: Road"+ base.ToString() + $" ,    TireType: {_etiretype}";
        }

    }
}
