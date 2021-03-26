using System;

namespace Modul_3_Practice_2
{
    public class Task_Delegate
    {
        private event Func<double, double, double> SumHandler;

        public void Start()
        {
            SumHandler += Calc;
            SumHandler += Calc;
            double result = 0;

            TryCalculate(() =>
            {
                var invokationList = SumHandler.GetInvocationList();
                foreach (var item in invokationList)
                {
                    result += (double)item.DynamicInvoke(2, 2);
                }
            });
            Console.WriteLine($"Task_Delegate: {result}");
        }

        public double Calc(double x, double y) => x + y;

        public void TryCalculate(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
