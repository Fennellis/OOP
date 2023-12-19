namespace _2.Classes
{
    public abstract class Vehicle
    {
        protected int id;
        protected String brand;
        protected String model;
        protected int year;
        protected int currentSpeed;
        protected bool isStarted = false;

        protected Vehicle(String brand, String model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
        public void StartEngine(String className)
        {
            if (isStarted == false)
            {
                isStarted = true;
                System.Console.WriteLine($"{className} {id} engine: started");
            }
            else System.Console.WriteLine($"{className} {id} engine already started");
        }
        public void StopEngine(String className)
        {
            if (isStarted == true)
            {
                isStarted = false;
                System.Console.WriteLine($"{className} {id} engine: stopped");
            }
            else System.Console.WriteLine($"{className} {id} engine already stopped");
        }
        protected void Accelerate(String className, int speed, bool isStarted)
        {
            if (isStarted == false)
                StartEngine(className);
            
            String str;
            if (speed > currentSpeed)
                str = "up";
            else str = "down";

            System.Console.WriteLine($"{className} {id} speed {str} to {speed} km/h");
            currentSpeed = speed;
            if (currentSpeed == 0)
                System.Console.WriteLine($"{className} {id} has stopped");
        }
        public abstract void Brake();

        public abstract void DisplayInfo();
    }
}