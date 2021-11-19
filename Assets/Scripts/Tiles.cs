using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField] private GameObject placedTileParent;
    [SerializeField] private GameObject tile;
    private GameObject placedTile;

    public void SpawnTiles(int x, int z) 
    {
        Vector3 tilePlacement = new Vector3(x, 0, z);
        
        placedTile = Instantiate(tile, tilePlacement, Quaternion.identity);
        
        placedTile.transform.parent = placedTileParent.transform;
    }
}
