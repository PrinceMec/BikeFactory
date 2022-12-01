using BikeFactory.Business.Enums;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BikeFactory.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBikes))]
    public class Bike
    {
        private int _serialnumber;
        private string _name = "";
        private string _model = "";
        private string _biketype = "";
        private int _year;
        private Color _Color;

        public int Serialnumber
        {
            get { return _serialnumber; }
            set { _serialnumber = value; }
        }
       public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Biketype
        {
            get { return _biketype; }
            set { _biketype = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public Color Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        public Bike()
        {

        }

        public override string ToString()
        {
            return $" ,    Serial.no: {_serialnumber} ,    Name: {_name} ,    Model: {_model} ,    Color: {_Color} ,     Manufacturing year: {_year}";
        }


    }
}
