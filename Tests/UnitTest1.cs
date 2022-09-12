using Calculator.App;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		 [TestMethod]
        public void TestMethod1()
        {
            Calc calculator = new Calc();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void RomanNumberParse1Digit()
        {
            Assert.AreEqual(0, RomanNumber.Parse("N"));
            Assert.AreEqual(1, RomanNumber.Parse("I"));
            Assert.AreEqual(5, RomanNumber.Parse("V"));
            Assert.AreEqual(10, RomanNumber.Parse("X"));
            Assert.AreEqual(50, RomanNumber.Parse("L"));
            Assert.AreEqual(100, RomanNumber.Parse("C"));
            Assert.AreEqual(500, RomanNumber.Parse("D"));
            Assert.AreEqual(1000, RomanNumber.Parse("M"));
        }

        [TestMethod]
        public void RomanNumberParse2Digits()
        {
            Assert.AreEqual(2, RomanNumber.Parse("II"));
            Assert.AreEqual(4, RomanNumber.Parse("IV"));
            Assert.AreEqual(9, RomanNumber.Parse("IX"));
            Assert.AreEqual(15, RomanNumber.Parse("XV"));
            Assert.AreEqual(20, RomanNumber.Parse("XX"));
            Assert.AreEqual(40, RomanNumber.Parse("XL"));
            Assert.AreEqual(90, RomanNumber.Parse("XC"));
            Assert.AreEqual(110, RomanNumber.Parse("CX"));
            Assert.AreEqual(400, RomanNumber.Parse("CD"));
            Assert.AreEqual(900, RomanNumber.Parse("CM"));
            Assert.AreEqual(2000, RomanNumber.Parse("MM"));
        }

        [TestMethod]
        public void RomanNumberParse3MoreDigits()
        {
            Assert.AreEqual(3, RomanNumber.Parse("III"));
            Assert.AreEqual(12, RomanNumber.Parse("XII"));
            Assert.AreEqual(104, RomanNumber.Parse("CIV"));
            Assert.AreEqual(2001, RomanNumber.Parse("MMI"));
            Assert.AreEqual(13, RomanNumber.Parse("XIII"));
            Assert.AreEqual(1999, RomanNumber.Parse("MCMXCIX"));
            Assert.AreEqual(2022, RomanNumber.Parse("MMXXII"));
        }

        [TestMethod]
        public void RomanNumberParseInvalidDigit()
        {

            var exc = // Assert.Throws ïîâåðòàº âèêëþ÷åííÿ, ùî áóëî ó ïåðåâ³ðö³
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("A")
                );

            Assert.AreEqual("Invalid digit 'A'", exc.Message);

            Assert.AreEqual(
                "Invalid digit '1'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("1")
                ).Message
            );

            Assert.AreEqual(
                "Invalid digit '0'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("0")
                ).Message
            );

            Assert.AreEqual(
                "Invalid digit 'G'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("G")
                ).Message
            );

            Assert.AreEqual(
                "Invalid digit 'Ї'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("Ї")
                ).Message
            );

            Assert.AreEqual(
                "Invalid digit '%'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("%")
                ).Message
            );

            Assert.AreEqual(
                "Invalid digit '@'",
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("@")
                ).Message
            );
        }

        [TestMethod]
        public void RomanNumberParseInvalidNumber()
        {
            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("XIX1")
                ).Message.StartsWith("Invalid digit")
            );

            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse(" XX")
                ).Message.StartsWith("Invalid digit")
            );

            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("X X")
                ).Message.StartsWith("Invalid digit")
            );

            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("XX ")
                ).Message.StartsWith("Invalid digit")
            );

            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("cxx")
                ).Message.StartsWith("Invalid digit")
            );

            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse("hello")
                ).Message.StartsWith("Invalid digit")
            );
        }

        [TestMethod]
        public void RomanNumberParseEmpty()
        {
            Assert.IsTrue(
                Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse(String.Empty)
                ).Message.StartsWith("Invalid format")
            );
			Assert.IsTrue(
				Assert.ThrowsException<ArgumentException>(
					() => RomanNumber.Parse(null)
				).Message.StartsWith("Invalid format")
			);
		}
		[TestMethod]
		public void RomanNumberParseN()
		{
            Assert.AreEqual(0, RomanNumber.Parse("N"));
			Assert.IsTrue(
				Assert.ThrowsException<ArgumentException>(
					() => RomanNumber.Parse("XN")
				).Message.StartsWith("Invalid format")
			);
			Assert.IsTrue(
				Assert.ThrowsException<ArgumentException>(
					() => RomanNumber.Parse("NX")
				).Message.StartsWith("Invalid format")
			);
			Assert.IsTrue(
				Assert.ThrowsException<ArgumentException>(
					() => RomanNumber.Parse("NNN")
				).Message.StartsWith("Invalid format")
			);
		}
	}
}