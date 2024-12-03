using System;
using Xunit;
using ExerciseFive;

namespace TestingPersonaHelper
{
    public class PersonaHelperTests
    {
        
        [Fact]
        public void ClassifyAge_ZeroAge_ReturnsInfancia()
        {
            
            var helper = new PersonaHelper();

           
            int result = helper.ClassifyAge(0);

           
            Assert.Equal(0, result);
        }

        // Prueba de clasificación de edad para un valor fijo (18)
        [Fact]
        public void ClassifyAge_AdultAge_ReturnsAdult()
        {
            // Arrange
            var helper = new PersonaHelper();

            // Act
            int result = helper.ClassifyAge(18);

            // Assert
            Assert.Equal(1,result); 
        }
    }
}