using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private GameObject fruit;

    private void Start()
    {
        FruitSpawner();
    }

    private void FruitSpawner()
    {
        Instantiate(fruit, FruitSpawnPosition(10, 10), Quaternion.identity);
    }
    
    private Vector3 FruitSpawnPosition(int gridX, int gridZ)
    {
        int randomX = Random.Range(0, gridX);
        int randomZ = Random.Range(0, gridZ);

        Vector3 SpawnPosition = new Vector3(randomX, 0, randomZ);
        return SpawnPosition;
    }
}
