using _2.Interfaces;

namespace _2.Classes
{
    public class Aircraft : Vehicle, Flyable
    {
        readonly int maxAltitude;
        readonly int maxSpeed;
        readonly int minTakeOffSpeed;
        int currentHeight;
        bool isFlying = false;
        static private int count = 0;

        public Aircraft(String brand, String model, int year, int minTakeOffSpeed, int maxSpeed, int maxAltitude) : base(brand, model, year)
        {
            id = ++count;
            this.minTakeOffSpeed = minTakeOffSpeed;
            this.maxSpeed = maxSpeed;
            this.maxAltitude = maxAltitude;
        }

        public Aircraft() : this("N/A", "N/A", 0, 0, 0, 0)
        {}
        public void Land()
        {
            if (currentSpeed > 80)
            {
                System.Console.WriteLine("Too fast for landing");
                return;
            }

            isFlying = false;
            System.Console.WriteLine("The plane landed successfully");
            Accelerate(10);
        }

        public void TakeOff()
        {
            if (currentSpeed >= minTakeOffSpeed)
            {
                isFlying = true;
                System.Console.WriteLine("The plane took off successfully");
                ChangeHeight(1000);
            }
        }

        public void ChangeHeight(int height)
        {
            if (height == currentHeight)
                return;
            String word;
            if (height > maxAltitude)
                height = maxAltitude;
            if (height > currentHeight)
                word = "gain";
            else word = "reduces";
            System.Console.WriteLine($"The plane {word} a height to {height}");
            
            currentHeight = height;
            if (currentHeight == maxAltitude)
                System.Console.WriteLine("The maximum height has been achieved");
        }

        public override void DisplayInfo()
        {
            String status;
            if (isFlying)
                status = "Flying";
            else status = "Landed";
            System.Console.WriteLine($"Aircraft {id}: (brand: {brand} | model: {model} | "
                                    +$"year: {year} | minTakeOffSpeed: {minTakeOffSpeed} | "
                                    +$"maxSpeed: {maxSpeed} | maxAltitude: {maxAltitude} Status: {status})");
        }

        public void StartEngine()
        {
            StartEngine("Aircraft");
        }

        public void StopEngine()
        {
            StopEngine("Aircraft");
        }

        public void Accelerate(int speed)
        {
            if (currentSpeed + speed > maxSpeed)
                speed = maxSpeed;
            currentSpeed = Accelerate("Aircraft", speed, isStarted, currentSpeed);
        }

        public override void Brake()
        {
            if (isFlying)
            {
                System.Console.WriteLine("It is impossible to stop movement");
                return;
            }

            currentSpeed = Accelerate("Aircraft",-currentSpeed, isStarted, currentSpeed);
        }
    }
}