using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class SnakeGrow : MonoBehaviour
{
    [SerializeField] private GameObject snakeSegmentPrefab;
    public LinkedList<GameObject> SnakeList = new LinkedList<GameObject>();
    public bool eatingFruit;

    public void AddNewSnakeSegment()
    {
        if (TryGetComponent(out SnakeMove move))
        {
            GameObject snakePart = Instantiate(snakeSegmentPrefab, move.previousPosition, Quaternion.identity); // previous pos
            SnakeList.AddNewSnakeNode(snakePart);
        }
        
        eatingFruit = false;
    }
}



