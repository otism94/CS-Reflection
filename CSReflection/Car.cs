using System;

namespace CSReflection
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int YearOfRegistration { get; set; }
        public double CurrentValue { get; set; }

        public Car(
            string make = "No Make", 
            string model = "No Model", 
            string registration = "No Registration", 
            int yearOfRegistration = 2021, 
            double currentValue = 0)
        {
            Make = make;
            Model = model;
            Registration = registration;
            YearOfRegistration = yearOfRegistration;
            CurrentValue = Math.Round(currentValue, 2);
        }

        public double GetCurrentValue()
        {
            return CurrentValue;
        }

        public int GetYearOfRegistration()
        {
            return YearOfRegistration;
        }

        public override string ToString()
        {
            return $"Make: {Make} | Model: {Model} | Registration: {Registration} | Year Registered: {YearOfRegistration} | Value: £{CurrentValue}";
        }
    }
}
