using Xunit;

namespace TDD.Kata.StringCalculator.Tests.Unit
{
    public class UnitTestExample
    {
        private StringCalculator Target;

        public UnitTestExample()
        {
            this.Target = new StringCalculator();
        }

        [Fact]
        public void Example()
        {
            //Arrange
            //Your set up!. 

            //Act
            //Your principal action to test.

            //Assert
            //Your expected value.
        }


        [Fact]
        public void debe_devolver_cero_si_paso_vacio()
        {
            //Arrange
            
            //Act
            var result = this.Target.Add();

            //Assert
            Assert.Equal(result, 0);
        }
    }
}
