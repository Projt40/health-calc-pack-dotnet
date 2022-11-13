using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcIMC(double Height, double Weight)
        {
            //IMC=Peso dividido pela altura ao quadrado (peso/altura²)
            return Math.Round(Weight / (Math.Pow(Height,2)),2);
        }

        public double CalcImc(double Height, double Weight)
        {
            throw new NotImplementedException();
        }

        public string GetIMCCategory(double IMC)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(double Height, double Weight)
        {
            throw new NotImplementedException();
        }
    }

}
