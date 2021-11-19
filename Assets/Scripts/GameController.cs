using UnityEngine;

public class GameController : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    private int[,] grid;
    public Vector3[] tilePositions;

    private void Start()
    {
        tilePositions = new Vector3[width * height];
        
        BuildGrid();
        PlaceFruit();
    }

    private void BuildGrid() 
    {
        grid = new int[width, height];
        int n = 0;
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                tilePositions[n] = new Vector3(i,0,j);
                n++;
                PlaceTiles(i,j);
            }
        }
    }
    
    private void PlaceTiles(int x, int z)
    {
        if (TryGetComponent(out Tiles tiles))
        {
            tiles.SpawnTiles(x,z);
        }
    }

    private void PlaceFruit()
    {
        if (TryGetComponent(out SpawnFruit spawnFruit))
        {
            spawnFruit.SpawnFruitOnUnoccupiedTile(Vector3.zero); // snake always spawns at (0,0,0)
        }
    }
}
