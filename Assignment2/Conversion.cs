using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Conversion
    {
        private int tempValue;
    
        public Conversion()
        {
            this.tempValue = 1;
        }

        public Conversion(int tempValue)
        {
            this.tempValue = tempValue;
        }

        public double ConvertCelciusToFahrenheit() // 1
        {
            return (this.tempValue * 1.8) + 32;
        }
        public double ConvertCelciusToKelvin() // 2
        {
            return this.tempValue + 273.15;
        }

        public double ConvertFahrenheitToCelsius() // 3
        {
            return (this.tempValue - 32) * 5/9;
        }
      
        public double ConvertFahrenheitToKelvin() // 4
        {
            return (this.tempValue - 32) * (5 / 9) + 273.15;
        }

        public double ConvertKelvinToCelsius() // 5
        {
            return this.tempValue - 273.15;
        }

        public double ConvertKelvinToFahrenheit() // 6
        {
            return (this.tempValue - 273.15) * (9 / 5) + 32;
        }






    }
}
