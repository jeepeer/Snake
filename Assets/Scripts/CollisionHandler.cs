using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : Grid
{
    private SnakeGrow snakeGrow;
    private void Start()
    {
        snakeGrow = GetComponent<SnakeGrow>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (snakeGrow.eatingFruit == false && other.TryGetComponent(out Fruit fruit))
        {
            snakeGrow.eatingFruit = true;
            snakeGrow.AddNewSnakeSegment();
            
            fruit.MoveToRandomPosition(rows,collumns);
        }
        
        // reload scene
        //SceneManager.LoadScene(0);
    }
}
