using _2.Interfaces;

namespace _2.Classes
{
    public class Aircraft : Vehicle, Flyable
    {
        readonly int maxAltitude;
        readonly int maxSpeed;
        int maxLandSpeed = 120;
        readonly int minLandHeight = 400;
        readonly int minTakeOffSpeed;
        int currentHeight;
        bool isFlying = false;
        bool isLandPossible;
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
        protected int MaxLandSpeed
        {
            get {return maxLandSpeed;}
            set {maxLandSpeed = value;}
        }
        public void Land()
        {
            if (isFlying == false)
            {
                System.Console.WriteLine("The plane has already landed");
                return;
            }

            System.Console.WriteLine("Preparations for landing the plane begin");
            ChangeHeight(minLandHeight);
            Accelerate(MaxLandSpeed);

            isFlying = false;
            System.Console.WriteLine("The plane landed successfully");
            Accelerate(10);
        }

        public void TakeOff()
        {
            if (isFlying == true)
            {
                System.Console.WriteLine("The plane has already taken off");
                return;
            }
                
            if (currentSpeed >= minTakeOffSpeed)
            {
                isFlying = true;
                System.Console.WriteLine("The plane took off successfully");
                ChangeHeight(1000);
            }
            isLandPossible = true;
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
            System.Console.WriteLine($"Aircraft {id}: (brand: {brand} | model: {model} | year: {year} | "
                                    +$"currentSpeed: {currentSpeed} | minTakeOffSpeed: {minTakeOffSpeed} | "
                                    +$"maxSpeed: {maxSpeed} | currentHeight: {currentHeight} | maxAltitude: {maxAltitude} Status: {status})");
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
            Accelerate("Car", speed, isStarted);
        }

        public override void Brake()
        {
            if (isFlying)
            {
                System.Console.WriteLine("It is impossible to stop movement");
                return;
            }

            Accelerate("Aircraft",0, isStarted);
        }
    }
}