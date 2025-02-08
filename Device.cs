using System;
class Device{
    public int DeviceId { get; set; }
    public string Status { get; set; }
    public Device(int deviceid, string status){
        DeviceId = deviceid;
        Status = status;
    }
    public virtual void DisplayStatus(){
        Console.WriteLine($"Device Id: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
    }
}
class Thermostat : Device{
    public int TemperatureSetting { get; set; }
    public Thermostat(int deviceid, string status, int temperaturesetting) : base(deviceid, status){
        TemperatureSetting = temperaturesetting;
    }
    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}\n");
    }
}
class Program{
    public static void Main(string[]args){
        Thermostat thermo = new Thermostat(101, "On", 25);
        thermo.DisplayStatus();
    }
}
