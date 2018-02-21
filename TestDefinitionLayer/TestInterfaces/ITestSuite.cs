namespace Yully.TestInterfaces
{
	using System.Collections.Generic;

	public interface ITestSuite : ITestItem
	{
		List<ITestItem> TestItems { get; set; }
	}
}