﻿using System;

namespace ASPEX.Routing {
	[AttributeUsage(AttributeTargets.Method)]
	public class MapDeleteAttribute : Attribute {
		public string Template { get; }

		public MapDeleteAttribute(string template) {
			Template = template;
		}
	}
}
