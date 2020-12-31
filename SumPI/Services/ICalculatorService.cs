using SumPI.Model;

namespace SumPI.Services
{
    public interface ICalculatorService
    {
        decimal CalculatePi(CalculateModel calculateModel);
    }
}
