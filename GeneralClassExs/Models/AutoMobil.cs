using GeneralClassExs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class AutoMobil 
	{
		
		private bool _isOn, _steering;
		

		public AutoMobil()
		{
			this._isOn = true;
		}

		public bool Steering
		{

			get { return _steering; }
			set { _steering = value; }
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

		

	}
}
