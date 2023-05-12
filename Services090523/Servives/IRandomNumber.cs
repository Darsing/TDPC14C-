using System;

namespace Services090523.Servives
{
    public interface IRandomNumber
    {
        int GeneratoreRandom();
    }

    public class RandomNumberLessThan10 : IRandomNumber
    {
        public int GeneratoreRandom()
        {
            Random r = new Random();
            int num1= r.Next(10);
            return num1;
        }
    }

    public class RandomNumberGreaterThan50 : IRandomNumber
    {
        public int GeneratoreRandom()
        {
            Random r = new Random();
            int num1 = r.Next(10, int.MaxValue);
            return num1;
        }
    }
}
