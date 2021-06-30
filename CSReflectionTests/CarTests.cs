using Xunit;

namespace CSReflection.Tests
{
    public class CarTests
    {
        [Fact()]
        public void GetCurrentValueTest()
        {
            string make = "Ford";
            string model = "Fiesta";
            string registration = "WP47UQR";
            int year = 2020;
            double value = 2152.99;

            Car FordFiesta = new(make, model, registration, year, value);
            Assert.Equal(value, FordFiesta.GetCurrentValue());
        }

        [Fact()]
        public void GetYearOfRegistrationTest()
        {
            string make = "Ford";
            string model = "Fiesta";
            string registration = "WP47UQR";
            int year = 2020;
            double value = 2152.99;

            Car FordFiesta = new(make, model, registration, year, value);
            Assert.Equal(year, FordFiesta.GetYearOfRegistration());
        }

        [Fact()]
        public void ToStringTest()
        {
            string make = "Ford";
            string model = "Fiesta";
            string registration = "WP47UQR";
            int year = 2020;
            double value = 2152.99;

            Car FordFiesta = new(make, model, registration, year, value);
            Assert.Contains($"Make: {make} | Model: {model} | Registration: {registration} | Year Registered: {year} | Value: £{value}",
                FordFiesta.ToString());
        }
    }
}