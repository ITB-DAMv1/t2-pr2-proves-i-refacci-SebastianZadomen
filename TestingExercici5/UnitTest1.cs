
using System;
using Xunit;
using ExerciseFive;

namespace TestingPersonaHelper
{
    public class PersonaHelperTests
    {
        [Theory]
        [InlineData(0, 0)] // Infància
        [InlineData(17, 0)] // Infància
        [InlineData(18, 1)] // Adulta
        [InlineData(65, 1)] // Adulta
        [InlineData(66, 2)] // Senescència
        [InlineData(120, 2)] // Senescència
        public void ClassifyAge_ValidAge_ReturnsExpectedClassification(int age, int expected)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            int result = helper.ClassifyAge(age);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(121)]
        public void ClassifyAge_InvalidAge_ReturnsNegativeOne(int age)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            int result = helper.ClassifyAge(age);

            // Assert
            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(0, true)]
        public void IsEven_ReturnsCorrectResult(int age, bool expected)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            bool result = helper.IsEven(age);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ana", true, true)]
        [InlineData("otto", true, true)]
        [InlineData("hello", false, false)]
        [InlineData("world", false, false)]
        public void NameAnalyser_ValidName_ReturnsExpectedResults(string name, bool isShort, bool isPalindrome)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            var result = helper.NameAnalyser(name);

            // Assert
            Assert.Equal(isShort, result.IsShort);
            Assert.Equal(isPalindrome, result.IsPalindrome);
        }

        [Theory]
        [InlineData("", -1)] // Invàlid
        [InlineData("blau", 0)] // Calmant
        [InlineData("verd", 0)] // Calmant
        [InlineData("vermell", 1)] // Exclusiu
        [InlineData("groc", 1)] // Exclusiu
        public void VerifyColour_ReturnsExpectedResults(string colour, int expected)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            int result = helper.VerifyColour(colour);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("matí", 0)] // Matinal
        [InlineData("nit", 1)] // Nocturna
        [InlineData("tarda", 2)] // Imprevista
        [InlineData("", 2)] // Imprevista
        public void PersonalityTest_ReturnsExpectedResults(string preference, int expected)
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            int result = helper.PersonalityTest(preference);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}