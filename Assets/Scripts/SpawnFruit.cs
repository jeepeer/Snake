using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFruit : GameController
{
    [SerializeField] private GameObject fruit;
    private int randomIndexPosition = 0;
    private Vector3 newFruitPosition = Vector3.zero;
    
    public void SpawnFruitOnUnoccupiedTile(Vector3 snakePosition)
    {
        randomIndexPosition = Random.Range(0, tilePositions.Length);
        
        for (int i = 0; i < tilePositions.Length; i++)
        {
            if (i == randomIndexPosition && tilePositions[i] != snakePosition)
            {
                newFruitPosition = tilePositions[i];

                Instantiate(fruit, newFruitPosition, Quaternion.identity);
                break;
            }
        }
    }
}
