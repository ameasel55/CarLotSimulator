using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot myCarLot = new CarLot();


            Car myCar = new Car();
            myCar.EngineNoise = "Extremely Noisy";
            myCar.HornNoise = "Has a weak little beep beep with asthma";

            myCarLot.ListOfCars.Add(myCar);
           
            Car myCar2 = new Car();
            myCar2.EngineNoise = "Sounds like a cement grinder";
            myCar2.HornNoise = "Has a horn that plays that song like Rodney Dangerfield's horn in Caddyshack";

            myCarLot.ListOfCars.Add(myCar2);


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            myCar.Make = "Mercury";
            myCar.Model = "Grand Marquis";
            myCar.Year = 1994;
            myCar.IsDrivable = true;

            Console.WriteLine($"Make of the car: {myCar.Make}");
            Console.WriteLine($"Model of the car: {myCar.Model}");
            Console.WriteLine($"Year of the car: {myCar.Year}");
            Console.WriteLine($"Engine Noise of the car: {myCar.EngineNoise}");
            Console.WriteLine($"Horn Noise of the car: {myCar.HornNoise}");
            Console.WriteLine($"True of false; this car is drivable: {myCar.IsDrivable}");

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            myCar2.Make = "Chevy";
            myCar2.Model = "El Camino";
            myCar2.Year = 1983;
            myCar2.IsDrivable = true;

            Console.WriteLine($"Make of the car: {myCar2.Make}");
            Console.WriteLine($"Model of the car: {myCar2.Model}");
            Console.WriteLine($"Year of the car: {myCar2.Year}");
            Console.WriteLine($"Engine Noise of the car: {myCar2.EngineNoise}");
            Console.WriteLine($"Horn Noise of the car: {myCar2.HornNoise}");
            Console.WriteLine($"True or false; this car is drivable: {myCar2.IsDrivable}");

        


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var pontiac = new Car()
            {
                Make = "Pontiac",
                Model = "Grand Am",
                Year = 1996,
                EngineNoise = "sounds like my dad when he burps",
                HornNoise = "Makes a very unintimadating high pitched little meep meep",
                IsDrivable = true
                
            };

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine($"Make of the car: {pontiac.Make}");
            Console.WriteLine($"Model of the car: {pontiac.Model}");
            Console.WriteLine($"Year of the car: {pontiac.Year}");
            Console.WriteLine($"Engine noise of the car: {pontiac.EngineNoise}");
            Console.WriteLine($"Horn noise of the car: {pontiac.HornNoise}");
            Console.WriteLine($"True or false; this car is drivable: {pontiac.IsDrivable}");

            myCarLot.ListOfCars.Add(pontiac);

            var ford = new Car("Ford", "Aspire", 1993, "Sounds like putting silverware in a blender",
                "sounds like a sinking tugboat", false);
            
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine($"Make of the car: {ford.Make}");
            Console.WriteLine($"Model of the car: {ford.Model}");
            Console.WriteLine($"Year of the car: {ford.Year}");
            Console.WriteLine($"Engine noise of the car: {ford.EngineNoise}");
            Console.WriteLine($"Horn noise of the car: {ford.HornNoise}");
            Console.WriteLine($"True or false; this car is drivable: {ford.IsDrivable}");

            myCarLot.ListOfCars.Add(ford);

            Console.WriteLine();
            foreach (var car in myCarLot.ListOfCars)
            {
                Console.WriteLine(car.Year);

                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine();
            }

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program
            //and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
