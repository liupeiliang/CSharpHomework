using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.ClientSize = new Size(600, 600);
			this.AutoScaleBaseSize = new Size(5, 13);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (graphics == null) graphics = this.CreateGraphics();
				else graphics.Clear(this.BackColor);
			k = double.Parse(parameterK.Text);
			per2 = double.Parse(len2.Text);
			per1 = double.Parse(len1.Text);
			th2 = double.Parse(angle2.Text) / 57.3;
			th1 = double.Parse(angle1.Text) / 57.3;
			drawCayleyTree(10, 300, 550, 100, -Math.PI / 2);
		}

		private Graphics graphics;
		double th1 = 30 * Math.PI / 180;
		double th2 = 20 * Math.PI / 180;
		double per1 = 0.6;
		double per2 = 0.7;
		double k = 1.2;

		void drawCayleyTree(int n, double x0, double y0, double leng, double th)
		{
			if (n == 0) return;
			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);
			double x2 = x0 + k * leng * Math.Cos(th);
			double y2 = y0 + k * leng * Math.Sin(th);
			drawLine(x0, y0, x2, y2);
			drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
			drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
		}

		void drawLine(double x0, double y0, double x1, double y1)
		{
			graphics.DrawLine(
				Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);

		}
	}
}
