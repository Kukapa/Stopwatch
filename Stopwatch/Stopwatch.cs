namespace Stopwatch
{
    public partial class Program
    {
        public class Stopwatch
        {
            DateTime start;
            DateTime stop;

            public void Start()
            {
                start = DateTime.Now;
            }

            public void Stop()
            {
                stop = DateTime.Now;
                TimeSpan time = stop - start;
                Console.WriteLine("Differences in time: " + time);
            }
        }
    }
}