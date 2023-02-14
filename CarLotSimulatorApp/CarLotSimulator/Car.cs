using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{

		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HornNoise { get; set; }
		public bool IsDrivable { get; set; }

		public Car(string make, string model, int year, string engineNoise, string hornNoise, bool isDrivable)
		{
			Make = make;
			Model = model;
			Year = year;
			EngineNoise = engineNoise;
			HornNoise = hornNoise;
			IsDrivable = isDrivable;

		}
	}
}

