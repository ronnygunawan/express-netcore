using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ASPEX {
	[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "<Pending>")]
	public class Int {
		public int Value { get; }

		public Int(int value) {
			Value = value;
		}

		[SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
		public static implicit operator Int(int value) => new Int(value);

		[SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
		public static implicit operator int(Int @int) => @int.Value;

		public static bool operator ==(Int left, Int right) => EqualityComparer<Int>.Default.Equals(left, right);
		public static bool operator ==(Int left, int right) => EqualityComparer<Int>.Default.Equals(left, right);
		public static bool operator ==(int left, Int right) => EqualityComparer<Int>.Default.Equals(left, right);
		public static bool operator !=(Int left, Int right) => !(left == right);
		public static bool operator !=(Int left, int right) => !(left == right);
		public static bool operator !=(int left, Int right) => !(left == right);

		public override bool Equals(object? obj) => (obj is Int @int && Value == @int.Value) || (obj is int i && Value == i);
		public override int GetHashCode() => Value.GetHashCode();
	}
}
