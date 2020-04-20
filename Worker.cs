namespace DIConsole 
{
    public class Worker
    {
        private readonly ICalculator _calc;

        public Worker(ICalculator calc) => _calc = calc;

        public void Sum(string num1, string num2)
        {
            var (intNum1, intNum2) = (int.Parse(num1), int.Parse(num2));

            var result = _calc.Sum(intNum1, intNum2);

            System.Console.WriteLine($"Result: {result}");
        }
    }
}