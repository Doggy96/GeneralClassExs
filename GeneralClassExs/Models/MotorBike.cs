using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class MotorBike : AutoMobil
	{
		private bool _isOn;

		public MotorBike()
		{
			
		}

		public MotorBike(bool IsOn)
		{
			this._isOn = true;
		}

		public override void SteerLeft()
		{
			Console.WriteLine("The motorbike is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The motorbike is breaking");
		}
	}
}
