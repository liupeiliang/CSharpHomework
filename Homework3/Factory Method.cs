using System;

namespace CSharpHomework
{
	//日志记录器接口：抽象产品  
	public interface Logger { void WriteLog();  }

	//数据库日志记录器：具体产品  
	class DatabaseLogger : Logger
	{
		public void WriteLog() { Console.WriteLine("数据库日志记录。"); }
	}

	//文件日志记录器：具体产品  
	class FileLogger : Logger
	{
		public void WriteLog() { Console.WriteLine("文件日志记录。"); }
	}

	//日志记录器工厂接口：抽象工厂 
	public interface LoggerFactory
	{
		Logger CreateLogger();
	}

	//数据库日志记录器工厂类：具体工厂  
	class DatabaseLoggerFactory : LoggerFactory
	{
		public Logger CreateLogger()
		{
			//连接数据库，代码省略  
			//创建数据库日志记录器对象  
			Logger logger = new DatabaseLogger();
			//初始化数据库日志记录器，代码省略  
			return logger;
		}
	}

	//文件日志记录器工厂类：具体工厂  
	class FileLoggerFactory : LoggerFactory
	{
		public Logger CreateLogger()
		{
			//创建文件日志记录器对象  
			Logger logger = new FileLogger();
			//创建文件，代码省略  
			return logger;
		}
	}

	class Client
	{
		public static void Main(String [] args)
		{
			LoggerFactory factory;
			Logger logger;
			factory = new FileLoggerFactory(); //可引入配置文件实现  
			logger = factory.CreateLogger();
			logger.WriteLog();
		}
	}

}
