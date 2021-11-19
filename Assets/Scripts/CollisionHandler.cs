using UnityEngine;

public class CollisionHandler : MonoBehaviour
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
            fruit.MoveFruitToUnoccupiedTile(transform.position);
        }

        else if (TryGetComponent(out GameOver gameOver))
        {
            gameOver.GameOverScreen();
        }
    }
}
