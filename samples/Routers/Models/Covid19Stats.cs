using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Routers.Models.Converters;

namespace Routers.Models {
	public record Covid19Stats {
		public string Type { get; init; }
		public string Name { get; init; }

		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime Timestamp { get; init; }

		public Covid19Numbers Numbers { get; init; }
		public List<Covid19Region> Regions { get; init; }
	}
}
