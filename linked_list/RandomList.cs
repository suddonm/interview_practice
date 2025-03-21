class RandomList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;
        
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }

    }

    public Node CopyRandomList(Node head) {
        
        if (head == null)
        {
            return null;
        }
        
        Dictionary<Node, Node> dicNodes = new Dictionary<Node, Node>();        
        Node curHead = head;

        while (curHead != null)
        {
            Node tmpNode = new Node(curHead.val);
            dicNodes.Add(curHead, tmpNode);
            curHead = curHead.next;
        }

        curHead = head;

        while (curHead != null)
        {
            if (curHead.next != null)
            {
                dicNodes[curHead].next = dicNodes[curHead.next];
            }            

            if (curHead.random != null)
            {
                dicNodes[curHead].random = dicNodes[curHead.random];
            }

            curHead = curHead.next;
        }

        return dicNodes.Values.ElementAt(0);
    }    
}