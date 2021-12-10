using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Fruit : GameController
{
    public void MoveFruitToUnoccupiedTile(Vector3 snakePosition)
    {
        int randomIndexPosition = Random.Range(0, tilePositions.Length);
        
        for (int i = 0; i < tilePositions.Length; i++)
        {
            if (i == randomIndexPosition && tilePositions[i] != snakePosition)
            {
                Vector3 newFruitPosition = tilePositions[i];
                
                transform.position = RemoveEdges(newFruitPosition);;
                
                break;
            }
        }
    }

    private Vector3 RemoveEdges(Vector3 position)
    {
        if (position.x <= 0)
        {
            position.x += 1;
        }
        else if (position.x >= width-1)
        {
            position.x -= 1;
        }
        
        if (position.z <= 0)
        {
            position.z += 1;
        }
        else if (position.z >= height -1)
        {
            position.z -= 1;
        }

        return position;
    }
}
