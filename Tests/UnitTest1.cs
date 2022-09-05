using Calculator.App;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Calc calc = new Calc();
			Assert.IsNotNull(calc);

			Assert.AreEqual(2, Parser.ToArabic("II"));
			Assert.AreEqual(4, Parser.ToArabic("IV"));
			Assert.AreEqual(40, Parser.ToArabic("XL"));
			
		}
	}
}