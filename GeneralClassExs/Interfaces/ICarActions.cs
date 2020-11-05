using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassExs.Interfaces
{
	interface ICarActions
	{
		void SteerLeft(bool turnL);
		void SteerRight(bool turnR);
		void Steer();
		void Break();
		void Reverse();
	}
}
