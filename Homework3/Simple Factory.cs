using System;

namespace CSharpHomework
{
    public interface Chart { void display();  }

	class HistogramChart : Chart
	{
		public HistogramChart() { Console.WriteLine("Creating HistogramChart!"); }
		public void display() { Console.WriteLine("Display HistogramChart!"); }
	}

	class PieChart : Chart
	{
		public PieChart() { Console.WriteLine("Creating PieChart!"); }
		public void display() { Console.WriteLine("Dispaly PieChart!"); }
	}

	class LineChart : Chart
	{
		public LineChart() { Console.WriteLine("Creating LineChart!"); }
		public void display() { Console.WriteLine("Dispaly LineChart!"); }
	}

	class ChartFactory
	{
		public static Chart getChart(String type)
		{
			Chart chart = null;
			if (type == "histogram")
			{
				chart = new HistogramChart();
				Console.WriteLine("initializing HistogramChart!");
			}
			else if (type == "pie")
			{
				chart = new PieChart();
				Console.WriteLine("initializing PieChart!");
			}
			else if (type == "line")
			{
				chart = new LineChart();
				Console.WriteLine("initializing LineChart!");
			}
			return chart;
		}
	}

	class Client
	{
		public static void Main(String[] args)
		{
			Chart chart;
			chart = ChartFactory.getChart("histogram");
			chart.display();
		}
	}

}
