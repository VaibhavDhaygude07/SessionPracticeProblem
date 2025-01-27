using UnitTesting;

namespace TestPalindrom
{
    public class Tests
    {
        PalindromeChecker palindrome;
        [SetUp]
        public void Setup()
        {
            palindrome = new PalindromeChecker();
        }

        [Test]
        public void Test1()
        {
            //Arrange
            string str ="naman";
            bool expected = true;

            //Act
            var actual = palindrome.Palindrom(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}