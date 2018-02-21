using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelCalculator.ServiceFuel
{
    public class ServiceFuel
    {
        public float StringToFloat(string text)
        {
            try
            {
                var floatted = float.Parse(text);
                return floatted;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        

        public int StringToIntt(string text)
        {
            try
            {
                var inted = int.Parse(text);
                return inted;
            }
            catch (Exception )
            {
                return -1;
            }
        }
    }
}