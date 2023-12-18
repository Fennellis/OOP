using _2.Interfaces;

namespace _2.Classes
{
    
    public class Boat : Vehicle, Swimmable
    {
        readonly int maxSpeed = 0;
        bool isSailing = false;

        static private int count = 0;

        public Boat(string brand, string model, int year, int maxSpeed) : base(brand, model, year)
        {
            id = ++count;
            this.maxSpeed = maxSpeed;
        }

        public void startSwimming()
        {
            if (isSailing == false)
            {
                if (isStarted == false)
                {
                    StartEngine();
                }
                isSailing = true;
                System.Console.WriteLine($"Boat {id} started sailing");
            }
            else System.Console.WriteLine($"Boat {id} already started sailing");
        }

        public void stopSwimming()
        {
            if (isSailing == true)
            {
                isSailing = false;
                System.Console.WriteLine($"Boat {id} has finished sailing");
            }
            else System.Console.WriteLine($"Boat {id} already has finished sailing");
        }

        public override void DisplayInfo()
        {
            String status;
            if (isSailing)
                status = "Sailing";
            else status = "Not sailing";
            System.Console.WriteLine($"Boat {id}: (brand: {brand} | model: {model} | " +
                                    $"year: {year} | maxSpeed: {maxSpeed} | " + 
                                    $"currentSpeed: {currentSpeed} | status: {status})");
        }

        public void StartEngine()
        {
            StartEngine("Boat");
        }

        public void StopEngine()
        {
            StopEngine("Boat");
        }

        public void Accelerate(int speed)
        {
            if (currentSpeed + speed > maxSpeed)
                speed = maxSpeed;
            currentSpeed = Accelerate("Boat", speed, isStarted, currentSpeed);
        }
        public override void Brake()
        {
            currentSpeed = Accelerate("Boat",-currentSpeed, isStarted, currentSpeed);
        }
    }
}