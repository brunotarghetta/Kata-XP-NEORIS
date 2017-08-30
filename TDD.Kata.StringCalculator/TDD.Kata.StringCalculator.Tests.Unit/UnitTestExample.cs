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
            var result = this.Target.Add("");

            //Assert
            Assert.Equal(result, 0);
        }

        [Fact]
        public void debe_devolver_mismo_numero_que_ingrese()
        {
            //Arrange
            var parameter = "1";
            //Act
            var result = this.Target.Add(parameter);

            //Assert
            Assert.Equal(result, 1);
        }


        [Fact]
        public void debe_devolver_suma_dos_valores_separados_por_coma()
        {
            //Arrange
            var parameter = "1,2";
            //Act
            var result = this.Target.Add(parameter);

            //Assert
            Assert.Equal(result, 3);
        }

        [Fact]
        public void debe_devolver_suma_n_valores_separados_por_coma()
        {
            //Arrange
            var parameter = "1,2,3";
            //Act
            var result = this.Target.Add(parameter);

            //Assert
            Assert.Equal(result, 6);
        }
    }
}
