// See https://aka.ms/new-console-template for more information
namespace Pi_Approximation_MC
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double NO_OF_ITERATIONS = 5.0e+6;

            int circle_points = 0;
            int square_points = 0;
            int interval = 0;

            Random rnd = new Random();

            while (true)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
                double d = x * x + y * y;
                if (d <= 1)
                {
                    circle_points++;
                }
                square_points++;
                interval++;
                if (interval > NO_OF_ITERATIONS)
                {
                    break;
                }
            }
            double circle_points_f = (double)circle_points;
            Console.Write("Approximation of Pi: ");
            double pi_approximation = 4 * (circle_points_f / square_points);
            Console.WriteLine(pi_approximation);
            Console.Write("True Value of Pi: ");
            Console.WriteLine(double.Pi);
            Console.Write("Error: ");
            double pi_error = Math.Abs(pi_approximation - double.Pi);
            Console.WriteLine(pi_error);
        }
    }
}