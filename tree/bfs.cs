public class bfs
{
    public class TreeNode
    {
        public int value;
        public List<TreeNode> children;

        public TreeNode(int _val)
        {
            value = _val;
            children = new List<TreeNode>();
        }
    }

    public TreeNode head;

    public bfs(int _val)
    {
        head = new TreeNode(_val);
    }

    public void PrintAllNodes()
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(head);

        while (q.Count > 0)
        {
            TreeNode temp = q.Dequeue();
            foreach (var n in temp.children)
            {
                q.Enqueue(n);
            }

            Console.WriteLine(temp);
        }
    }
}