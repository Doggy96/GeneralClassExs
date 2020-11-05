﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	abstract class AutoMobil
	{
		private bool _isOn;

		//public Cars()
		//{
		//	//this._isOn = true;
		//}

		public AutoMobil()
		{
			this._isOn = true;
		}

		public bool IsOn
		{
			get { return _isOn; }
			private protected set { _isOn = value; }
		}

		public void Start()
		{
			this._isOn = true;
		}

		public void Stop()
		{
			this.IsOn = false;
		}

		abstract public void SteerLeft();
		//abstract public void SteerRight();
		//abstract public void Steer(bool steerLeft);

	}
}
