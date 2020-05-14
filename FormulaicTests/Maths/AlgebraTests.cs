using FluentAssertions;
using Formulaic.Maths;
using Xunit;

namespace FormulaicTests
{
    public class AlgebraTests
    {
        [Fact]
        public void SolveQuadraticRealRootsTest()
        {
            var expected = new QuadraticResult()
            {
                RootType = QuadraticRootType.Real,
                FirstRoot = new ComplexNumber(1, 0),
                SecondRoot = new ComplexNumber(-1, 0)
            };

            var result = Algebra.SolveQuadratic(1, 0, -1);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void SolveQuadraticImaginaryRootsTest()
        {
            var expected = new QuadraticResult()
            {
                RootType = QuadraticRootType.Complex,
                FirstRoot = new ComplexNumber(5, 3),
                SecondRoot = new ComplexNumber(5, -3)
            };

            var result = Algebra.SolveQuadratic(1, -10, 34);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
