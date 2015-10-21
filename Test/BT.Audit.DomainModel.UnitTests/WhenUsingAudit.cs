using NUnit.Framework;

namespace BT.Audit.DomainModel.Unittests
{
	[TestFixture]
	public class WhenUsingAudit
	{
		[Test]
		public void DefaultConstructor_NoParams_SetsTimestamp()
		{
			//Arrange, Act
			Audit a = new Audit(string.Empty);

			//Assert
			Assert.IsNotNull(a.Timestamp);
		}

		[Test]
		public void DefaultConstructor_Category_SetsCategory()
		{
			//Arrange
			const string category = "System";

			//Act
			Audit a = new Audit(category);

			//Assert
			Assert.AreEqual(category, a.Category);
		}
	}
}
