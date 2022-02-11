using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Temperture Convertor");
            Console.Write("Enter a Temperture value you want to convert: ");
            int userInput;
            while(!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("You entered wrong value, enter again:  ");
            }


            Conversion conversion = new Conversion(userInput);
    

            int selectedValue;
          
            bool exitFlag = false;
            string strInput;

            string displayString = "1. Convert Celsius to Fahrenheit\n" +
           "2. Convert Celsius to Kelvin\n" +
           "3. Convert Fahrenheit to Celsius\n" +
           "4. Convert Fahrenheit to Kelvin\n" +
           "5. Convert Kelvin to Celsius\n" +
           "6. Convert Kelvin to Fahrenheit\n" +
           "7. Exit\n" +
           "Please select one conversation option: ";

          
            while (!exitFlag)
            {
               
                Console.Write(displayString);
                strInput = Console.ReadLine();

                if (int.TryParse(strInput,out selectedValue))
                {
                    if(0 < selectedValue &&  selectedValue < 8)
                    {

                        switch(selectedValue)
                        {
                            case 1:
                                Console.WriteLine($"{userInput} C = {conversion.ConvertCelciusToFahrenheit()} F" );
                                break;
                            case 2:
                                Console.WriteLine($"{userInput} C = {conversion.ConvertCelciusToKelvin()} K");
                                break;
                            case 3:
                                Console.WriteLine($"{userInput} F = {conversion.ConvertFahrenheitToCelsius()} C");
                                break;
                            case 4:
                                Console.WriteLine($"{userInput} F = {conversion.ConvertFahrenheitToKelvin()} K");
                                break;
                            case 5:
                                Console.WriteLine($"{userInput} K = {conversion.ConvertKelvinToCelsius()} C");
                                break;
                            case 6:
                                Console.WriteLine($"{userInput} K = {conversion.ConvertKelvinToFahrenheit()} F");
                                break;
                            case 7:
                                exitFlag = true;
                                break;


                        }
                    }
                    else
                    {
                        Console.Write("Input from 1-7 only, try again: ");
                    }
                }
                else
                {
                    Console.Write("Enter only numeric value, try again: ");
                }

            }

            Console.ReadKey();
            
        }
    }
}
