using System;

class Earth
{
	double radius = 6378;
	
	public void CalculateVolume()
	{
		double earthVolumeKm = (4/3) * Math.PI * Math.Pow(radius, 3);
		double earthVolumeMiles = earthVolumeKm / 4.168;
		
		Console.WriteLine(string.Format("The volume of earth in cubic kilometers is {0} and cubic miles is {1}", earthVolumeKm, earthVolumeMiles));
	}
}
class Program
{
	static void Main()
	{
		Earth run = new Earth();
		run.CalculateVolume();
	}
}