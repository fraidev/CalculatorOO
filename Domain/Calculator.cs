namespace CalculatorOO.Domain
{
    public class Calculator 
    {
        public decimal Some(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal Subtract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }

        public decimal Multiply(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public decimal Divide(decimal value1, decimal value2)
        {
            return value1 / value2;
        }
    }
}