//namespace Lesson10
//{
//    class Classwork
//    {
//        static void Main()
//        {
//            ////приклад1
//            //Car car = new Car();
//            //Console.WriteLine($"Car color is { car.color}");
//            //car.color = "blue";
//            //Console.WriteLine($"Car color is {car.color}");

//            //Car myObj = new Car();
//            //Console.WriteLine(myObj.color);

//            //Car myObj1 = new Car();
//            //Car myObj2 = new Car();
//            //myObj1.color = "green";
//            //myObj2.color = "grey";
//            //Console.WriteLine(myObj1.color);
//            //Console.WriteLine(myObj2.color);


//            ////приклад2
//            //var myCar = new MyClass();
//            //myCar.fullThrottle();
//            //myCar.GetColorOfMyCar();


//            ////приклад3
//            //Car myCar = new Car();
//            //Console.WriteLine(myCar.model);


//            ////приклад4
//            //Car myCar = new Car();
//            //Console.WriteLine(myCar.model);
//            //Car Ford = new Car("Mustang", "Red", 1969);
//            //Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);


//            ////приклад5
//            //TemperatureConverter.CelsiusToFahrenheit("15");


//            ////приклад6
//            //Automobile.Drive();
//            //int i = Automobile.NumberOfWheels;

//            //приклад7
//            Bank b1 = new Bank(1000000);
//            Console.WriteLine("Current bonus percent:" + Bank.GetBonus());
//            Console.WriteLine("Your deposit on {0:C}, you can take in cash dept: {1:C}", 10000, b1.GetPercent(10000));
//        }
//    }


//    ////приклад1
//    //public class Car
//    //{
//    //    public string color = "red";
//    //}


//    ////приклад2
//    //// The class
//    //class MyClass
//    //{
//    //    // Class members
//    //    string color = "red";        // field
//    //    int maxSpeed = 200;          // field
//    //    public void fullThrottle()   // method
//    //    {
//    //        Console.WriteLine("The car is going as fast as it can!");
//    //    }

//    //    public void GetColorOfMyCar()
//    //    {
//    //        Console.WriteLine(color +" "+ maxSpeed);
//    //    }
//    //}


//    ////приклад3
//    //class Car
//    //{
//    //    public string model;  // Create a field

//    //    // Create a class constructor for the Car class
//    //    public Car()
//    //    {
//    //        model = "Mustang"; // Set the initial value for model
//    //    }
//    //}


//    ////приклад4
//    //class Car
//    //{
//    //    public string model;
//    //    public string color;
//    //    public int year;

//    //    public Car()
//    //    { 

//    //    }

//    //    // Create a class constructor with multiple parameters
//    //    public Car(string modelName, string modelColor, int modelYear)
//    //    {
//    //        model = modelName;
//    //        color = modelColor;
//    //        year = modelYear;
//    //    }
//    //}


//    ////приклад5 (статичний клас)
//    //public static class TemperatureConverter
//    //{
//    //    public static double CelsiusToFahrenheit(string temperatureCelsius)
//    //    {
//    //        // Convert argument to double for calculations.
//    //        double celsius = Double.Parse(temperatureCelsius);
//    //        // Convert Celsius to Fahrenheit.
//    //        double fahrenheit = (celsius * 9 / 5) + 32;
//    //        return fahrenheit;
//    //    }
//    //    public static double FahrenheitToCelsius(string temperatureFahrenheit)
//    //    {
//    //        // Convert argument to double for calculations.
//    //        double fahrenheit = Double.Parse(temperatureFahrenheit);
//    //        // Convert Fahrenheit to Celsius.
//    //        double celsius = (fahrenheit - 32) * 5 / 9;
//    //        return celsius;
//    //    }
//    //}


//    ////приклад6
//    //public class Automobile
//    //{
//    //    public static int NumberOfWheels = 4;
//    //    public static int SizeOfGasTank
//    //    {
//    //        get
//    //        {
//    //            return 15;
//    //        }
//    //    }
//    //    public static void Drive() { }        
//    //    // Other non-static fields and properties...
//    //}


//    //приклад7
//    class Bank
//    {
//        private double _currentBalance;
//        private static double _bonus;
//        public Bank(double balance)
//        {
//            _currentBalance = balance;
//        }
//        static Bank()
//        {
//            _bonus = 1.04;
//        }
//        public static void SetBonus(double newRate)
//        {
//            _bonus = newRate;
//        }
//        public static double GetBonus()
//        {
//            return _bonus;
//        }
//        public double GetPercent(double summa)
//        {
//            if ((_currentBalance - summa) > 0)
//            {
//                double percent = summa * _bonus;
//                _currentBalance -= percent;
//                return percent;
//            }
//            return -1;
//        }
//    }
//}