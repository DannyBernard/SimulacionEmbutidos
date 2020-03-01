using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImulaciom
{
 public class Embutidos
	{
		public int tamano { get; set; }
		public string tipo { get; set; }
		public string estado { get; set; }


		public Embutidos()
		{
			tamano = 0;
			tipo = string.Empty;
			estado = string.Empty;
		}
	}
}
