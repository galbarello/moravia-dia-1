using System;
using Nancy;

namespace Moravia.Training.Web
{
	public class HomeModule:NancyModule
	{
		public HomeModule ()
		{
			Get ["/"] = _ => "hello world";
		}
	}
}

