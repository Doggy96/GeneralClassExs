using GeneralClassExs.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class Cars : AutoMobil, IAytomobileActions, ICarActions
	{
		public Cars()
		{

		}
		public Cars(bool IsOn)
		{
			this.IsOn = IsOn;
		}



		public void SteerLeft(bool turnL )
		{
			Console.WriteLine("The car is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The car is breaking");
		}

		public void Reverse()
		{
			Console.WriteLine("The car is reversing");
		}

		public void SteerRight(bool turnR)
		{
			Console.WriteLine("The car is turning right");
		}

		public void Steer()
		{
			Console.WriteLine("The car is going straight");
		}
	}
}
