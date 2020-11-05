using GeneralClassExs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class Boat : AutoMobil, IAytomobileActions, IBoatActions
	{
		public Boat()
		{

		}
		public Boat(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft(bool turnL)
		{
			Console.WriteLine("The boat is turning left");

		}

		public void Reverse()
		{
			Console.WriteLine("The boat is reversing");

		}

		public void SteerRight(bool turnR)
		{
			Console.WriteLine("The boat is turning right");

		}

		public void Steer()
		{
			Console.WriteLine("The boat is going straight");

		}
	}
}
