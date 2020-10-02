using System;

namespace ExpressNetCore.Routing {
	[AttributeUsage(AttributeTargets.Method)]
	public class MapVerbAttribute : Attribute {
		public string Verb { get; }
		public string Template { get; }

		public MapVerbAttribute(string verb, string template) {
			Verb = verb;
			Template = template;
		}
	}
}
