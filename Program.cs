public class InterviewPractice
{
    public static void Main(string[] args)
    {
        List<int> ints = new List<int>() {0, 1, 2, 5, 11, 37, 40};
        Prime p = new Prime();
        foreach (int i in ints)
        {
            Console.WriteLine(i + ": " + p.IsPrime(i));
        }
    }
}