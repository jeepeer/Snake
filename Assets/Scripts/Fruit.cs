using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Fruit : GameController
{
    private int randomIndexPosition = 0;
    private Vector3 newFruitPosition = Vector3.zero;

    public void MoveFruitToUnoccupiedTile(Vector3 snakePosition)
    {
        randomIndexPosition = Random.Range(0, tilePositions.Length);
        
        for (int i = 0; i < tilePositions.Length; i++)
        {
            if (i == randomIndexPosition && tilePositions[i] != snakePosition)
            {
                newFruitPosition = tilePositions[i];

                transform.position = newFruitPosition;
                
                break;
            }
        }
    }
}
