using System;
class Vehicle{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }
    public Vehicle(int maxspeed, string fueltype){
        MaxSpeed = maxspeed;
        FuelType = fueltype;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Max Speed: {MaxSpeed}");
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}
class Car : Vehicle{
    public int SeatCapacity { get; set; }
    public Car(int maxspeed, string fueltype, int seatcapacity) : base(maxspeed, fueltype){
        SeatCapacity = seatcapacity;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}\n");
    }
}
class Truck : Vehicle{
    public int PayLoadCapacity { get; set; }
    public Truck(int maxspeed, string fueltype, int payloadcapacity) : base(maxspeed, fueltype){
        PayLoadCapacity = payloadcapacity;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Pay Load Capacity: {PayLoadCapacity}\n");
    }
}
class Motorcycle : Vehicle{
    public bool HasSideCar { get; set; }
    public Motorcycle(int maxspeed, string fueltype, bool hassidecar) : base(maxspeed, fueltype){
        HasSideCar = hassidecar;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Has Side Car: {HasSideCar}\n");
    }
}
class Program{
    public static void Main(string[]args){
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(200, "Petrol", 5);
        vehicles[1] = new Truck(100, "Diesel", 1000);
        vehicles[2] = new Motorcycle(150, "Petrol", true);
       
        foreach (var vehicle in vehicles){
            if (vehicle is Car){
                Console.WriteLine("Car Details: ");
            }
            else if (vehicle is Truck){
                Console.WriteLine("Truck Details: ");
            }
            else if (vehicle is Motorcycle){
                Console.WriteLine("Motorcycle Details: ");
            }
            vehicle.DisplayInfo();
        }
    }
}
