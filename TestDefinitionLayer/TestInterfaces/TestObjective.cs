namespace Yully.TestInterfaces
{
	using System.Collections.Generic;

	public class TestObjective : ITestObjective
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<ITestCase> TestCases { get; set; }

		public TestObjective()
		{
			TestCases = new List<ITestCase>();
		}
	}
}