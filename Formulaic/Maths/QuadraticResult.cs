namespace Formulaic.Maths
{
    public class QuadraticResult
    {
        public QuadraticRootType RootType { get; set; }
        public ComplexNumber FirstRoot { get; set; }
        public ComplexNumber SecondRoot { get; set; }

        public QuadraticResult()
        {
            FirstRoot = new ComplexNumber(0, 0);
            SecondRoot = new ComplexNumber(0, 0);
            RootType = QuadraticRootType.None;
        }
    }
}
