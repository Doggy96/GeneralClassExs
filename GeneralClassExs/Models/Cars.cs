using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Models
{
	class Cars : AutoMobil
	{
		public Cars()
		{

		}
		public Cars(bool IsOn)
		{
			this.IsOn = IsOn;
		}



		public override void SteerLeft()
		{
			Console.WriteLine("The car is steering left");
		}
	}
}
