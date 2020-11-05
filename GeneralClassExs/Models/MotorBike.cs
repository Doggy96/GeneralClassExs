﻿using GeneralClassExs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class MotorBike : AutoMobil, IAytomobileActions, IMotobikeActions
	{
		private bool _isOn;

		public MotorBike()
		{
			
		}

		public MotorBike(bool IsOn)
		{
			this._isOn = true;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The motorbike is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The motorbike is breaking");
		}

		public void SteerRight()
		{
			Console.WriteLine("The motorbike is turning right");
		}

		public void Steer()
		{
			Console.WriteLine("The motorbik is going straight");
		}

	}
}
