using UnityEditor;
using UnityEngine;

public class LinkedList<T>
{
    public SnakeNode head;
    public int count;

    public LinkedList()
    {
        head = default;
        count = 0;
    }

    public class SnakeNode
    {
        public T item;
        public SnakeNode next;
        public int index;

        public SnakeNode(T snakeItem, SnakeNode nextSnakeNode, int snakeIndex)
        {
            item = snakeItem;
            next = nextSnakeNode;
            index = snakeIndex;
        }
    }

    public void AddNewSnakeNode(T snakeItem)
    {
        SnakeNode newNode = new SnakeNode(snakeItem, null, count);

        if (count == 0)
        {
            head = newNode; 
        }
        
        else if (count > 0)
        {
            newNode.next = head;
            head = newNode;
        }
        
        count++;
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
