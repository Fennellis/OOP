using _2.Interfaces;

namespace _2.Classes
{
    public class Aircraft : Vehicle, Flyable
    {
        int maxAltitude;
        bool isFlying = false;
        static private int count = 0;

        public Aircraft(String brand, String model, int year, int maxAltitude) : base(brand, model, year)
        {
            id = ++count;
            this.maxAltitude = maxAltitude;
        }

        public Aircraft() : this("N/A", "N/A", 0, 0)
        {}
        public void Land()
        {
            
        }

        public void TakeOff()
        {
            
        }

        public override void DisplayInfo()
        {
            String status;
            if (isFlying)
                status = "Flying";
            else status = "Landed";
            System.Console.WriteLine($"Aircraft {id}: (brand: {brand} model: {model} year: {year} maxAltitude: {maxAltitude} Status: {status})");
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        // public override void Accelerate(int speed)
        // {
        //     throw new NotImplementedException();
        // }

        public override void Brake()
        {
            throw new NotImplementedException();
        }
    }
}