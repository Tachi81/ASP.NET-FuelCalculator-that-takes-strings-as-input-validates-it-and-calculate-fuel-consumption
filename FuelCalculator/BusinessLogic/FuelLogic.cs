using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuelCalculator.Models;

namespace FuelCalculator.BusinessLogic
{
    public class FuelLogic
    {
        private ServiceFuel.ServiceFuel _service;

        public FuelLogic()
        {
            _service = new ServiceFuel.ServiceFuel();
        }

        public void CalcAvgConsumption(Fuel model)
        {
            if (_service.StringToIntt(model.Distance) == 0)
            {
                model.Result = "Field Fuel can not be 0";
            }
            if (_service.StringToIntt(model.Distance) == -1 || _service.StringToIntt(model.FuelUsed) == -1)
            {
                model.Result = "Both fields must be fullfilled with numbers - not letters";
            }
            else
            {
                model.Result = $"Spalanie twojego auta to {_service.StringToFloat(model.FuelUsed) * 100 / _service.StringToIntt(model.Distance)} l/100km";

            }

        }
    }
}