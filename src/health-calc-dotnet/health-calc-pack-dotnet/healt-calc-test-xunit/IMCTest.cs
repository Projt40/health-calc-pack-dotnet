using health_calc_pack_dotnet;

namespace healt_calc_test_xunit
{
    public class IMCTest
    {
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndex()
        {
            //Aarrenge
            var Imc = new IMC();
            var Height = 1.68;
            var Weight = 85;
            var ExpectedMin = 30.12;

            //Act
            var Result = IMC.CalcImc(Height, Weight);

            //Assert
            Assert.Equal(Expected, Result);
        }
    }
}