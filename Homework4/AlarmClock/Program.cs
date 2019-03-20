using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class AlarmClock
	{
		public delegate void AlarmHandler();
		public event AlarmHandler alarmEvent;

		public void setAlarm()
		{
			if (alarmEvent != null)
				alarmEvent();
			else
			{
				Console.WriteLine("Error: no event! ");
			}
		}
	}

	public class User
	{
		public void print()
		{
			Console.WriteLine("请输入睡眠时间：");
			int t = Int32.Parse(Console.ReadLine());
			Console.WriteLine("即将睡眠" + t + "毫秒!");
			System.Threading.Thread.Sleep(t);
			Console.WriteLine("睡眠结束！");
		}
			
	}

	public class Test
	{
		static void Main(string[] args)
		{
			var alarm = new AlarmClock();
			var user = new User();
			alarm.alarmEvent += new AlarmClock.AlarmHandler( user.print );
			alarm.setAlarm();
		}
	}
}
