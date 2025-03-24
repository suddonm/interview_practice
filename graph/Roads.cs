using System.Reflection.Metadata.Ecma335;

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

    public RoadNode GetNode(int id)
    {
        return RoadNetwork[id];
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

    public void PrintAllPaths(RoadNode s, RoadNode d)
    {
        foreach (var l in FindAllPaths(s, d, new List<RoadNode>()))
        {
            foreach (var n in l)
            {
                Console.Write(n.value + " ");                
            }

            Console.WriteLine();
        }
    }

    public List<List<RoadNode>> FindAllPaths(RoadNode s, RoadNode d, List<RoadNode> visited)
    {
        if (s == null)
        {
            return null;
        }

        List<List<RoadNode>> paths = new List<List<RoadNode>>();

        if (s == d)
        {
            paths.Add(new List<RoadNode>() { s });
            return paths;   
        }        
                
        Queue<RoadNode> qNext = new Queue<RoadNode>();
        qNext.Enqueue(s);

        while (qNext.Count > 0)
        {
            RoadNode tmp = qNext.Dequeue();

            foreach(var n in tmp.Neighbors)
            {
                if (!visited.Contains(n.Key))
                {
                    qNext.Enqueue(n.Key);
                    visited.Add(n.Key);
                }

                paths.Concat(FindAllPaths(n.Key, d, visited));
            }
        }

        return paths;
    }

    public List<RoadNode> FindPath(RoadNode s, RoadNode d, List<RoadNode> visited)
    {
        if (s == null)
        {
            return null;
        }

        if (s == d)
        {
            return new List<RoadNode>() { s };
        }

        List<RoadNode> l = new List<RoadNode> { s };

        foreach (var n in s.Neighbors)
        {
            visited.Add(s);
            List<RoadNode> temp = FindPath(n.Key, d, visited);
            if (temp != null)
            {
                l.Concat(temp);
            }
        }

        return l;
    }
}