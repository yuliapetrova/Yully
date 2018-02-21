namespace Yully.TestInterfaces
{
	public class Requirement : IRequirement
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}