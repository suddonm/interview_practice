public class InterviewPractice
{
    public static void Main(string[] args)
    {
        // List<int> ints = new List<int>() {0, 1, 2, 5, 11, 37, 40};
        // Prime p = new Prime();
        // foreach (int i in ints)
        // {
        //     Console.WriteLine(i + ": " + p.IsPrime(i));
        // }

        Roads roadNetwork = new Roads();
        int n = 7;
        int[][] roads = [[0,6,7],[0,1,2],[1,2,3],[1,3,3],[6,3,3],[3,5,1],[6,5,1],[2,5,1],[0,4,5],[4,6,2]];

        roadNetwork.BuildNetwork(n, roads);
        //roadNetwork.PrintNetwork();
        roadNetwork.PrintAllPaths(roadNetwork.GetNode(0), roadNetwork.GetNode(5));
    }
}