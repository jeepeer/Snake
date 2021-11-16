using UnityEngine;

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

        if (other.TryGetComponent(out Reload reload))
        {
            reload.Opsie();
        }
        
        // reload scene
        //SceneManager.LoadScene(0);
        //Debug.Log("dead");
    }
}
