namespace Yully.TestStructureLibrary
{
	using System.Collections.Generic;
	using TestInterfaces;

	public class TestData
	{
		public static List<ITestSuite> TestSuites { get; set; }
		public static List<IRequirement> Requirements { get; set; }
	}
}