namespace Yully.TestGenerationInterfaces.Attributes
{
	using System;

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class PageMemberAttribute : Attribute
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Class { get; set; }
	}
}