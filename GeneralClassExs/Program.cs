using GeneralClassExs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs
{
	class Program
	{
		static void Main(string[] args)
		{
			Cars car = new Cars(true);
			MotorBike motor = new MotorBike(true);
			Boat boat = new Boat();

			car.Steer();
			
			car.SteerLeft(false);
			car.SteerRight(false);
			car.Reverse();

			motor.Steer();
			motor.SteerLeft(true);
			motor.SteerRight(false);

			boat.Steer();
			boat.SteerLeft(true);
			boat.SteerRight(false);
			boat.Reverse();

		

			motor.Start();
			Console.WriteLine(motor.IsOn);
			motor.SteerLeft(false);
			motor.Stop();
			Console.WriteLine(motor.IsOn);

			car.Start();
			Console.WriteLine(car.IsOn);

			car.Stop();
			Console.WriteLine(car.IsOn);

			Console.ReadLine();

		}
	
	}
}
