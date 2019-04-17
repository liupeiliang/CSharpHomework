using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests
{
	[TestClass()]
	public class OrderServiceTests
	{
		[TestMethod()]
		public void AddOrderTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			os.AddOrder(or);
			bool flag = true;
			List<Order> a = os.QueryAll();
			if (a.Count() != 1) flag = false;
			if (a[0].Id != 2019) flag = false;
			if (a[0].Customer.Id != 1998) flag = false;
			if (a[0].Customer.Name != "peiliang") flag = false;
			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void UpdateTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			os.AddOrder(or);
			or.Id = 2018;
			bool flag = true;
			List<Order> a = os.QueryAll();
			if (a[0].Id != 2018) flag = false;
			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void GetByIdTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			os.AddOrder(or);
			bool flag = true;
			Order or2 = os.GetById(2019);
			if (or2.Id != 2019) flag = false;
			if (or2.Customer.Id != 1998) flag = false;
			if (or2.Customer.Name != "peiliang") flag = false;
			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void RemoveOrderTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			os.AddOrder(or);
			os.RemoveOrder(2019);
			bool flag = true;
			List<Order> a = os.QueryAll();
			if (a.Count() != 0) flag = false;
			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void QueryAllTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			os.AddOrder(or);
			bool flag = true;
			List<Order> a = os.QueryAll();
			if (a.Count() != 1) flag = false;
			if (a[0].Id != 2019) flag = false;
			if (a[0].Customer.Id != 1998) flag = false;
			if (a[0].Customer.Name != "peiliang") flag = false;
			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void QueryByGoodsNameTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			Goods good = new Goods(1, "pencil", (float)1.1);
			OrderDetail ord = new OrderDetail(good, 99);
			or.AddDetails(ord);
			os.AddOrder(or);
			bool flag = true;
			List<Order> a = os.QueryByGoodsName("pencil");
			List<OrderDetail> b = a[0].Details;
			if (a.Count() != 1) flag = false;
			else if (a[0].Id != 2019) flag = false;
			else if (a[0].Customer.Id != 1998) flag = false;
			else if (a[0].Customer.Name != "peiliang") flag = false;
			else if (b.Count() != 1) flag = false;
			else if (b[0].Quantity != 99) flag = false;
			else if (b[0].Goods.Id != 1) flag = false;
			else if (b[0].Goods.Name != "pencil") flag = false;
			else if (b[0].Goods.Price != (float)1.1) flag = false;

			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void QueryByTotalAmountTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			Goods good = new Goods(1, "pencil", (float)1.1);
			OrderDetail ord = new OrderDetail(good, 99);
			or.AddDetails(ord);
			os.AddOrder(or);
			bool flag = true;
			List<Order> a = os.QueryByTotalAmount((float)1.1*99);
			List<OrderDetail> b = a[0].Details;
			if (a.Count() != 1) flag = false;
			else if (a[0].Id != 2019) flag = false;
			else if (a[0].Customer.Id != 1998) flag = false;
			else if (a[0].Customer.Name != "peiliang") flag = false;
			else if (b.Count() != 1) flag = false;
			else if (b[0].Quantity != 99) flag = false;
			else if (b[0].Goods.Id != 1) flag = false;
			else if (b[0].Goods.Name != "pencil") flag = false;
			else if (b[0].Goods.Price != (float)1.1) flag = false;

			Assert.IsTrue(flag);
		}

		[TestMethod()]
		public void QueryByCustomerNameTest()
		{
			OrderService os = new OrderService();
			Customer cu = new Customer(1998, "peiliang");
			Order or = new Order(2019, cu);
			Goods good = new Goods(1, "pencil", (float)1.1);
			OrderDetail ord = new OrderDetail(good, 99);
			or.AddDetails(ord);
			os.AddOrder(or);
			bool flag = true;
			List<Order> a = os.QueryByCustomerName("peiliang");
			List<OrderDetail> b = a[0].Details;
			if (a.Count() != 1) flag = false;
			else if (a[0].Id != 2019) flag = false;
			else if (a[0].Customer.Id != 1998) flag = false;
			else if (a[0].Customer.Name != "peiliang") flag = false;
			else if (b.Count() != 1) flag = false;
			else if (b[0].Quantity != 99) flag = false;
			else if (b[0].Goods.Id != 1) flag = false;
			else if (b[0].Goods.Name != "pencil") flag = false;
			else if (b[0].Goods.Price != (float)1.1) flag = false;

			Assert.IsTrue(flag);
		}
	}
}