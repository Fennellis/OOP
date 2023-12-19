using _2.Classes;

// Car car1 = new("Tesla", "2", 2020, 1000, 700);
// car1.DisplayInfo();

// car1.Accelerate(30);
// car1.DisplayInfo();

// car1.Brake();
// car1.DisplayInfo();

// car1.Accelerate(30);
// car1.DisplayInfo();

// car1.Refuel(250);
// car1.DisplayInfo();

// car1.Refuel(250);
// car1.DisplayInfo();


// Boat boat1 = new("Astra", "safa", 10, 70);
// boat1.DisplayInfo();

// boat1.StartEngine();
// boat1.DisplayInfo();

// boat1.startSwimming();
// boat1.DisplayInfo();

// boat1.Accelerate(95);
// boat1.DisplayInfo();

// boat1.Brake();
// boat1.DisplayInfo();

// boat1.stopSwimming();
// boat1.DisplayInfo();


Aircraft plane = new("Boing", "737", 2005, 200, 350, 11000);
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");

plane.Accelerate(200);
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");

plane.TakeOff();
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");

plane.Accelerate(350);
plane.ChangeHeight(7000);
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");

plane.ChangeHeight(11500);  // Больше максимально допустимой
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");

plane.Land();
plane.DisplayInfo();
System.Console.WriteLine("---------------------------------------");
