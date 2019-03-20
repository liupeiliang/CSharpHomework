using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class OrderDetails
	{
		private string OrderNumbers;
		private string CargoName;
		private string ClientName;

		public void setOrderNumbers(string s) { OrderNumbers = s; }
		public void setCargoName(string s) { CargoName = s; }
		public void setClientName(string s) { ClientName = s; }

		public string getOrderNumbers() { return OrderNumbers; }
		public string getCargoName() { return CargoName; }
		public string getClientName() { return ClientName; }
	}

	class Order
	{
		private OrderDetails t = new OrderDetails();
		private int orderId;
		//other information
	
		public void setOrder(string a, string b, string c, int d)
		{
			t.setOrderNumbers(a);
			t.setCargoName(b);
			t.setClientName(c);
			orderId = d;
		}

		public bool equal(string a, string b, string c)
		{
			if (t.getOrderNumbers() != a) return false;
			if (t.getCargoName() != b) return false;
			if (t.getClientName() != c) return false;
			return true;
		}

		public bool equalOrderNumbers(string a)
		{
			if (t.getOrderNumbers() != a) return false;
				else return true;
		}

		public bool equalCargoName(string a)
		{
			if (t.getCargoName() != a) return false;
			else return true;
		}

		public bool equalClientName(string a)
		{
			if (t.getClientName() != a) return false;
			else return true;
		}

		public int getOrderId() { return orderId; }

		public void print()
		{
			Console.WriteLine(t.getOrderNumbers() + " " + t.getCargoName() + " " + t.getClientName() + " " + orderId);
		}

	}

	class OrderService
	{
		private int tot = 0;
		private List<Order> a = new List<Order>();

		public void addOrder(string OrderNumbers, string CargoName, string ClientName)
		{
			Order t = new Order();
			t.setOrder(OrderNumbers, CargoName, ClientName, ++tot);
			a.Add(t);
		}

		public void deleteOrder(string OrderNumbers, string CargoName, string ClientName)
		{
			foreach(Order t in a)
			{
				if(t.equal(OrderNumbers, CargoName, ClientName) == true)
				{
					a.Remove(t);
					Console.WriteLine("已成功删除该订单！");
					return;
				}
			}
			Console.WriteLine("错误！未找到该订单！");
		}

		public void modifyOrder(string OrderNumbers, string CargoName, string ClientName, string OrderNumbersNew, string CargoNameNew, string ClientNameNew)
		{
			foreach(Order t in a)
			{
				if(t.equal(OrderNumbers, CargoName, ClientName) == true)
				{
					t.setOrder(OrderNumbersNew, CargoNameNew, ClientNameNew, t.getOrderId());
					Console.WriteLine("已成功修改该订单！");
					return;
				}
			}
			Console.WriteLine("错误！未找到该订单！");
		}

		public void findOrderByOrderNumbers(string OrderNumbers)
		{
			Console.WriteLine("已找到以下订单：");
			foreach(Order t in a)
			{
				if(t.equalOrderNumbers(OrderNumbers) == true)
					t.print();
			}
		}

		public void findOrderByCargoName(string CargoName)
		{
			Console.WriteLine("已找到以下订单：");
			foreach (Order t in a)
			{
				if (t.equalCargoName(CargoName) == true)
					t.print();
			}
		}

		public void findOrderByClientName(string ClientName)
		{
			Console.WriteLine("已找到以下订单：");
			foreach (Order t in a)
			{
				if (t.equalClientName(ClientName) == true)
					t.print();
			}
		}

		public void showAllOrder()
		{
			Console.WriteLine("以下是所有订单信息：");
			foreach(Order t in a)
				t.print();
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			OrderService t = new OrderService();
			t.addOrder("a", "b", "c");
			t.addOrder("d", "e", "f");
			t.showAllOrder();
		}
	}
}
