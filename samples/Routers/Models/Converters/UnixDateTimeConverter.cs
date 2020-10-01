using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Routers.Models.Converters {
	public class UnixDateTimeConverter : JsonConverter<DateTime> {
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
			return DateTimeOffset.FromUnixTimeMilliseconds(reader.GetInt64()).DateTime;
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) {
			writer.WriteNumberValue(((DateTimeOffset)value).ToUnixTimeMilliseconds());
		}
	}
}
