

public class LinkedList<T>
{
    private SnakeNode head;

    public LinkedList()
    {
        head = default;
    }

    public class SnakeNode
    {
        public T item;
        public SnakeNode next;

        public SnakeNode(T snakeItem, SnakeNode nextSnakeNode)
        {
            item = snakeItem;
            next = nextSnakeNode;
        }
    }

    public int Count { get; set; }

    public void AddNewSnakeNode(T snakeItem)
    {
        SnakeNode newNode = new SnakeNode(snakeItem, null);

        if (Count == 0)
        {
            head = newNode; 
        }
        
        else if (Count > 0)
        {
            newNode.next = head;
            head = newNode;
        }
        
        Count++;
    }

    public T this[int index]
    {
        get
        {
            SnakeNode currentNode = head;
            int currentIndex = 0;
            while (currentIndex != index)
            {
                currentNode = currentNode.next;
                currentIndex++;
            }

            return currentNode.item;
        }
        set
        {
            SnakeNode currentNode = head;
            int currentIndex = 0;
            while (currentIndex != index)
            {
                currentNode = currentNode.next;
                currentIndex++;
            }

            currentNode.item = value;
        }
    }
}
