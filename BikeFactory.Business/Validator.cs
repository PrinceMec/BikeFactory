using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public class Validator
    {
        public static bool ValidateId(string inputtocheck)
        {
            return int.TryParse(inputtocheck, out _);
        }
        public static bool ValidateUniquesn(string inputtocheck, List<Bike> listofbikes)
        {
            int serialno = Convert.ToInt32(inputtocheck);
            foreach (Bike bike in listofbikes)
            {
                if (bike.Serialnumber == serialno)
                    return false;
            }
            return true;
        }

        public static bool ValidateModel(string inputtocheck)
        {
            return Regex.IsMatch(inputtocheck, @"^\w{5}$");
        }
        public static bool Validateyear(string inputtocheck)
        {
            return Regex.IsMatch(inputtocheck, @"^\w{4}$");
        }


    }
}
