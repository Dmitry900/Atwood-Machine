using Atwood;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Атвуд
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public Form2(Form1 f)
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		public void GR(float t, float v, float a, float b)
		{
			chart1.Series[0].Points.AddXY(t, v);
			chart1.Series[1].Points.AddXY(t, a * v * v / 2);
			chart1.Series[2].Points.AddXY(t, b * v * v / 2);
		}

      private void chart1_Click(object sender, EventArgs e)
      {

      }
   }
}
