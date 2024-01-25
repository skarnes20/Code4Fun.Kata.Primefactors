namespace PrimeFactorsKata;

public class PrimeFactor
{
    public static IEnumerable<int> Of(int number)
    {
        for (var factor = 2; Math.Sqrt(factor) < number; factor++)
        {
            while (number % factor == 0)
            {
                number /= factor;
                yield return factor;
            }
        }

        if (number > 1)
        {
            yield return number;
        }
    }
}