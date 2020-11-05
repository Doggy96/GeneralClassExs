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
			car.SteerLeft();
			car.SteerRight();
			car.Reverse();

			motor.Steer();
			motor.SteerLeft();
			motor.SteerRight();

			boat.Steer();
			boat.SteerLeft();
			boat.SteerRight();
			boat.Reverse();

		

			motor.Start();
			Console.WriteLine(motor.IsOn);
			motor.SteerLeft();
			motor.Stop();
			Console.WriteLine(motor.IsOn);

			car.Start();
			Console.WriteLine(car.IsOn);

			car.SteerLeft();

			car.Stop();
			Console.WriteLine(car.IsOn);

			Console.ReadLine();

		}




	
	}
}
