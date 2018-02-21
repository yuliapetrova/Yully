namespace Yully.TestInterfaces
{
	using System.Collections.Generic;

	public class TestSuite : ITestSuite
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<ITestItem> TestItems { get; set; }

		public TestSuite()
		{
			TestItems = new List<ITestItem>();
		}
	}
}