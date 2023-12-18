namespace _2.Classes
{
    public class Car : Vehicle
    {
        private readonly int fuelCapacity;
        private int currentFuelLevel;

        // private int currentSpeed;

        static private int count = 0;

        public Car(String brand, String model, int year, int fuelCapacity, int currentFuelLevel) : base(brand, model, year)
        {
            id = ++count;
            this.fuelCapacity = fuelCapacity;
            this.currentFuelLevel = currentFuelLevel;
        }

        public Car() : this("N/A", "N/A", 0, 0, 0)
        {}
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Car {id}: (brand: {brand} | model: {model} | year: {year} | fuelCapacity: {fuelCapacity} | currentFuelLevel: {currentFuelLevel} | currentSpeed: {currentSpeed})");
        }

        public void StartEngine()
        {
            StartEngine("Car");
        }
        public void StopEngine()
        {
            StopEngine("Car");
        }
        public void Accelerate(int speed)
        {
            currentSpeed = Accelerate("Car", speed, isStarted, currentSpeed);
        }
        public override void Brake()
        {
            currentSpeed = Accelerate("Car",-currentSpeed, isStarted, currentSpeed);
        }
        public void Refuel(int liters)
        {
            currentFuelLevel += liters;
            int overflow = 0;
            if (currentFuelLevel > fuelCapacity)
            {
                overflow = currentFuelLevel - fuelCapacity;
                currentFuelLevel = fuelCapacity;
            }
            System.Console.Write($"Fuelled by {liters - overflow} liters.");
            if (currentFuelLevel == fuelCapacity)
                System.Console.WriteLine($" The tank is full");
            else System.Console.WriteLine($" Current fuel level: {currentFuelLevel}");
        }
    }
}