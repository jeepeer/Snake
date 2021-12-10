using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private GameObject fruit;
    private GameController gameController;
    private int randomIndexPosition;
    private Vector3 newFruitPosition;

    private void Start()
    {
        gameController = GetComponent<GameController>();
        SpawnFruitOnUnoccupiedTile(Vector3.zero);
    }

    private void SpawnFruitOnUnoccupiedTile(Vector3 exceptThisPosition)
    {
        Vector3[] tiles = gameController.tilePositions;

        randomIndexPosition = Random.Range(0, tiles.Length);
        
        for (int i = 0; i < tiles.Length; i++)
        {
            if (i == randomIndexPosition && tiles[i] != exceptThisPosition)
            {
                newFruitPosition = tiles[i];
                Instantiate(fruit, RemoveEdges(newFruitPosition), Quaternion.identity);
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
        else if (position.x >= gameController.width -1)
        {
            position.x -= 1;
        }
        
        if (position.z <= 0)
        {
            position.z += 1;
        }
        else if (position.z >= gameController.height -1)
        {
            position.z -= 1;
        }

        return position;
    }
}
