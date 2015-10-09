//A short code in C# to display a ticking clock 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading;

class Program 
{ 
	public void ShowTime() 
	{ 
		for (; ; ) 
		{ 
			Console.WriteLine(DateTime.Now.ToString()); 
			Console.WriteLine("\a"); Thread.Sleep(1000); 
			Console.Clear(); 
		} 
	} 
	
	static void Main(string[] args) 
	{ 
		Program PC = new Program(); 
		ThreadStart TS = new ThreadStart(PC.ShowTime); 
		Thread t = new Thread(TS); 
		t.Start(); Console.ReadLine(); 
	} 
}
