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

        public double ConvertCelciusToFahrenheit()
        {
            return (this.tempValue * 1.8) + 32;
        }
        public double ConvertCelciusToKelvin()
        {
            return this.tempValue + 273.15;
        }

        public double ConvertKelvinToFahrenheit()

        {
            return (this.tempValue * (9 / 5)) - 459.67;
        }
        public double ConvertKelvinToCelsius()

        {
            return this.tempValue - 273.15;
        }
        public double ConvertFahrenheitToKelvin()

        {
            return (this.tempValue - 32) * (5 / 9) + 273.15;
        }
        public double ConvertFahrenheitToCelsius()

        {
            return (this.tempValue - 32) * 0.5556;
        }



    }
}
