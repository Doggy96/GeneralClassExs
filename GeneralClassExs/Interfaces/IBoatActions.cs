using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Interfaces
{
	interface IBoatActions
	{
		void Reverse();
		void SteerRight(bool turnR);
		void SteerLeft(bool turnL);
		void Steer();
	}
}
