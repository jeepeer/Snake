using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField] private GameObject tile;
    
    public void SpawnTiles(int x, int z) 
    {
        Vector3 tilePlacement = new Vector3(x, 0, z);
        Instantiate(tile, tilePlacement, Quaternion.identity);
    }
}
