using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImulaciom
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int Random()
		{
		var	semilla = (int)DateTime.Now.Ticks;
			Random r = new Random(semilla);
			return r.Next(1, 4);
		}
		Embutidos empaqueDeSalami()
		{
			List<Embutidos> listE = new List<Embutidos>();
			//int a = Random();
			Embutidos e = new Embutidos();
			for (int i = 0; i < 100; i++)
				{
				

					int a = Random();
					if (a == 1)
					{
						e.tamano = a;
						e.tipo = "Pequeño";
						if (a == 1)
						{
							e.estado = "Empaque Exitoso";
						}
						else
						{
							e.estado = "empaque fallido";
						}
					}
					else if (a == 2)
					{
						e.tamano = a;
						e.tipo = "Mediano";
						if (a == 1)
						{
							e.estado = "Empaque Exitoso";
						}
						else
						{
							e.estado = "empaque fallido";
						}
					}
					else if (a == 3)
					{
						e.tamano = a;
						e.tipo = "Grande";
						if (a == 1)
						{
							e.estado = "Empaque Exitoso";
						}
						else
						{
							e.estado = "empaque fallido";
						}
					}
				
				}


			return e;




		}
		/*
		public void LlenarGrid()
		{
			List<Embutidos> listE = new List<Embutidos>();
			Embutidos e = new Embutidos();
			listE.Add(e);
			dataGridView1.DataSource = listE;
		}
		*/
		private void button1_Click(object sender, EventArgs e)
		{
			
				empaqueDeSalami();
		
		}

	}
}
