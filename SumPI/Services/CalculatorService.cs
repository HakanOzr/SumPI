using SumPI.Model;
using System.Linq;

namespace SumPI.Services
{
    public class CalculatorService : ICalculatorService
    {
        public decimal CalculatePi(CalculateModel calculateModel)
        {

            decimal sum = Enumerable.Range(0, calculateModel.IterationCount).Sum(i => 8m / ((4m * i + 1m) * (4m * i + 3m)));

            return sum;
        }
    }
}

