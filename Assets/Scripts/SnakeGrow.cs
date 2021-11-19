using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class SnakeGrow : MonoBehaviour
{
    [SerializeField] private GameObject snakeSegmentPrefab;
    public LinkedList<GameObject> SnakeList = new LinkedList<GameObject>();
    public bool eatingFruit;

    private SnakeMove move;
    
    private void Start()
    {
        move = GetComponent<SnakeMove>();
    }
    
    public void AddNewSnakeSegment()
    {
        GameObject snakePart = Instantiate(snakeSegmentPrefab, move.previousPosition, Quaternion.identity);
        SnakeList.AddNewSnakeNode(snakePart);
        eatingFruit = false;
    }
}



