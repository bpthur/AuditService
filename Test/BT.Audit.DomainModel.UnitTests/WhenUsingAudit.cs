using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BT.Audit.DomainModel.Unittests
{
	[TestClass]
	public class WhenUsingAudit
	{
		[TestMethod]
		public void DefaultConstructor_NoParams_SetsTimestamp()
		{
			//Arrange, Act
			Audit a = new Audit(string.Empty);

			//Assert
			Assert.IsNotNull(a.Timestamp);
		}

		[TestMethod]
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
