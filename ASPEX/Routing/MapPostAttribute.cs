using System;

namespace ASPEX.Routing {
	[AttributeUsage(AttributeTargets.Method)]
	public class MapPostAttribute : Attribute {
		public string Template { get; }

		public MapPostAttribute(string template) {
			Template = template;
		}
	}
}
