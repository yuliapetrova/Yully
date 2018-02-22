namespace Yully.TestInterfaces
{
	using System.Collections.Generic;

	public interface INonTestItem
	{
		// TODO: move these properties to a smaller interface and reuse this smaller interface in ITestItem interface too
		long Id { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		List<ITestCase> TestCases { get; set; }
	}
}