public class Roads
{
    public List<RoadNode> RoadNetwork;

    public class RoadNode
    {
        public int value;
        public Dictionary<RoadNode, int> Neighbors;

        public RoadNode(int _val)
        {
            value = _val;
            Neighbors = new Dictionary<RoadNode, int>();
        }
    }

    public Roads()
    {
        RoadNetwork = new List<RoadNode>();
    }

    public void BuildNetwork(int n, int[][] roads)
    {
        for (int i = 0; i < n; i++)
        {
            RoadNode temp = new RoadNode(i);
            foreach (var r in roads)
            {
                if (r[0] == i)
                {
                    temp.Neighbors.Add(new RoadNode(r[1]), r[2]);
                }

                if (r[1] == i)
                {
                    temp.Neighbors.Add(new RoadNode(r[0]), r[2]);
                }
            }

            RoadNetwork.Add(temp);
        }
    }

    public void PrintNetwork()
    {
        foreach (var n in RoadNetwork)
        {
            Console.Write("Node : " + n.value + ": ");
            foreach(var r in n.Neighbors)
            {
                Console.Write("(" + r.Key.value + ", " + r.Value + ") ");
            }

            Console.WriteLine();
        }
    }


    public List<RoadNode> FindShortestPath(RoadNode s, RoadNode d)
    {
        List<RoadNode> path = new List<RoadNode>();
        List<RoadNode> visited = new List<RoadNode>();

        Queue<RoadNode> qNext = new Queue<RoadNode>();

        


        return path;
    }

    public List<List<RoadNode>> FindAllPaths(RoadNode s, RoadNode d)
    {
        List<List<RoadNode>> paths = new List<List<RoadNode>>();
        List<RoadNode> visited = new List<RoadNode>();
        List<RoadNode> path = new List<RoadNode>();

        Queue<RoadNode> qNext = new Queue<RoadNode>();
        qNext.Enqueue(s);
        int level = 0;

        while (qNext.Count > 0)
        {
            RoadNode tmp = qNext.Dequeue();
            path.Add(tmp);
            foreach(var n in tmp.Neighbors)
            {
                if (!visited.Contains(n.Key))
                {
                    qNext.Enqueue(n.Key);
                    visited.Add(n.Key);
                }
            }

            level++;
        }

        return paths;
    }
}