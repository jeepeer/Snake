using UnityEngine;
using Random = UnityEngine.Random;

public class Fruit : MonoBehaviour
{
    public void MoveToRandomPosition(int gridX, int gridZ)
    {
        int x;
        int z;

        x = Random.Range(0, gridX);
        z = Random.Range(0, gridZ);

        Vector3 newFruitPosition = new Vector3(x, 0, z);

        transform.position = newFruitPosition;
    }
}
